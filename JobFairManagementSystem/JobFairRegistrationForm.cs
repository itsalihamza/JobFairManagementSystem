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
    public partial class JobFairRegistrationForm : Form
    {
        private string fairId;
        private string fairName;
        private int companyId;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";

        public JobFairRegistrationForm(string fairId, string fairName, int companyId)
        {
            InitializeComponent();
            
            this.fairId = fairId;
            this.fairName = fairName;
            this.companyId = companyId;
            
            // Set fair name in title
            lblFairNameValue.Text = fairName;
            
            // Load fair details and company info
            LoadFairDetails();
            LoadCompanyInfo();
        }
        
        private void LoadCompanyInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT CompanyName FROM Companies WHERE CompanyID = @CompanyID";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CompanyID", companyId);
                        object result = command.ExecuteScalar();
                        
                        if (result != null)
                        {
                            // Set company name somewhere in the form if needed
                            this.Text = $"{result.ToString()} - {fairName} Registration";
                        }
                        else
                        {
                            MessageBox.Show("Company information not found.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading company information: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFairDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            EventTitle,
                            CONVERT(VARCHAR(10), EventDate, 101) AS EventDateFormatted,
                            Venue,
                            CONVERT(VARCHAR(10), StartTime, 108) AS StartTimeFormatted,
                            CONVERT(VARCHAR(10), EndTime, 108) AS EndTimeFormatted
                        FROM JobFairEvents
                        WHERE JobFairID = @JobFairID";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JobFairID", fairId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblDateValue.Text = reader["EventDateFormatted"].ToString();
                                lblVenueValue.Text = reader["Venue"].ToString();
                                lblTimeValue.Text = $"{reader["StartTimeFormatted"]} - {reader["EndTimeFormatted"]}";
                                
                                // The rest of the information could be either hard-coded or also in the database
                                lblRegistrationFeeValue.Text = "$500"; // Example
                                
                                txtDescription.Text = $"The {reader["EventTitle"]} at {reader["Venue"]} is an excellent opportunity " +
                                    "for companies to connect with top talent in the IT industry. Students from CS, SE, AI, and DS " +
                                    "programs will be attending. Each participating company will be provided with a booth, " +
                                    "basic furniture, and Wi-Fi access.";
                            }
                            else
                            {
                                MessageBox.Show("Job fair details not found.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                    
                    // Check if already registered
                    string checkQuery = @"
                        SELECT COUNT(*) 
                        FROM BoothVisits 
                        WHERE CompanyID = @CompanyID 
                        AND JobFairID = @JobFairID";
                    
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@CompanyID", companyId);
                        checkCommand.Parameters.AddWithValue("@JobFairID", fairId);
                        
                        int count = (int)checkCommand.ExecuteScalar();
                        
                        if (count > 0)
                        {
                            MessageBox.Show("Your company is already registered for this job fair.",
                                "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            // Disable registration
                            btnRegister.Enabled = false;
                            chkAgreeTerms.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading job fair details: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validate form input
            if (string.IsNullOrEmpty(txtCompanyReps.Text.Trim()))
            {
                MessageBox.Show("Please enter the names of company representatives.", 
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompanyReps.Focus();
                return;
            }

            if (!chkSoftwareEngineer.Checked && !chkWebDeveloper.Checked && 
                !chkDataScientist.Checked && !chkAIEngineer.Checked && 
                !chkUIUXDesigner.Checked && !chkNetworkEngineer.Checked && 
                string.IsNullOrEmpty(txtOtherPositions.Text.Trim()))
            {
                MessageBox.Show("Please select at least one job position or specify other positions.", 
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkAgreeTerms.Checked)
            {
                MessageBox.Show("You must agree to the terms and conditions to proceed.", 
                    "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Register for the job fair
                    string insertQuery = @"
                        INSERT INTO BoothVisits (
                            StudentID,
                            CompanyID,
                            JobFairID,
                            CheckInTime
                        )
                        VALUES (
                            NULL,
                            @CompanyID,
                            @JobFairID,
                            NULL
                        )";
                    
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@CompanyID", companyId);
                        insertCommand.Parameters.AddWithValue("@JobFairID", fairId);
                        
                        insertCommand.ExecuteNonQuery();
                        
                        MessageBox.Show($"Your company has been successfully registered for the {fairName}.\n\n" +
                            "A confirmation email with additional details will be sent shortly.",
                            "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.DialogResult = DialogResult.OK;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
} 