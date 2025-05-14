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
    public partial class RecruiterDashboard : Form
    {
        private int userId;
        private int recruiterId;
        private int companyId;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";

        public RecruiterDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            
            // Get recruiter and company IDs
            GetRecruiterInfo();
            
            // Load real data from database
            LoadData();
        }
        
        private void GetRecruiterInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // First check if the recruiter exists
                    string checkQuery = @"
                        SELECT 
                            r.RecruiterID,
                            r.CompanyID,
                            c.CompanyName
                        FROM Recruiters r
                        JOIN Companies c ON r.CompanyID = c.CompanyID
                        WHERE r.UserID = @UserID";
                    
                    using (SqlCommand command = new SqlCommand(checkQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                recruiterId = Convert.ToInt32(reader["RecruiterID"]);
                                companyId = Convert.ToInt32(reader["CompanyID"]);
                                string companyName = reader["CompanyName"].ToString();
                                lblWelcome.Text = $"Welcome, {companyName} Recruiter";
                            }
                            else
                            {
                                // Close the reader before executing other commands
                                reader.Close();
                                
                                // Recruiter not found, check if any company exists
                                string companyQuery = "SELECT TOP 1 CompanyID, CompanyName FROM Companies";
                                using (SqlCommand companyCommand = new SqlCommand(companyQuery, connection))
                                {
                                    using (SqlDataReader companyReader = companyCommand.ExecuteReader())
                                    {
                                        if (companyReader.Read())
                                        {
                                            companyId = Convert.ToInt32(companyReader["CompanyID"]);
                                            string companyName = companyReader["CompanyName"].ToString();
                                            companyReader.Close();
                                            
                                            // Create a recruiter record
                                            string createQuery = @"
                                                INSERT INTO Recruiters (RecruiterID, UserID, CompanyID)
                                                VALUES (@UserID, @UserID, @CompanyID);
                                                SELECT SCOPE_IDENTITY();";
                                                
                                            using (SqlCommand createCommand = new SqlCommand(createQuery, connection))
                                            {
                                                createCommand.Parameters.AddWithValue("@UserID", userId);
                                                createCommand.Parameters.AddWithValue("@CompanyID", companyId);
                                                
                                                object result = createCommand.ExecuteScalar();
                                                if (result != null)
                                                {
                                                    recruiterId = Convert.ToInt32(result);
                                                    lblWelcome.Text = $"Welcome, {companyName} Recruiter";
                                                    
                                                    MessageBox.Show("A new recruiter profile has been created for you.",
                                                        "Profile Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Failed to create recruiter profile.",
                                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    this.Close();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("No companies found in the system. Please add a company first.",
                                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            this.Close();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving recruiter information: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            LoadApplications();
            LoadInterviews();
            LoadJobPostings();
            LoadJobFairs();
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
                            u.FullName AS StudentName,
                            s.FAST_ID,
                            jp.JobTitle,
                            CONVERT(VARCHAR(10), a.ApplicationDate, 101) AS ApplicationDateFormatted,
                            a.ApplicationStatus
                        FROM Applications a
                        JOIN Students s ON a.StudentID = s.StudentID
                        JOIN Users u ON s.UserID = u.UserID
                        JOIN JobPostings jp ON a.JobID = jp.JobID
                        WHERE jp.CompanyID = @CompanyID
                        ORDER BY a.ApplicationDate DESC";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CompanyID", companyId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvApplications.Rows.Add(
                                    reader["ApplicationID"].ToString(),
                                    reader["StudentName"].ToString(),
                                    reader["FAST_ID"].ToString(),
                                    reader["JobTitle"].ToString(),
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
                            u.FullName AS StudentName,
                            jp.JobTitle,
                            CONVERT(VARCHAR(10), i.InterviewDate, 101) AS InterviewDateFormatted,
                            CONVERT(VARCHAR(10), i.StartTime, 108) AS StartTimeFormatted,
                            'Online' AS Location,
                            CASE 
                                WHEN i.InterviewResult IS NULL THEN 'Scheduled'
                                ELSE i.InterviewResult 
                            END AS Status
                        FROM Interviews i
                        JOIN Applications a ON i.ApplicationID = a.ApplicationID
                        JOIN Students s ON a.StudentID = s.StudentID
                        JOIN Users u ON s.UserID = u.UserID
                        JOIN JobPostings jp ON a.JobID = jp.JobID
                        WHERE jp.CompanyID = @CompanyID
                        ORDER BY i.InterviewDate, i.StartTime";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CompanyID", companyId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvInterviews.Rows.Add(
                                    reader["InterviewID"].ToString(),
                                    reader["StudentName"].ToString(),
                                    reader["JobTitle"].ToString(),
                                    reader["InterviewDateFormatted"].ToString(),
                                    reader["StartTimeFormatted"].ToString(),
                                    reader["Location"].ToString(),
                                    reader["Status"].ToString()
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

        private void LoadJobPostings()
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
                            jp.JobType,
                            (SELECT COUNT(*) FROM Applications a WHERE a.JobID = jp.JobID) AS ApplicationCount,
                            'Active' AS Status
                        FROM JobPostings jp
                        WHERE jp.CompanyID = @CompanyID
                        ORDER BY jp.JobID DESC";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CompanyID", companyId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvJobs.Rows.Add(
                                    reader["JobID"].ToString(),
                                    reader["JobTitle"].ToString(),
                                    reader["JobType"].ToString(),
                                    reader["ApplicationCount"].ToString(),
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
                            CASE 
                                WHEN EXISTS (
                                    SELECT 1 FROM BoothVisits bv 
                                    WHERE bv.JobFairID = jf.JobFairID 
                                    AND bv.CompanyID = @CompanyID
                                ) THEN 'Registered'
                                ELSE 'Not Registered'
                            END AS RegisterStatus,
                            (SELECT COUNT(DISTINCT StudentID) 
                             FROM BoothVisits 
                             WHERE JobFairID = jf.JobFairID 
                             AND CompanyID = @CompanyID) AS VisitorCount
                        FROM JobFairEvents jf
                        ORDER BY jf.EventDate DESC";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CompanyID", companyId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string visitorCount = reader["VisitorCount"].ToString();
                                if (reader["RegisterStatus"].ToString() == "Not Registered")
                                {
                                    visitorCount = "-";
                                }
                                
                                dgvJobFairs.Rows.Add(
                                    reader["JobFairID"].ToString(),
                                    reader["EventTitle"].ToString(),
                                    reader["EventDateFormatted"].ToString(),
                                    reader["Venue"].ToString(),
                                    reader["RegisterStatus"].ToString(),
                                    visitorCount
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

        private void btnViewApplicantProfile_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count > 0)
            {
                string studentName = dgvApplications.SelectedRows[0].Cells[1].Value.ToString();
                string fastId = dgvApplications.SelectedRows[0].Cells[2].Value.ToString();
                
                // Open student profile viewer
                ApplicantProfileForm profileForm = new ApplicantProfileForm(studentName, fastId);
                profileForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an application first.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count > 0)
            {
                string applicationId = dgvApplications.SelectedRows[0].Cells[0].Value.ToString();
                string currentStatus = dgvApplications.SelectedRows[0].Cells[5].Value.ToString();
                
                // Create a simple input dialog
                using (var form = new Form())
                {
                    form.Text = "Update Application Status";
                    form.Size = new Size(300, 200);
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.FormBorderStyle = FormBorderStyle.FixedDialog;
                    form.MaximizeBox = false;
                    form.MinimizeBox = false;

                    var label = new Label() { Text = "Select new status:", Left = 20, Top = 20, Width = 240 };
                    var comboBox = new ComboBox() { 
                        Left = 20, 
                        Top = 50, 
                        Width = 240, 
                        DropDownStyle = ComboBoxStyle.DropDownList 
                    };
                    comboBox.Items.AddRange(new string[] { "Pending", "Shortlisted", "Rejected", "Offered", "Accepted" });
                    comboBox.SelectedItem = currentStatus;

                    var buttonOk = new Button() { 
                        Text = "Update", 
                        Left = 20, 
                        Top = 90, 
                        Width = 100, 
                        DialogResult = DialogResult.OK 
                    };
                    var buttonCancel = new Button() { 
                        Text = "Cancel", 
                        Left = 130, 
                        Top = 90, 
                        Width = 100, 
                        DialogResult = DialogResult.Cancel 
                    };

                    form.Controls.Add(label);
                    form.Controls.Add(comboBox);
                    form.Controls.Add(buttonOk);
                    form.Controls.Add(buttonCancel);

                    form.AcceptButton = buttonOk;
                    form.CancelButton = buttonCancel;

                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                string updateQuery = @"
                                    UPDATE Applications
                                    SET ApplicationStatus = @ApplicationStatus
                                    WHERE ApplicationID = @ApplicationID";
                                
                                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ApplicationStatus", comboBox.SelectedItem.ToString());
                                    command.Parameters.AddWithValue("@ApplicationID", applicationId);
                                    
                                    command.ExecuteNonQuery();
                                    
                                    // Update the status in the grid
                                    dgvApplications.SelectedRows[0].Cells[5].Value = comboBox.SelectedItem.ToString();
                                    
                                    MessageBox.Show($"Application status updated to {comboBox.SelectedItem}.", 
                                        "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating application status: " + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an application first.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnScheduleInterview_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count > 0)
            {
                string applicationId = dgvApplications.SelectedRows[0].Cells[0].Value.ToString();
                string studentName = dgvApplications.SelectedRows[0].Cells[1].Value.ToString();
                string jobTitle = dgvApplications.SelectedRows[0].Cells[3].Value.ToString();
                
                // Open interview scheduling form
                ScheduleInterviewForm scheduleForm = new ScheduleInterviewForm(applicationId, studentName, jobTitle);
                if (scheduleForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the interviews list
                    LoadInterviews();
                }
            }
            else
            {
                MessageBox.Show("Please select an application first.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewJobDetails_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count > 0)
            {
                string jobId = dgvJobs.SelectedRows[0].Cells[0].Value.ToString();
                string jobTitle = dgvJobs.SelectedRows[0].Cells[1].Value.ToString();
                
                // Open job details form (recruiter view)
                RecruiterJobDetailsForm detailsForm = new RecruiterJobDetailsForm(jobId, jobTitle);
                detailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a job posting first.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPostNewJob_Click(object sender, EventArgs e)
        {
            // Open job posting form
            JobPostingForm postingForm = new JobPostingForm(companyId);
            if (postingForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh the job postings list
                LoadJobPostings();
                MessageBox.Show("Job posted successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegisterForFair_Click(object sender, EventArgs e)
        {
            if (dgvJobFairs.SelectedRows.Count > 0)
            {
                string fairId = dgvJobFairs.SelectedRows[0].Cells[0].Value.ToString();
                string fairName = dgvJobFairs.SelectedRows[0].Cells[1].Value.ToString();
                string status = dgvJobFairs.SelectedRows[0].Cells[4].Value.ToString();
                
                if (status == "Registered")
                {
                    MessageBox.Show("You are already registered for this job fair.", 
                        "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                // Open job fair registration form
                JobFairRegistrationForm registrationForm = new JobFairRegistrationForm(fairId, fairName, companyId);
                if (registrationForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the job fairs list
                    LoadJobFairs();
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
                
                // Open job fair details form
                JobFairDetailsForm detailsForm = new JobFairDetailsForm(fairId, fairName);
                detailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a job fair first.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Refresh data based on the selected tab
            switch (tabControl1.SelectedIndex)
            {
                case 0: // Applications tab
                    LoadApplications();
                    break;
                case 1: // Interviews tab
                    LoadInterviews();
                    break;
                case 2: // Jobs tab
                    LoadJobPostings();
                    break;
                case 3: // Job Fairs tab
                    LoadJobFairs();
                    break;
            }
        }
    }
} 