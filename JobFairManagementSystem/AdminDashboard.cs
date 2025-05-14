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
    public partial class AdminDashboard : Form
    {
        private int userId;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";
        
        public AdminDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            
            // Set welcome label
            lblWelcome.Text = "Welcome, Admin";
            
            // Load real data from the database
            LoadData();
        }

        private void LoadData()
        {
            LoadJobFairs();
            LoadCompanies();
            LoadStudents();
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
                            JobFairID, 
                            EventTitle, 
                            CONVERT(VARCHAR(10), EventDate, 101) AS EventDateFormatted, 
                            Venue,
                            CASE 
                                WHEN EventDate < GETDATE() THEN 'Past'
                                WHEN EventDate = GETDATE() THEN 'Active'
                                ELSE 'Upcoming'
                            END AS Status
                        FROM JobFairEvents
                        ORDER BY EventDate DESC";
                    
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
                                    reader["Status"].ToString()
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
        
        private void LoadCompanies()
        {
            try
            {
                dgvCompanies.Rows.Clear();
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            c.CompanyID, 
                            c.CompanyName, 
                            c.Sector,
                            (SELECT COUNT(*) FROM JobPostings WHERE CompanyID = c.CompanyID) AS JobCount,
                            CASE 
                                WHEN u.IsApproved = 1 THEN 'Approved' 
                                ELSE 'Pending' 
                            END AS Status
                        FROM Companies c
                        LEFT JOIN Recruiters r ON c.CompanyID = r.CompanyID
                        LEFT JOIN Users u ON r.UserID = u.UserID
                        ORDER BY c.CompanyName";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvCompanies.Rows.Add(
                                    reader["CompanyID"].ToString(),
                                    reader["CompanyName"].ToString(),
                                    reader["Sector"].ToString(),
                                    reader["JobCount"].ToString(),
                                    reader["Status"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading companies: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadStudents()
        {
            try
            {
                dgvStudents.Rows.Clear();
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            s.StudentID, 
                            u.FullName, 
                            s.FAST_ID, 
                            s.DegreeProgram, 
                            s.GPA,
                            CASE 
                                WHEN u.IsApproved = 1 THEN 'Verified' 
                                ELSE 'Pending' 
                            END AS Status
                        FROM Students s
                        JOIN Users u ON s.UserID = u.UserID
                        WHERE u.Role = 'Student'
                        ORDER BY u.FullName";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvStudents.Rows.Add(
                                    reader["StudentID"].ToString(),
                                    reader["FullName"].ToString(),
                                    reader["FAST_ID"].ToString(),
                                    reader["DegreeProgram"].ToString(),
                                    reader["GPA"].ToString(),
                                    reader["Status"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateFair_Click(object sender, EventArgs e)
        {
            // Create a form for adding a new job fair
            Form createFairForm = new Form();
            createFairForm.Text = "Create New Job Fair";
            createFairForm.Size = new Size(500, 400);
            createFairForm.StartPosition = FormStartPosition.CenterParent;
            createFairForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            createFairForm.MaximizeBox = false;
            createFairForm.MinimizeBox = false;
            
            // Create form controls
            Label lblTitle = new Label();
            lblTitle.Text = "Event Title:";
            lblTitle.Location = new Point(30, 30);
            lblTitle.AutoSize = true;
            
            TextBox txtTitle = new TextBox();
            txtTitle.Location = new Point(150, 30);
            txtTitle.Size = new Size(300, 25);
            
            Label lblDate = new Label();
            lblDate.Text = "Event Date:";
            lblDate.Location = new Point(30, 70);
            lblDate.AutoSize = true;
            
            DateTimePicker dtpDate = new DateTimePicker();
            dtpDate.Location = new Point(150, 70);
            dtpDate.Size = new Size(200, 25);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Value = DateTime.Now.AddDays(30); // Default to 30 days from now
            
            Label lblStartTime = new Label();
            lblStartTime.Text = "Start Time:";
            lblStartTime.Location = new Point(30, 110);
            lblStartTime.AutoSize = true;
            
            DateTimePicker dtpStartTime = new DateTimePicker();
            dtpStartTime.Location = new Point(150, 110);
            dtpStartTime.Size = new Size(120, 25);
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Value = DateTime.Parse("09:00 AM");
            
            Label lblEndTime = new Label();
            lblEndTime.Text = "End Time:";
            lblEndTime.Location = new Point(30, 150);
            lblEndTime.AutoSize = true;
            
            DateTimePicker dtpEndTime = new DateTimePicker();
            dtpEndTime.Location = new Point(150, 150);
            dtpEndTime.Size = new Size(120, 25);
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Value = DateTime.Parse("04:00 PM");
            
            Label lblVenue = new Label();
            lblVenue.Text = "Venue:";
            lblVenue.Location = new Point(30, 190);
            lblVenue.AutoSize = true;
            
            TextBox txtVenue = new TextBox();
            txtVenue.Location = new Point(150, 190);
            txtVenue.Size = new Size(300, 25);
            
            Label lblDescription = new Label();
            lblDescription.Text = "Description:";
            lblDescription.Location = new Point(30, 230);
            lblDescription.AutoSize = true;
            
            TextBox txtDescription = new TextBox();
            txtDescription.Location = new Point(150, 230);
            txtDescription.Size = new Size(300, 80);
            txtDescription.Multiline = true;
            
            Button btnSave = new Button();
            btnSave.Text = "Create Job Fair";
            btnSave.Location = new Point(300, 320);
            btnSave.Size = new Size(150, 30);
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.ForeColor = Color.White;
            
            Button btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(150, 320);
            btnCancel.Size = new Size(120, 30);
            
            // Add controls to form
            createFairForm.Controls.Add(lblTitle);
            createFairForm.Controls.Add(txtTitle);
            createFairForm.Controls.Add(lblDate);
            createFairForm.Controls.Add(dtpDate);
            createFairForm.Controls.Add(lblStartTime);
            createFairForm.Controls.Add(dtpStartTime);
            createFairForm.Controls.Add(lblEndTime);
            createFairForm.Controls.Add(dtpEndTime);
            createFairForm.Controls.Add(lblVenue);
            createFairForm.Controls.Add(txtVenue);
            createFairForm.Controls.Add(lblDescription);
            createFairForm.Controls.Add(txtDescription);
            createFairForm.Controls.Add(btnSave);
            createFairForm.Controls.Add(btnCancel);
            
            // Add event handlers
            btnCancel.Click += (s, args) => createFairForm.Close();
            
            btnSave.Click += (s, args) =>
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Please enter an event title.", "Missing Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTitle.Focus();
                    return;
                }
                
                if (string.IsNullOrWhiteSpace(txtVenue.Text))
                {
                    MessageBox.Show("Please enter a venue.", "Missing Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtVenue.Focus();
                    return;
                }
                
                // Ensure end time is after start time
                if (dtpEndTime.Value.TimeOfDay <= dtpStartTime.Value.TimeOfDay)
                {
                    MessageBox.Show("End time must be after start time.", "Invalid Time", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpEndTime.Focus();
                    return;
                }
                
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = @"
                            INSERT INTO JobFairEvents (
                                EventTitle, 
                                EventDate, 
                                StartTime, 
                                EndTime, 
                                Venue
                            ) VALUES (
                                @EventTitle, 
                                @EventDate, 
                                @StartTime, 
                                @EndTime, 
                                @Venue
                            )";
                        
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EventTitle", txtTitle.Text.Trim());
                            command.Parameters.AddWithValue("@EventDate", dtpDate.Value.Date);
                            command.Parameters.AddWithValue("@StartTime", dtpStartTime.Value.TimeOfDay);
                            command.Parameters.AddWithValue("@EndTime", dtpEndTime.Value.TimeOfDay);
                            command.Parameters.AddWithValue("@Venue", txtVenue.Text.Trim());
                            
                            command.ExecuteNonQuery();
                            
                            MessageBox.Show("Job fair created successfully!", 
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            // Refresh job fairs grid
                            LoadJobFairs();
                            
                            // Close the form
                            createFairForm.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating job fair: " + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            
            // Show the form
            createFairForm.ShowDialog();
        }

        private void btnManageFair_Click(object sender, EventArgs e)
        {
            if (dgvJobFairs.SelectedRows.Count > 0)
            {
                string fairId = dgvJobFairs.SelectedRows[0].Cells[0].Value.ToString();
                string fairName = dgvJobFairs.SelectedRows[0].Cells[1].Value.ToString();
                
                // Create a form for managing the job fair
                Form manageFairForm = new Form();
                manageFairForm.Text = $"Manage Job Fair - {fairName}";
                manageFairForm.Size = new Size(600, 500);
                manageFairForm.StartPosition = FormStartPosition.CenterParent;
                manageFairForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                manageFairForm.MaximizeBox = false;
                manageFairForm.MinimizeBox = false;
                
                // Create a TabControl to organize management features
                TabControl tabControl = new TabControl();
                tabControl.Location = new Point(20, 20);
                tabControl.Size = new Size(560, 380);
                
                // Create tab pages
                TabPage tabDetails = new TabPage("Fair Details");
                TabPage tabCoordinators = new TabPage("Coordinators");
                TabPage tabStatistics = new TabPage("Statistics");
                
                tabControl.TabPages.Add(tabDetails);
                tabControl.TabPages.Add(tabCoordinators);
                tabControl.TabPages.Add(tabStatistics);
                
                // Load fair details from database
                DateTime eventDate = DateTime.Now;
                TimeSpan startTime = TimeSpan.Zero;
                TimeSpan endTime = TimeSpan.Zero;
                string venue = string.Empty;
                
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = @"
                            SELECT 
                                EventTitle, 
                                EventDate, 
                                StartTime, 
                                EndTime, 
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
                                    fairName = reader["EventTitle"].ToString();
                                    eventDate = (DateTime)reader["EventDate"];
                                    startTime = (TimeSpan)reader["StartTime"];
                                    endTime = (TimeSpan)reader["EndTime"];
                                    venue = reader["Venue"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Job fair details not found.", 
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading job fair details: " + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // TabPage 1: Fair Details
                // Create details form controls
                Label lblTitle = new Label();
                lblTitle.Text = "Event Title:";
                lblTitle.Location = new Point(20, 20);
                lblTitle.AutoSize = true;
                
                TextBox txtTitle = new TextBox();
                txtTitle.Location = new Point(120, 20);
                txtTitle.Size = new Size(400, 25);
                txtTitle.Text = fairName;
                
                Label lblDate = new Label();
                lblDate.Text = "Event Date:";
                lblDate.Location = new Point(20, 60);
                lblDate.AutoSize = true;
                
                DateTimePicker dtpDate = new DateTimePicker();
                dtpDate.Location = new Point(120, 60);
                dtpDate.Size = new Size(200, 25);
                dtpDate.Format = DateTimePickerFormat.Short;
                dtpDate.Value = eventDate;
                
                Label lblStartTime = new Label();
                lblStartTime.Text = "Start Time:";
                lblStartTime.Location = new Point(20, 100);
                lblStartTime.AutoSize = true;
                
                DateTimePicker dtpStartTime = new DateTimePicker();
                dtpStartTime.Location = new Point(120, 100);
                dtpStartTime.Size = new Size(120, 25);
                dtpStartTime.Format = DateTimePickerFormat.Time;
                dtpStartTime.ShowUpDown = true;
                dtpStartTime.Value = DateTime.Today.Add(startTime);
                
                Label lblEndTime = new Label();
                lblEndTime.Text = "End Time:";
                lblEndTime.Location = new Point(20, 140);
                lblEndTime.AutoSize = true;
                
                DateTimePicker dtpEndTime = new DateTimePicker();
                dtpEndTime.Location = new Point(120, 140);
                dtpEndTime.Size = new Size(120, 25);
                dtpEndTime.Format = DateTimePickerFormat.Time;
                dtpEndTime.ShowUpDown = true;
                dtpEndTime.Value = DateTime.Today.Add(endTime);
                
                Label lblVenue = new Label();
                lblVenue.Text = "Venue:";
                lblVenue.Location = new Point(20, 180);
                lblVenue.AutoSize = true;
                
                TextBox txtVenue = new TextBox();
                txtVenue.Location = new Point(120, 180);
                txtVenue.Size = new Size(400, 25);
                txtVenue.Text = venue;
                
                Button btnUpdate = new Button();
                btnUpdate.Text = "Update Job Fair";
                btnUpdate.Location = new Point(350, 240);
                btnUpdate.Size = new Size(170, 30);
                btnUpdate.BackColor = Color.RoyalBlue;
                btnUpdate.ForeColor = Color.White;
                
                // Add update event handler
                btnUpdate.Click += (s, args) =>
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string updateQuery = @"
                                UPDATE JobFairEvents
                                SET 
                                    EventTitle = @EventTitle, 
                                    EventDate = @EventDate, 
                                    StartTime = @StartTime, 
                                    EndTime = @EndTime, 
                                    Venue = @Venue
                                WHERE JobFairID = @JobFairID";
                            
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@JobFairID", fairId);
                                updateCommand.Parameters.AddWithValue("@EventTitle", txtTitle.Text.Trim());
                                updateCommand.Parameters.AddWithValue("@EventDate", dtpDate.Value.Date);
                                updateCommand.Parameters.AddWithValue("@StartTime", dtpStartTime.Value.TimeOfDay);
                                updateCommand.Parameters.AddWithValue("@EndTime", dtpEndTime.Value.TimeOfDay);
                                updateCommand.Parameters.AddWithValue("@Venue", txtVenue.Text.Trim());
                                
                                updateCommand.ExecuteNonQuery();
                                
                                MessageBox.Show("Job fair details updated successfully!", 
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                // Update form title
                                manageFairForm.Text = $"Manage Job Fair - {txtTitle.Text.Trim()}";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating job fair: " + ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                
                // Add details controls to tab page
                tabDetails.Controls.Add(lblTitle);
                tabDetails.Controls.Add(txtTitle);
                tabDetails.Controls.Add(lblDate);
                tabDetails.Controls.Add(dtpDate);
                tabDetails.Controls.Add(lblStartTime);
                tabDetails.Controls.Add(dtpStartTime);
                tabDetails.Controls.Add(lblEndTime);
                tabDetails.Controls.Add(dtpEndTime);
                tabDetails.Controls.Add(lblVenue);
                tabDetails.Controls.Add(txtVenue);
                tabDetails.Controls.Add(btnUpdate);
                
                // TabPage 2: Coordinators
                // Create coordinators grid
                DataGridView dgvCoordinators = new DataGridView();
                dgvCoordinators.Location = new Point(20, 20);
                dgvCoordinators.Size = new Size(500, 200);
                dgvCoordinators.AllowUserToAddRows = false;
                dgvCoordinators.AllowUserToDeleteRows = false;
                dgvCoordinators.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCoordinators.MultiSelect = false;
                dgvCoordinators.ReadOnly = true;
                dgvCoordinators.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                
                // Add columns
                dgvCoordinators.Columns.Add("CoordinatorID", "ID");
                dgvCoordinators.Columns.Add("FullName", "Name");
                dgvCoordinators.Columns.Add("Email", "Email");
                dgvCoordinators.Columns.Add("Status", "Status");
                
                // Add buttons for coordinator management
                Button btnAssign = new Button();
                btnAssign.Text = "Assign Coordinator";
                btnAssign.Location = new Point(20, 240);
                btnAssign.Size = new Size(160, 30);
                
                Button btnUnassign = new Button();
                btnUnassign.Text = "Unassign Coordinator";
                btnUnassign.Location = new Point(200, 240);
                btnUnassign.Size = new Size(160, 30);
                
                // Add controls to coordinators tab
                tabCoordinators.Controls.Add(dgvCoordinators);
                tabCoordinators.Controls.Add(btnAssign);
                tabCoordinators.Controls.Add(btnUnassign);
                
                // TabPage 3: Statistics
                // Create statistics labels
                Label lblStudentsRegistered = new Label();
                lblStudentsRegistered.Text = "Students Registered:";
                lblStudentsRegistered.Location = new Point(20, 40);
                lblStudentsRegistered.AutoSize = true;
                
                Label lblStudentsCount = new Label();
                lblStudentsCount.Text = "0";
                lblStudentsCount.Font = new Font(lblStudentsCount.Font, FontStyle.Bold);
                lblStudentsCount.Location = new Point(200, 40);
                lblStudentsCount.AutoSize = true;
                
                Label lblCompaniesRegistered = new Label();
                lblCompaniesRegistered.Text = "Companies Registered:";
                lblCompaniesRegistered.Location = new Point(20, 80);
                lblCompaniesRegistered.AutoSize = true;
                
                Label lblCompaniesCount = new Label();
                lblCompaniesCount.Text = "0";
                lblCompaniesCount.Font = new Font(lblCompaniesCount.Font, FontStyle.Bold);
                lblCompaniesCount.Location = new Point(200, 80);
                lblCompaniesCount.AutoSize = true;
                
                Button btnRefreshStats = new Button();
                btnRefreshStats.Text = "Refresh Statistics";
                btnRefreshStats.Location = new Point(20, 240);
                btnRefreshStats.Size = new Size(150, 30);
                
                // Add statistics controls to tab
                tabStatistics.Controls.Add(lblStudentsRegistered);
                tabStatistics.Controls.Add(lblStudentsCount);
                tabStatistics.Controls.Add(lblCompaniesRegistered);
                tabStatistics.Controls.Add(lblCompaniesCount);
                tabStatistics.Controls.Add(btnRefreshStats);
                
                // Close button
                Button btnClose = new Button();
                btnClose.Text = "Close";
                btnClose.Location = new Point(480, 420);
                btnClose.Size = new Size(100, 30);
                btnClose.Click += (s, args) => 
                {
                    // Refresh the job fairs grid before closing
                    LoadJobFairs();
                    manageFairForm.Close();
                };
                
                // Add controls to form
                manageFairForm.Controls.Add(tabControl);
                manageFairForm.Controls.Add(btnClose);
                
                // Show the form
                manageFairForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a job fair first.", 
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnApproveCompany_Click(object sender, EventArgs e)
        {
            if (dgvCompanies.SelectedRows.Count > 0)
            {
                string companyId = dgvCompanies.SelectedRows[0].Cells[0].Value.ToString();
                string companyName = dgvCompanies.SelectedRows[0].Cells[1].Value.ToString();
                string status = dgvCompanies.SelectedRows[0].Cells[4].Value.ToString();
                
                if (status == "Pending")
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = @"
                                UPDATE Users
                                SET IsApproved = 1
                                FROM Users u
                                JOIN Recruiters r ON u.UserID = r.UserID
                                WHERE r.CompanyID = @CompanyID";
                            
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@CompanyID", companyId);
                                int rowsAffected = command.ExecuteNonQuery();
                                
                                if (rowsAffected > 0)
                                {
                                    // Update UI
                    dgvCompanies.SelectedRows[0].Cells[4].Value = "Approved";
                    MessageBox.Show($"{companyName} has been approved.", 
                        "Company Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show($"No recruiters found for {companyName}.", 
                                        "Approval Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error approving company: " + ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"{companyName} is already {status}.", 
                        "Status Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a company first.", 
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVerifyStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                string studentId = dgvStudents.SelectedRows[0].Cells[0].Value.ToString();
                string studentName = dgvStudents.SelectedRows[0].Cells[1].Value.ToString();
                string status = dgvStudents.SelectedRows[0].Cells[5].Value.ToString();
                
                if (status == "Pending")
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = @"
                                UPDATE Users
                                SET IsApproved = 1
                                FROM Users u
                                JOIN Students s ON u.UserID = s.UserID
                                WHERE s.StudentID = @StudentID";
                            
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@StudentID", studentId);
                                int rowsAffected = command.ExecuteNonQuery();
                                
                                if (rowsAffected > 0)
                                {
                                    // Update UI
                    dgvStudents.SelectedRows[0].Cells[5].Value = "Verified";
                    MessageBox.Show($"{studentName} has been verified.", 
                        "Student Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show($"Failed to verify {studentName}.", 
                                        "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error verifying student: " + ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"{studentName} is already {status}.", 
                        "Status Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a student first.", 
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            // Refresh data when tab changes
            switch (tabControl1.SelectedIndex)
            {
                case 0: // Job Fairs tab
                    LoadJobFairs();
                    break;
                case 1: // Companies tab
                    LoadCompanies();
                    break;
                case 2: // Students tab
                    LoadStudents();
                    break;
            }
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a SaveFileDialog to let the user specify where to save the report
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveDialog.Title = "Save Report";
                saveDialog.FileName = "JobFairSystem_Report_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
                
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        
                        // Create a StringBuilder to build the report content
                        StringBuilder reportContent = new StringBuilder();
                        
                        // Add report header
                        reportContent.AppendLine("JOB FAIR MANAGEMENT SYSTEM - ADMIN REPORT");
                        reportContent.AppendLine("Generated on: " + DateTime.Now.ToString());
                        reportContent.AppendLine();
                        
                        // Summary statistics
                        reportContent.AppendLine("SUMMARY STATISTICS");
                        reportContent.AppendLine("----------------");
                        
                        // Count of students
                        string studentQuery = "SELECT COUNT(*) FROM Students";
                        using (SqlCommand command = new SqlCommand(studentQuery, connection))
                        {
                            int studentCount = (int)command.ExecuteScalar();
                            reportContent.AppendLine($"Total Students: {studentCount}");
                        }
                        
                        // Count of companies
                        string companyQuery = "SELECT COUNT(*) FROM Companies";
                        using (SqlCommand command = new SqlCommand(companyQuery, connection))
                        {
                            int companyCount = (int)command.ExecuteScalar();
                            reportContent.AppendLine($"Total Companies: {companyCount}");
                        }
                        
                        // Count of job postings
                        string jobQuery = "SELECT COUNT(*) FROM JobPostings";
                        using (SqlCommand command = new SqlCommand(jobQuery, connection))
                        {
                            int jobCount = (int)command.ExecuteScalar();
                            reportContent.AppendLine($"Total Job Postings: {jobCount}");
                        }
                        
                        // Count of applications
                        string applicationQuery = "SELECT COUNT(*) FROM Applications";
                        using (SqlCommand command = new SqlCommand(applicationQuery, connection))
                        {
                            int applicationCount = (int)command.ExecuteScalar();
                            reportContent.AppendLine($"Total Applications: {applicationCount}");
                        }
                        
                        // Count of scheduled interviews
                        string interviewQuery = "SELECT COUNT(*) FROM Interviews";
                        using (SqlCommand command = new SqlCommand(interviewQuery, connection))
                        {
                            int interviewCount = (int)command.ExecuteScalar();
                            reportContent.AppendLine($"Total Interviews: {interviewCount}");
                        }
                        
                        reportContent.AppendLine();
                        
                        // Job fairs section
                        reportContent.AppendLine("UPCOMING JOB FAIRS");
                        reportContent.AppendLine("------------------");
                        reportContent.AppendLine("ID,Title,Date,Venue");
                        
                        string fairsQuery = @"
                            SELECT 
                                JobFairID, 
                                EventTitle, 
                                CONVERT(VARCHAR(10), EventDate, 101) AS EventDate, 
                                Venue
                            FROM JobFairEvents
                            WHERE EventDate >= GETDATE()
                            ORDER BY EventDate";
                        
                        using (SqlCommand command = new SqlCommand(fairsQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    reportContent.AppendLine(
                                        $"{reader["JobFairID"]},{reader["EventTitle"]},{reader["EventDate"]},{reader["Venue"]}");
                                }
                            }
                        }
                        
                        reportContent.AppendLine();
                        
                        // Popular skills section
                        reportContent.AppendLine("TOP STUDENT SKILLS");
                        reportContent.AppendLine("-----------------");
                        reportContent.AppendLine("Skill,Count");
                        
                        string skillsQuery = @"
                            SELECT TOP 10
                                s.SkillName,
                                COUNT(ss.StudentID) AS StudentCount
                            FROM Skills s
                            JOIN StudentSkills ss ON s.SkillID = ss.SkillID
                            GROUP BY s.SkillName
                            ORDER BY StudentCount DESC";
                        
                        using (SqlCommand command = new SqlCommand(skillsQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    reportContent.AppendLine(
                                        $"{reader["SkillName"]},{reader["StudentCount"]}");
                                }
                            }
                        }
                        
                        // Write the report content to the file
                        System.IO.File.WriteAllText(saveDialog.FileName, reportContent.ToString());
                        
                        MessageBox.Show("Report generated successfully!", 
                "Generate Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message,
                    "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvJobFairs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Helper class for job fair details
        private class JobFairDetails
        {
            public string Title { get; set; }
            public DateTime Date { get; set; }
            public TimeSpan StartTime { get; set; }
            public TimeSpan EndTime { get; set; }
            public string Venue { get; set; }
        }
    }
} 