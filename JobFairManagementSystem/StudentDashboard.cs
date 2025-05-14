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
    public partial class StudentDashboard : Form
    {
        private int userId;
        private int studentId;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";
        
        public StudentDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            
            // Get the student ID associated with this user
            GetStudentId();
            
            // Load real data from database
            LoadData();
        }
        
        private void GetStudentId()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT StudentID FROM Students WHERE UserID = @UserID
                        
                        -- If no record exists, create a student record for this user
                        IF @@ROWCOUNT = 0
                        BEGIN
                            INSERT INTO Students (UserID, FAST_ID, DegreeProgram, CurrentSemester, GPA)
                            SELECT @UserID, 
                                   CONCAT('23K-', RIGHT('0000' + CAST(@UserID AS VARCHAR(4)), 4)),
                                   'CS', 
                                   1, 
                                   3.0
                            
                            SELECT SCOPE_IDENTITY() AS StudentID
                        END";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        object result = command.ExecuteScalar();
                        
                        if (result != null)
                        {
                            studentId = Convert.ToInt32(result);
                        }
                        else
                        {
                            // Fallback - create a student record
                            string insertQuery = @"
                                INSERT INTO Students (UserID, FAST_ID, DegreeProgram, CurrentSemester, GPA)
                                VALUES (@UserID, @FAST_ID, 'CS', 1, 3.0);
                                SELECT SCOPE_IDENTITY();";
                            
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@UserID", userId);
                                insertCommand.Parameters.AddWithValue("@FAST_ID", $"23K-{userId:D4}");
                                
                                result = insertCommand.ExecuteScalar();
                                if (result != null)
                                {
                                    studentId = Convert.ToInt32(result);
                                    MessageBox.Show("A new student profile has been created for you.",
                                        "Profile Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Student profile not found and could not be created. Please contact the administrator.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving student information: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            LoadJobFairs();
            LoadJobs();
            LoadApplications();
            LoadInterviews();
        }

        private void LoadJobFairs()
        {
            try
            {
                dgvJobFairs.Rows.Clear();
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            jf.JobFairID,
                            jf.EventTitle,
                            CONVERT(VARCHAR(10), jf.EventDate, 101) AS EventDateFormatted,
                            jf.Venue,
                            CONCAT(CONVERT(VARCHAR(10), jf.StartTime, 108), ' - ', CONVERT(VARCHAR(10), jf.EndTime, 108)) AS TimeRange
                        FROM JobFairEvents jf
                        WHERE jf.EventDate >= GETDATE()
                        ORDER BY jf.EventDate";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvJobFairs.Rows.Add(
                                    reader["JobFairID"].ToString(),
                                    reader["EventTitle"].ToString(),
                                    reader["EventDateFormatted"].ToString(),
                                    reader["Venue"].ToString(),
                                    reader["TimeRange"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading job fairs: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadJobs()
        {
            try
            {
                dgvJobs.Rows.Clear();
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            jp.JobID,
                            jp.JobTitle,
                            c.CompanyName,
                            jp.JobType,
                            'New Applications Open' AS Status
                        FROM JobPostings jp
                        JOIN Companies c ON jp.CompanyID = c.CompanyID
                        LEFT JOIN Applications a ON jp.JobID = a.JobID AND a.StudentID = @StudentID
                        WHERE a.ApplicationID IS NULL
                        ORDER BY jp.JobID DESC";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvJobs.Rows.Add(
                                    reader["JobID"].ToString(),
                                    reader["JobTitle"].ToString(),
                                    reader["CompanyName"].ToString(),
                                    reader["JobType"].ToString(),
                                    reader["Status"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading job postings: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadApplications()
        {
            try
            {
                dgvApplications.Rows.Clear();
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            a.ApplicationID,
                            jp.JobTitle,
                            c.CompanyName,
                            CONVERT(VARCHAR(10), a.ApplicationDate, 101) AS ApplicationDateFormatted,
                            a.ApplicationStatus
                        FROM Applications a
                        JOIN JobPostings jp ON a.JobID = jp.JobID
                        JOIN Companies c ON jp.CompanyID = c.CompanyID
                        WHERE a.StudentID = @StudentID
                        ORDER BY a.ApplicationID DESC";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvApplications.Rows.Add(
                                    reader["ApplicationID"].ToString(),
                                    reader["JobTitle"].ToString(),
                                    reader["CompanyName"].ToString(),
                                    reader["ApplicationDateFormatted"].ToString(),
                                    reader["ApplicationStatus"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applications: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInterviews()
        {
            try
            {
                dgvInterviews.Rows.Clear();
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            i.InterviewID,
                            c.CompanyName,
                            jp.JobTitle,
                            CONVERT(VARCHAR(10), i.InterviewDate, 101) AS InterviewDateFormatted,
                            CONVERT(VARCHAR(10), i.StartTime, 108) AS StartTimeFormatted,
                            'Online' AS Location
                        FROM Interviews i
                        JOIN Applications a ON i.ApplicationID = a.ApplicationID
                        JOIN JobPostings jp ON a.JobID = jp.JobID
                        JOIN Companies c ON jp.CompanyID = c.CompanyID
                        WHERE a.StudentID = @StudentID
                        AND i.InterviewDate >= GETDATE()
                        ORDER BY i.InterviewDate, i.StartTime";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvInterviews.Rows.Add(
                                    reader["InterviewID"].ToString(),
                                    reader["CompanyName"].ToString(),
                                    reader["JobTitle"].ToString(),
                                    reader["InterviewDateFormatted"].ToString(),
                                    reader["StartTimeFormatted"].ToString(),
                                    reader["Location"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading interviews: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Refresh data based on the selected tab
            switch (tabControl1.SelectedIndex)
            {
                case 0: // Job Fairs tab
                    LoadJobFairs();
                    break;
                case 1: // Jobs tab
                    LoadJobs();
                    break;
                case 2: // Applications tab
                    LoadApplications();
                    break;
                case 3: // Interviews tab
                    LoadInterviews();
                    break;
            }
        }

        private void btnViewJobDetails_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count > 0)
            {
                // Get the selected job details
                string jobId = dgvJobs.SelectedRows[0].Cells[0].Value.ToString();
                string jobTitle = dgvJobs.SelectedRows[0].Cells[1].Value.ToString();
                string company = dgvJobs.SelectedRows[0].Cells[2].Value.ToString();
                
                // Show job details in a new form
                JobDetailsForm jobDetailsForm = new JobDetailsForm(jobId, jobTitle, company);
                jobDetailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a job first.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnApplyForJob_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count > 0)
            {
                // Get the selected job details
                string jobId = dgvJobs.SelectedRows[0].Cells[0].Value.ToString();
                string jobTitle = dgvJobs.SelectedRows[0].Cells[1].Value.ToString();
                string company = dgvJobs.SelectedRows[0].Cells[2].Value.ToString();
                
                // Open the application form
                JobApplicationForm applicationForm = new JobApplicationForm(jobId, jobTitle, company, studentId);
                if (applicationForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the applications tab
                    LoadApplications();
                    // Also refresh the jobs tab since the job shouldn't appear anymore
                    LoadJobs();
                }
            }
            else
            {
                MessageBox.Show("Please select a job first.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegisterForFair_Click(object sender, EventArgs e)
        {
            if (dgvJobFairs.SelectedRows.Count > 0)
            {
                string fairId = dgvJobFairs.SelectedRows[0].Cells[0].Value.ToString();
                string fairName = dgvJobFairs.SelectedRows[0].Cells[1].Value.ToString();
                
                // Confirm registration
                if (MessageBox.Show($"Do you want to register for the {fairName}?", 
                    "Confirm Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            
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
                                
                                int registrationCount = (int)checkCommand.ExecuteScalar();
                                
                                if (registrationCount > 0)
                                {
                                    MessageBox.Show("You are already registered for this job fair.",
                                        "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                            
                            // Register the student
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
            else
            {
                MessageBox.Show("Please select a job fair first.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewFairDetails_Click(object sender, EventArgs e)
        {
            if (dgvJobFairs.SelectedRows.Count > 0)
            {
                string fairId = dgvJobFairs.SelectedRows[0].Cells[0].Value.ToString();
                string fairName = dgvJobFairs.SelectedRows[0].Cells[1].Value.ToString();
                
                // Show fair details
                JobFairDetailsForm fairDetailsForm = new JobFairDetailsForm(fairId, fairName);
                fairDetailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a job fair first.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            StudentInfoForm infoForm = new StudentInfoForm(studentId);
            infoForm.ShowDialog();
        }

        private void btnManageSkills_Click(object sender, EventArgs e)
        {
            StudentSkillsForm skillsForm = new StudentSkillsForm(studentId);
            skillsForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Data refreshed successfully!", "Refresh", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
} 