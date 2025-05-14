using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobFairManagementSystem
{
    public partial class JobFairDetailsForm : Form
    {
        private string fairId;
        private string fairName;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";

        public JobFairDetailsForm(string fairId, string fairName)
        {
            InitializeComponent();
            this.fairId = fairId;
            this.fairName = fairName;

            // Set labels
            lblFairNameValue.Text = fairName;

            // Load fair details
            LoadFairDetails();
        }

        private void LoadFairDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Get job fair details
                    string query = @"
                        SELECT 
                            EventTitle,
                            CONVERT(VARCHAR(10), EventDate, 101) AS EventDateFormatted,
                            CONCAT(CONVERT(VARCHAR(10), StartTime, 108), ' - ', CONVERT(VARCHAR(10), EndTime, 108)) AS TimeRange,
                            Venue
                        FROM JobFairEvents
                        WHERE JobFairID = @JobFairID";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JobFairID", fairId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblFairNameValue.Text = reader["EventTitle"].ToString();
                                lblDateValue.Text = reader["EventDateFormatted"].ToString();
                                lblTimeValue.Text = reader["TimeRange"].ToString();
                                lblVenueValue.Text = reader["Venue"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Job fair details not found.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                                return;
                            }
                        }
                    }
                    
                    // Get description for this job fair (no specific field in DB, so we'll generate one)
                    DateTime fairDate = DateTime.MinValue;
                    string fairVenue = string.Empty;
                    
                    query = @"
                        SELECT 
                            EventDate,
                            Venue
                        FROM JobFairEvents
                        WHERE JobFairID = @JobFairID";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JobFairID", fairId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fairDate = Convert.ToDateTime(reader["EventDate"]);
                                fairVenue = reader["Venue"].ToString();
                            }
                        }
                    }
                    
                    // Generate descriptive text based on the venue and date
                    string seasonYear = (fairDate.Month >= 3 && fairDate.Month <= 5) ? "Spring" :
                                      (fairDate.Month >= 6 && fairDate.Month <= 8) ? "Summer" :
                                      (fairDate.Month >= 9 && fairDate.Month <= 11) ? "Fall" : "Winter";
                    
                    txtDescription.Text = $"The {seasonYear} {fairDate.Year} Career Fair at {fairVenue} is an excellent opportunity for " +
                    "students to connect with top companies in the IT industry. Companies will be recruiting for " +
                    "both internships and full-time positions. Don't miss this opportunity to network and find your dream job!";
                
                    // Get participating companies
                    dgvCompanies.Rows.Clear();
                    
                    query = @"
                        SELECT
                            c.CompanyName,
                            STRING_AGG(jp.JobTitle, ', ') AS OpenPositions,
                            COUNT(jp.JobID) AS NumPositions
                        FROM Companies c
                        JOIN BoothVisits bv ON c.CompanyID = bv.CompanyID
                        JOIN JobPostings jp ON c.CompanyID = jp.CompanyID
                        WHERE bv.JobFairID = @JobFairID
                        GROUP BY c.CompanyName
                        ORDER BY c.CompanyName";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JobFairID", fairId);
                        
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                bool hasCompanies = false;
                                
                                while (reader.Read())
                                {
                                    hasCompanies = true;
                                    dgvCompanies.Rows.Add(
                                        reader["CompanyName"].ToString(),
                                        reader["OpenPositions"].ToString(),
                                        reader["NumPositions"].ToString()
                                    );
                                }
                                
                                // If no companies found, try an alternative approach
                                if (!hasCompanies)
                                {
                                    // Fallback query to get all companies with job postings
                                    reader.Close();
                                    
                                    string fallbackQuery = @"
                                        SELECT
                                            c.CompanyName,
                                            STRING_AGG(jp.JobTitle, ', ') AS OpenPositions,
                                            COUNT(jp.JobID) AS NumPositions
                                        FROM Companies c
                                        JOIN JobPostings jp ON c.CompanyID = jp.CompanyID
                                        GROUP BY c.CompanyName
                                        ORDER BY COUNT(jp.JobID) DESC
                                        OFFSET 0 ROWS FETCH NEXT 5 ROWS ONLY";
                                    
                                    using (SqlCommand fallbackCommand = new SqlCommand(fallbackQuery, connection))
                                    {
                                        using (SqlDataReader fallbackReader = fallbackCommand.ExecuteReader())
                                        {
                                            while (fallbackReader.Read())
                                            {
                                                dgvCompanies.Rows.Add(
                                                    fallbackReader["CompanyName"].ToString(),
                                                    fallbackReader["OpenPositions"].ToString(),
                                                    fallbackReader["NumPositions"].ToString()
                                                );
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // If STRING_AGG fails (older SQL versions), use a simpler approach
                            string simpleQuery = @"
                                SELECT TOP 5
                                    c.CompanyName,
                                    'Multiple Positions' AS OpenPositions,
                                    COUNT(jp.JobID) AS NumPositions
                                FROM Companies c
                                JOIN JobPostings jp ON c.CompanyID = jp.CompanyID
                                GROUP BY c.CompanyName
                                ORDER BY COUNT(jp.JobID) DESC";
                            
                            using (SqlCommand simpleCommand = new SqlCommand(simpleQuery, connection))
                            {
                                using (SqlDataReader simpleReader = simpleCommand.ExecuteReader())
                                {
                                    while (simpleReader.Read())
                                    {
                                        dgvCompanies.Rows.Add(
                                            simpleReader["CompanyName"].ToString(),
                                            simpleReader["OpenPositions"].ToString(),
                                            simpleReader["NumPositions"].ToString()
                                        );
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading job fair details: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Set some default text as fallback
                txtDescription.Text = "Details for this job fair are coming soon!";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to register for the {fairName}?", 
                "Confirm Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int studentId = 0;
                    
                    // Find the current student's ID (this would normally come from login session)
                    // For simplicity, we'll get the first student ID from the database
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT TOP 1 StudentID FROM Students ORDER BY StudentID";
                        
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            object result = command.ExecuteScalar();
                            if (result != null)
                            {
                                studentId = Convert.ToInt32(result);
                            }
                            else
                            {
                                MessageBox.Show("Could not find a student profile. Please create a profile first.",
                                    "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        
                        // Check if already registered
                        string checkQuery = @"
                            SELECT COUNT(*) 
                            FROM BoothVisits 
                            WHERE StudentID = @StudentID 
                            AND JobFairID = @JobFairID";
                        
                        using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@StudentID", studentId);
                            checkCommand.Parameters.AddWithValue("@JobFairID", fairId);
                            
                            int count = (int)checkCommand.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("You are already registered for this job fair.",
                                    "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                return;
                            }
                        }
                        
                        // Register for the job fair
                        string registerQuery = @"
                            INSERT INTO BoothVisits (StudentID, CompanyID, JobFairID, CheckInTime)
                            VALUES (@StudentID, NULL, @JobFairID, NULL)";
                        
                        using (SqlCommand registerCommand = new SqlCommand(registerQuery, connection))
                        {
                            registerCommand.Parameters.AddWithValue("@StudentID", studentId);
                            registerCommand.Parameters.AddWithValue("@JobFairID", fairId);
                            
                            registerCommand.ExecuteNonQuery();
                            
                MessageBox.Show("You have successfully registered for the job fair!", 
                    "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error registering for job fair: " + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 