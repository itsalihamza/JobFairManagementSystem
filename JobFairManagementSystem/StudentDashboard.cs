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
            
            // Initialize filter controls
            SetupJobFilters();
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
            LoadCompletedInterviews();
        }

        private void SetupJobFilters()
        {
            // Set up job type filter combo box
            cmbJobType.Items.Clear();
            cmbJobType.Items.Add("All Types");
            cmbJobType.Items.Add("Internship");
            cmbJobType.Items.Add("Full-time");
            cmbJobType.SelectedIndex = 0;
            
            // Set up salary range filter combo box
            cmbSalaryRange.Items.Clear();
            cmbSalaryRange.Items.Add("All Ranges");
            cmbSalaryRange.Items.Add("Below 50k");
            cmbSalaryRange.Items.Add("50k-100k");
            cmbSalaryRange.Items.Add("100k-150k");
            cmbSalaryRange.Items.Add("Above 150k");
            cmbSalaryRange.SelectedIndex = 0;
            
            // Load all available skills for filter
            LoadSkillsFilter();
            
            // Set up location filter combo box
            cmbLocation.Items.Clear();
            cmbLocation.Items.Add("All Locations");
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT Location FROM Companies ORDER BY Location";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbLocation.Items.Add(reader["Location"].ToString());
                            }
                        }
                    }
                }
                
                cmbLocation.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading locations: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadSkillsFilter()
        {
            checkedListSkills.Items.Clear();
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT SkillName FROM Skills ORDER BY SkillName";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                checkedListSkills.Items.Add(reader["SkillName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading skills: " + ex.Message,
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
                    
                    // Base query with filters
                    string query = @"
                        SELECT 
                            jp.JobID,
                            jp.JobTitle,
                            c.CompanyName,
                            jp.JobType,
                            jp.SalaryRange,
                            c.Location,
                            jp.RequiredSkills,
                            'New Applications Open' AS Status
                        FROM JobPostings jp
                        JOIN Companies c ON jp.CompanyID = c.CompanyID
                        LEFT JOIN Applications a ON jp.JobID = a.JobID AND a.StudentID = @StudentID
                        WHERE a.ApplicationID IS NULL";
                    
                    // Apply filters
                    if (cmbJobType.SelectedIndex > 0)
                    {
                        query += " AND jp.JobType = @JobType";
                    }
                    
                    if (cmbSalaryRange.SelectedIndex > 0)
                    {
                        query += " AND jp.SalaryRange LIKE @SalaryRange";
                    }
                    
                    if (cmbLocation.SelectedIndex > 0)
                    {
                        query += " AND c.Location = @Location";
                    }
                    
                    // If a search term is provided
                    if (!string.IsNullOrWhiteSpace(txtSearchJobs.Text))
                    {
                        query += @" AND (
                            jp.JobTitle LIKE @SearchTerm OR 
                            c.CompanyName LIKE @SearchTerm OR 
                            jp.RequiredSkills LIKE @SearchTerm
                        )";
                    }
                    
                    // Add skills filter if any skills are selected
                    List<string> selectedSkills = new List<string>();
                    for (int i = 0; i < checkedListSkills.Items.Count; i++)
                    {
                        if (checkedListSkills.GetItemChecked(i))
                        {
                            selectedSkills.Add(checkedListSkills.Items[i].ToString());
                        }
                    }
                    
                    if (selectedSkills.Count > 0)
                    {
                        // Add conditions for each selected skill
                        foreach (string skill in selectedSkills)
                        {
                            query += $" AND jp.RequiredSkills LIKE @Skill{selectedSkills.IndexOf(skill)}";
                        }
                    }
                    
                    query += " ORDER BY jp.JobID DESC";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentId);
                        
                        if (cmbJobType.SelectedIndex > 0)
                        {
                            command.Parameters.AddWithValue("@JobType", cmbJobType.SelectedItem.ToString());
                        }
                        
                        if (cmbSalaryRange.SelectedIndex > 0)
                        {
                            string salaryPattern = "";
                            switch (cmbSalaryRange.SelectedIndex)
                            {
                                case 1: // Below 50k
                                    salaryPattern = "%0k%50k%";
                                    break;
                                case 2: // 50k-100k
                                    salaryPattern = "%50k%100k%";
                                    break;
                                case 3: // 100k-150k
                                    salaryPattern = "%100k%150k%";
                                    break;
                                case 4: // Above 150k
                                    salaryPattern = "%150k%";
                                    break;
                            }
                            command.Parameters.AddWithValue("@SalaryRange", salaryPattern);
                        }
                        
                        if (cmbLocation.SelectedIndex > 0)
                        {
                            command.Parameters.AddWithValue("@Location", cmbLocation.SelectedItem.ToString());
                        }
                        
                        if (!string.IsNullOrWhiteSpace(txtSearchJobs.Text))
                        {
                            command.Parameters.AddWithValue("@SearchTerm", "%" + txtSearchJobs.Text + "%");
                        }
                        
                        // Add parameters for each selected skill
                        for (int i = 0; i < selectedSkills.Count; i++)
                        {
                            command.Parameters.AddWithValue($"@Skill{i}", "%" + selectedSkills[i] + "%");
                        }
                        
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
                
                lblJobCount.Text = $"Found {dgvJobs.Rows.Count} job(s)";
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
                            a.ApplicationStatus,
                            jp.JobID,
                            (SELECT COUNT(*) FROM Interviews i WHERE i.ApplicationID = a.ApplicationID) AS HasInterview
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
                                int hasInterview = Convert.ToInt32(reader["HasInterview"]);
                                bool canSchedule = reader["ApplicationStatus"].ToString() == "Pending" && hasInterview == 0;
                                
                                dgvApplications.Rows.Add(
                                    reader["ApplicationID"].ToString(),
                                    reader["JobTitle"].ToString(),
                                    reader["CompanyName"].ToString(),
                                    reader["ApplicationDateFormatted"].ToString(),
                                    reader["ApplicationStatus"].ToString(),
                                    canSchedule ? "Schedule Interview" : "",
                                    reader["JobID"].ToString()
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
        
        private void LoadCompletedInterviews()
        {
            try
            {
                dgvPastInterviews.Rows.Clear();
                
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
                            r.RecruiterID,
                            CASE 
                                WHEN rv.ReviewID IS NULL THEN 'Not Rated' 
                                ELSE 'Rated: ' + CAST(rv.Rating AS VARCHAR(1)) + '/5'
                            END AS ReviewStatus
                        FROM Interviews i
                        JOIN Applications a ON i.ApplicationID = a.ApplicationID
                        JOIN JobPostings jp ON a.JobID = jp.JobID
                        JOIN Companies c ON jp.CompanyID = c.CompanyID
                        JOIN Recruiters r ON r.CompanyID = c.CompanyID
                        LEFT JOIN Reviews rv ON rv.InterviewID = i.InterviewID AND rv.StudentID = a.StudentID
                        WHERE a.StudentID = @StudentID
                        AND i.InterviewDate < GETDATE()
                        ORDER BY i.InterviewDate DESC, i.StartTime";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvPastInterviews.Rows.Add(
                                    reader["InterviewID"].ToString(),
                                    reader["CompanyName"].ToString(),
                                    reader["JobTitle"].ToString(),
                                    reader["InterviewDateFormatted"].ToString(),
                                    reader["StartTimeFormatted"].ToString(),
                                    reader["RecruiterID"].ToString(),
                                    reader["ReviewStatus"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading past interviews: " + ex.Message,
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
                case 4: // Past Interviews tab
                    LoadCompletedInterviews();
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
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadJobs();
        }
        
        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtSearchJobs.Clear();
            cmbJobType.SelectedIndex = 0;
            cmbSalaryRange.SelectedIndex = 0;
            cmbLocation.SelectedIndex = 0;
            
            // Uncheck all skills
            for (int i = 0; i < checkedListSkills.Items.Count; i++)
            {
                checkedListSkills.SetItemChecked(i, false);
            }
            
            LoadJobs();
        }
        
        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            if (dgvPastInterviews.SelectedRows.Count > 0)
            {
                // Get the selected interview details
                string interviewId = dgvPastInterviews.SelectedRows[0].Cells[0].Value.ToString();
                string companyName = dgvPastInterviews.SelectedRows[0].Cells[1].Value.ToString();
                string jobTitle = dgvPastInterviews.SelectedRows[0].Cells[2].Value.ToString();
                string recruiterId = dgvPastInterviews.SelectedRows[0].Cells[5].Value.ToString();
                string reviewStatus = dgvPastInterviews.SelectedRows[0].Cells[6].Value.ToString();
                
                // Check if already rated
                if (reviewStatus.StartsWith("Rated"))
                {
                    MessageBox.Show("You have already submitted a review for this interview.",
                        "Already Reviewed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                // Create a form for the review
                Form reviewForm = new Form();
                reviewForm.Text = $"Review Interview - {companyName}";
                reviewForm.Size = new Size(400, 350);
                reviewForm.StartPosition = FormStartPosition.CenterParent;
                reviewForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                reviewForm.MaximizeBox = false;
                reviewForm.MinimizeBox = false;
                
                // Create controls
                Label lblTitle = new Label();
                lblTitle.Text = $"{jobTitle} - {companyName}";
                lblTitle.Font = new Font(lblTitle.Font, FontStyle.Bold);
                lblTitle.AutoSize = true;
                lblTitle.Location = new Point(20, 20);
                
                Label lblRating = new Label();
                lblRating.Text = "Rating (1-5):";
                lblRating.Location = new Point(20, 60);
                lblRating.AutoSize = true;
                
                ComboBox cmbRating = new ComboBox();
                cmbRating.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbRating.Items.AddRange(new object[] { "1 (Poor)", "2 (Fair)", "3 (Average)", "4 (Good)", "5 (Excellent)" });
                cmbRating.Location = new Point(120, 60);
                cmbRating.SelectedIndex = 3; // Default to 4 (Good)
                
                Label lblComments = new Label();
                lblComments.Text = "Comments:";
                lblComments.Location = new Point(20, 100);
                lblComments.AutoSize = true;
                
                TextBox txtComments = new TextBox();
                txtComments.Multiline = true;
                txtComments.Location = new Point(20, 130);
                txtComments.Size = new Size(340, 120);
                
                Button btnSubmit = new Button();
                btnSubmit.Text = "Submit Review";
                btnSubmit.Location = new Point(260, 270);
                btnSubmit.DialogResult = DialogResult.OK;
                
                Button btnCancel = new Button();
                btnCancel.Text = "Cancel";
                btnCancel.Location = new Point(150, 270);
                btnCancel.DialogResult = DialogResult.Cancel;
                
                // Add controls to form
                reviewForm.Controls.Add(lblTitle);
                reviewForm.Controls.Add(lblRating);
                reviewForm.Controls.Add(cmbRating);
                reviewForm.Controls.Add(lblComments);
                reviewForm.Controls.Add(txtComments);
                reviewForm.Controls.Add(btnSubmit);
                reviewForm.Controls.Add(btnCancel);
                
                if (reviewForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Extract the numeric rating
                        int rating = cmbRating.SelectedIndex + 1;
                        string comments = txtComments.Text.Trim();
                        
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            
                            // Check if review already exists
                            string checkQuery = @"
                                SELECT COUNT(*) 
                                FROM Reviews 
                                WHERE StudentID = @StudentID 
                                AND InterviewID = @InterviewID";
                            
                            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                            {
                                checkCommand.Parameters.AddWithValue("@StudentID", studentId);
                                checkCommand.Parameters.AddWithValue("@InterviewID", interviewId);
                                
                                int reviewCount = (int)checkCommand.ExecuteScalar();
                                
                                string query;
                                if (reviewCount > 0)
                                {
                                    // Update existing review
                                    query = @"
                                        UPDATE Reviews 
                                        SET Rating = @Rating, Comments = @Comments 
                                        WHERE StudentID = @StudentID 
                                        AND InterviewID = @InterviewID";
                                }
                                else
                                {
                                    // Insert new review
                                    query = @"
                                        INSERT INTO Reviews (StudentID, RecruiterID, InterviewID, Rating, Comments)
                                        VALUES (@StudentID, @RecruiterID, @InterviewID, @Rating, @Comments)";
                                }
                                
                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@StudentID", studentId);
                                    command.Parameters.AddWithValue("@RecruiterID", recruiterId);
                                    command.Parameters.AddWithValue("@InterviewID", interviewId);
                                    command.Parameters.AddWithValue("@Rating", rating);
                                    command.Parameters.AddWithValue("@Comments", comments);
                                    
                                    command.ExecuteNonQuery();
                                    
                                    MessageBox.Show("Thank you for your feedback! Your review has been submitted.",
                                        "Review Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
                                    // Refresh the list
                                    LoadCompletedInterviews();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error submitting review: " + ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an interview to review.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Schedule Interview" column
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                string buttonText = dgvApplications.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (buttonText == "Schedule Interview")
                {
                    int applicationId = int.Parse(dgvApplications.Rows[e.RowIndex].Cells[0].Value.ToString());
                    string jobTitle = dgvApplications.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string company = dgvApplications.Rows[e.RowIndex].Cells[2].Value.ToString();
                    
                    // Open the interview scheduling form
                    StudentInterviewSchedulingForm schedulingForm = new StudentInterviewSchedulingForm(
                        studentId, applicationId, jobTitle, company);
                    
                    if (schedulingForm.ShowDialog() == DialogResult.OK)
                    {
                        // Refresh the applications and interviews tabs
                        LoadApplications();
                        LoadInterviews();
                    }
                }
            }
        }
    }
} 