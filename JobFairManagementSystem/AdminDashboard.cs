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
            
            // Initialize the reports combo box
            cmbReportType.SelectedIndex = 0;
            
            // Add event handler for the Show Report button
            btnShowReport.Click += btnShowReport_Click;
            
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
                case 3: // Reports tab
                    // Load initial report
                    if (cmbReportType.SelectedIndex >= 0)
                    {
                        DisplayReport(cmbReportType.SelectedItem.ToString());
                    }
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
                        
                        // Department-wise registration counts
                        reportContent.AppendLine("DEPARTMENT-WISE REGISTRATION COUNTS");
                        reportContent.AppendLine("----------------------------------");
                        reportContent.AppendLine("Department,Student Count");
                        
                        string deptQuery = @"
                            SELECT 
                                DegreeProgram,
                                COUNT(*) AS StudentCount
                            FROM Students
                            GROUP BY DegreeProgram
                            ORDER BY StudentCount DESC";
                        
                        using (SqlCommand command = new SqlCommand(deptQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    reportContent.AppendLine(
                                        $"{reader["DegreeProgram"]},{reader["StudentCount"]}");
                                }
                            }
                        }
                        
                        reportContent.AppendLine();
                        
                        // GPA distribution across applicants
                        reportContent.AppendLine("GPA DISTRIBUTION");
                        reportContent.AppendLine("---------------");
                        reportContent.AppendLine("GPA Range,Student Count");
                        
                        string gpaQuery = @"
                            WITH GPARanges AS (
                                SELECT 
                                    CASE 
                                        WHEN GPA >= 3.5 THEN '3.5 - 4.0'
                                        WHEN GPA >= 3.0 THEN '3.0 - 3.49'
                                        WHEN GPA >= 2.5 THEN '2.5 - 2.99'
                                        WHEN GPA >= 2.0 THEN '2.0 - 2.49'
                                        ELSE 'Below 2.0'
                                    END AS GPARange,
                                    CASE 
                                        WHEN GPA >= 3.5 THEN 1
                                        WHEN GPA >= 3.0 THEN 2
                                        WHEN GPA >= 2.5 THEN 3
                                        WHEN GPA >= 2.0 THEN 4
                                        ELSE 5
                                    END AS SortOrder,
                                    COUNT(*) AS StudentCount
                                FROM Students
                                GROUP BY 
                                    CASE 
                                        WHEN GPA >= 3.5 THEN '3.5 - 4.0'
                                        WHEN GPA >= 3.0 THEN '3.0 - 3.49'
                                        WHEN GPA >= 2.5 THEN '2.5 - 2.99'
                                        WHEN GPA >= 2.0 THEN '2.0 - 2.49'
                                        ELSE 'Below 2.0'
                                    END,
                                    CASE 
                                        WHEN GPA >= 3.5 THEN 1
                                        WHEN GPA >= 3.0 THEN 2
                                        WHEN GPA >= 2.5 THEN 3
                                        WHEN GPA >= 2.0 THEN 4
                                        ELSE 5
                                    END
                            )
                            SELECT GPARange, StudentCount 
                            FROM GPARanges
                            ORDER BY SortOrder";
                        
                        using (SqlCommand command = new SqlCommand(gpaQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    reportContent.AppendLine(
                                        $"{reader["GPARange"]},{reader["StudentCount"]}");
                                }
                            }
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
                        
                        reportContent.AppendLine();
                        
                        // Interviews by Company section
                        reportContent.AppendLine("INTERVIEWS BY COMPANY");
                        reportContent.AppendLine("----------------------");
                        reportContent.AppendLine("Company,Total Interviews,Percentage");
                        
                        string interviewsQuery = @"
                            SELECT 
                                c.CompanyName,
                                COUNT(i.InterviewID) AS InterviewCount
                            FROM Companies c
                            JOIN Recruiters r ON c.CompanyID = r.CompanyID
                            JOIN JobPostings jp ON c.CompanyID = jp.CompanyID
                            JOIN Applications a ON jp.JobID = a.JobID
                            JOIN Interviews i ON a.ApplicationID = i.ApplicationID
                            GROUP BY c.CompanyName
                            ORDER BY InterviewCount DESC";
                        
                        int totalInterviews = 0;
                        string totalInterviewsQuery = "SELECT COUNT(*) FROM Interviews";
                        
                        using (SqlCommand totCommand = new SqlCommand(totalInterviewsQuery, connection))
                        {
                            var result = totCommand.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                totalInterviews = Convert.ToInt32(result);
                            }
                        }
                        
                        using (SqlCommand command = new SqlCommand(interviewsQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string company = reader["CompanyName"].ToString();
                                    int count = Convert.ToInt32(reader["InterviewCount"]);
                                    double percentage = totalInterviews > 0 ? (double)count / totalInterviews * 100 : 0;
                                    
                                    reportContent.AppendLine(
                                        $"{company},{count},{percentage:F1}%");
                                }
                            }
                        }
                        
                        reportContent.AppendLine();
                        
                        // Offer Acceptance Ratios section
                        reportContent.AppendLine("OFFER ACCEPTANCE RATIOS");
                        reportContent.AppendLine("-----------------------");
                        reportContent.AppendLine("Company,Applications,Offers,Accepted,Acceptance Rate");
                        
                        string offerQuery = @"
                            WITH ApplicationStats AS (
                                SELECT 
                                    c.CompanyName,
                                    COUNT(a.ApplicationID) AS TotalApplications,
                                    SUM(CASE WHEN a.ApplicationStatus = 'Offered' OR a.ApplicationStatus = 'Accepted' THEN 1 ELSE 0 END) AS OfferedCount,
                                    SUM(CASE WHEN a.ApplicationStatus = 'Accepted' THEN 1 ELSE 0 END) AS AcceptedCount
                                FROM Companies c
                                JOIN JobPostings jp ON c.CompanyID = jp.CompanyID
                                JOIN Applications a ON jp.JobID = a.JobID
                                GROUP BY c.CompanyName
                            )
                            SELECT 
                                CompanyName,
                                TotalApplications,
                                OfferedCount,
                                AcceptedCount,
                                CASE 
                                    WHEN OfferedCount > 0 THEN CAST((AcceptedCount * 100.0) / OfferedCount AS DECIMAL(5,1))
                                    ELSE 0
                                END AS AcceptanceRate
                            FROM ApplicationStats
                            ORDER BY AcceptanceRate DESC";
                        
                        using (SqlCommand command = new SqlCommand(offerQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    reportContent.AppendLine(
                                        $"{reader["CompanyName"]},{reader["TotalApplications"]},{reader["OfferedCount"]},{reader["AcceptedCount"]},{reader["AcceptanceRate"]}%");
                                }
                            }
                        }
                        
                        reportContent.AppendLine();
                        
                        // Recruiter Ratings section
                        reportContent.AppendLine("RECRUITER RATINGS");
                        reportContent.AppendLine("-----------------");
                        reportContent.AppendLine("Company,Recruiter,Average Rating,Review Count");
                        
                        string ratingsQuery = @"
                            SELECT 
                                c.CompanyName,
                                u.FullName AS RecruiterName,
                                AVG(CAST(r.Rating AS DECIMAL(3,2))) AS AverageRating,
                                COUNT(r.ReviewID) AS ReviewCount
                            FROM Reviews r
                            JOIN Recruiters rec ON r.RecruiterID = rec.RecruiterID
                            JOIN Users u ON rec.UserID = u.UserID
                            JOIN Companies c ON rec.CompanyID = c.CompanyID
                            GROUP BY c.CompanyName, u.FullName
                            ORDER BY AverageRating DESC";
                        
                        using (SqlCommand command = new SqlCommand(ratingsQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    reportContent.AppendLine(
                                        $"{reader["CompanyName"]},{reader["RecruiterName"]},{reader["AverageRating"]:F2},{reader["ReviewCount"]}");
                                }
                            }
                        }
                        
                        reportContent.AppendLine();
                        
                        // Placement Statistics section
                        reportContent.AppendLine("OVERALL PLACEMENT STATISTICS");
                        reportContent.AppendLine("---------------------------");
                        reportContent.AppendLine("Metric,Value,Percentage");
                        
                        string placementQuery = @"
                            SELECT 
                                COUNT(DISTINCT s.StudentID) AS TotalStudents,
                                COUNT(DISTINCT bv.StudentID) AS ParticipatedStudents,
                                SUM(CASE WHEN a.ApplicationStatus = 'Accepted' THEN 1 ELSE 0 END) AS HiredStudents
                            FROM Students s
                            LEFT JOIN BoothVisits bv ON s.StudentID = bv.StudentID
                            LEFT JOIN Applications a ON s.StudentID = a.StudentID";
                            
                        using (SqlCommand command = new SqlCommand(placementQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int totalStudents = Convert.ToInt32(reader["TotalStudents"]);
                                    int participatedStudents = Convert.ToInt32(reader["ParticipatedStudents"]);
                                    int hiredStudents = Convert.ToInt32(reader["HiredStudents"]);
                                    
                                    double participationRate = totalStudents > 0 ? (double)participatedStudents / totalStudents * 100 : 0;
                                    double placementRate = participatedStudents > 0 ? (double)hiredStudents / participatedStudents * 100 : 0;
                                    double overallRate = totalStudents > 0 ? (double)hiredStudents / totalStudents * 100 : 0;
                                    
                                    reportContent.AppendLine($"Total Registered Students,{totalStudents},100%");
                                    reportContent.AppendLine($"Students Who Participated in Job Fairs,{participatedStudents},{participationRate:F1}% of total");
                                    reportContent.AppendLine($"Students Who Accepted Job Offers,{hiredStudents},{placementRate:F1}% of participants");
                                    reportContent.AppendLine($"Overall Placement Rate,{hiredStudents},{overallRate:F1}% of total");
                                }
                            }
                        }
                        
                        reportContent.AppendLine();
                        
                        // Placement Rates by Department section
                        reportContent.AppendLine("PLACEMENT RATES BY DEPARTMENT");
                        reportContent.AppendLine("----------------------------");
                        reportContent.AppendLine("Degree Program,Total Students,Participants,Placed,Placement Rate");
                        
                        string deptPlacementQuery = @"
                            WITH DepartmentStats AS (
                                SELECT 
                                    s.DegreeProgram,
                                    COUNT(DISTINCT s.StudentID) AS TotalStudents,
                                    COUNT(DISTINCT bv.StudentID) AS ParticipatedStudents,
                                    SUM(CASE WHEN a.ApplicationStatus = 'Accepted' THEN 1 ELSE 0 END) AS HiredStudents
                                FROM Students s
                                LEFT JOIN BoothVisits bv ON s.StudentID = bv.StudentID
                                LEFT JOIN Applications a ON s.StudentID = a.StudentID
                                GROUP BY s.DegreeProgram
                            )
                            SELECT 
                                DegreeProgram,
                                TotalStudents,
                                ParticipatedStudents,
                                HiredStudents,
                                CASE 
                                    WHEN ParticipatedStudents > 0 THEN CAST((HiredStudents * 100.0) / ParticipatedStudents AS DECIMAL(5,1))
                                    ELSE 0 
                                END AS PlacementRate
                            FROM DepartmentStats
                            ORDER BY PlacementRate DESC";
                        
                        using (SqlCommand command = new SqlCommand(deptPlacementQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                int totalStudents = 0;
                                int totalParticipants = 0;
                                int totalPlaced = 0;
                                
                                while (reader.Read())
                                {
                                    string dept = reader["DegreeProgram"].ToString();
                                    int students = Convert.ToInt32(reader["TotalStudents"]);
                                    int participants = Convert.ToInt32(reader["ParticipatedStudents"]);
                                    int placed = Convert.ToInt32(reader["HiredStudents"]);
                                    decimal rate = Convert.ToDecimal(reader["PlacementRate"]);
                                    
                                    totalStudents += students;
                                    totalParticipants += participants;
                                    totalPlaced += placed;
                                    
                                    reportContent.AppendLine($"{dept},{students},{participants},{placed},{rate}%");
                                }
                                
                                // Add overall summary
                                if (totalParticipants > 0)
                                {
                                    decimal overallRate = Math.Round((decimal)totalPlaced / totalParticipants * 100, 1);
                                    reportContent.AppendLine($"OVERALL,{totalStudents},{totalParticipants},{totalPlaced},{overallRate}%");
                                }
                            }
                        }
                        
                        reportContent.AppendLine();
                        
                        // Average Salary by Program section
                        reportContent.AppendLine("AVERAGE SALARY BY PROGRAM");
                        reportContent.AppendLine("------------------------");
                        reportContent.AppendLine("Degree Program,Students Placed,Most Common Salary Range");
                        
                        string salaryQuery = @"
                            WITH SalaryStats AS (
                                SELECT 
                                    s.DegreeProgram,
                                    COUNT(DISTINCT a.StudentID) AS PlacedStudents,
                                    jp.SalaryRange,
                                    COUNT(jp.SalaryRange) AS RangeCount
                                FROM Students s
                                JOIN Applications a ON s.StudentID = a.StudentID AND a.ApplicationStatus = 'Accepted'
                                JOIN JobPostings jp ON a.JobID = jp.JobID
                                GROUP BY s.DegreeProgram, jp.SalaryRange
                            ),
                            RankedSalaries AS (
                                SELECT 
                                    DegreeProgram,
                                    SalaryRange,
                                    RangeCount,
                                    ROW_NUMBER() OVER (PARTITION BY DegreeProgram ORDER BY RangeCount DESC) as RankNum
                                FROM SalaryStats
                            )
                            SELECT 
                                rs.DegreeProgram,
                                SUM(ss.PlacedStudents) AS TotalPlaced,
                                rs.SalaryRange AS MostCommonRange
                            FROM RankedSalaries rs
                            JOIN SalaryStats ss ON rs.DegreeProgram = ss.DegreeProgram AND rs.SalaryRange = ss.SalaryRange
                            WHERE rs.RankNum = 1
                            GROUP BY rs.DegreeProgram, rs.SalaryRange
                            ORDER BY TotalPlaced DESC";
                        
                        using (SqlCommand command = new SqlCommand(salaryQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string dept = reader["DegreeProgram"].ToString();
                                    int placed = Convert.ToInt32(reader["TotalPlaced"]);
                                    string mostCommon = reader["MostCommonRange"].ToString();
                                    
                                    reportContent.AppendLine($"{dept},{placed},{mostCommon}");
                                }
                            }
                        }
                        
                        reportContent.AppendLine();
                        
                        // Booth Traffic Analysis section
                        reportContent.AppendLine("BOOTH TRAFFIC ANALYSIS");
                        reportContent.AppendLine("----------------------");
                        reportContent.AppendLine("Company,Booth Number,Total Visits,Unique Students,Avg. Time (min)");
                        
                        string boothTrafficQuery = @"
                            WITH BoothStats AS (
                                SELECT 
                                    c.CompanyName,
                                    bv.BoothNumber,
                                    COUNT(bv.VisitID) AS TotalVisits,
                                    COUNT(DISTINCT bv.StudentID) AS UniqueStudents,
                                    AVG(DATEDIFF(MINUTE, bv.CheckInTime, DATEADD(MINUTE, 15, bv.CheckInTime))) AS AvgTimeSpent
                                FROM BoothVisits bv
                                JOIN Companies c ON bv.CompanyID = c.CompanyID
                                WHERE bv.CheckInTime IS NOT NULL
                                GROUP BY c.CompanyName, bv.BoothNumber
                            )
                            SELECT *
                            FROM BoothStats
                            ORDER BY TotalVisits DESC";
                        
                        using (SqlCommand command = new SqlCommand(boothTrafficQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                bool hasData = false;
                                
                                while (reader.Read())
                                {
                                    hasData = true;
                                    string company = reader["CompanyName"].ToString();
                                    string boothNumber = reader["BoothNumber"].ToString();
                                    int visits = Convert.ToInt32(reader["TotalVisits"]);
                                    int uniqueStudents = Convert.ToInt32(reader["UniqueStudents"]);
                                    decimal avgTime = Math.Round(Convert.ToDecimal(reader["AvgTimeSpent"]), 1);
                                    
                                    reportContent.AppendLine($"{company},{boothNumber},{visits},{uniqueStudents},{avgTime}");
                                }
                                
                                if (!hasData)
                                {
                                    reportContent.AppendLine("No booth traffic data available");
                                }
                            }
                        }
                        
                        reportContent.AppendLine();
                        
                        // Peak Participation Hours section
                        reportContent.AppendLine("PEAK PARTICIPATION HOURS");
                        reportContent.AppendLine("------------------------");
                        reportContent.AppendLine("Hour of Day,Total Check-ins,Percentage,Booth Visits,General Check-ins");
                        
                        string peakHoursQuery = @"
                            WITH HourlyStats AS (
                                SELECT 
                                    DATEPART(HOUR, CheckInTime) AS HourOfDay,
                                    COUNT(*) AS TotalCheckins,
                                    SUM(CASE WHEN CompanyID IS NOT NULL THEN 1 ELSE 0 END) AS BoothVisits,
                                    SUM(CASE WHEN CompanyID IS NULL THEN 1 ELSE 0 END) AS GeneralCheckins
                                FROM BoothVisits
                                WHERE CheckInTime IS NOT NULL
                                GROUP BY DATEPART(HOUR, CheckInTime)
                            )
                            SELECT 
                                HourOfDay,
                                TotalCheckins,
                                BoothVisits,
                                GeneralCheckins,
                                CAST(TotalCheckins * 100.0 / (SELECT SUM(TotalCheckins) FROM HourlyStats) AS DECIMAL(5,1)) AS CheckinPercentage
                            FROM HourlyStats
                            ORDER BY TotalCheckins DESC";
                        
                        using (SqlCommand command = new SqlCommand(peakHoursQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                bool hasData = false;
                                
                                while (reader.Read())
                                {
                                    hasData = true;
                                    int hour = Convert.ToInt32(reader["HourOfDay"]);
                                    int checkins = Convert.ToInt32(reader["TotalCheckins"]);
                                    int boothVisits = Convert.ToInt32(reader["BoothVisits"]);
                                    int generalCheckins = Convert.ToInt32(reader["GeneralCheckins"]);
                                    decimal percentage = Convert.ToDecimal(reader["CheckinPercentage"]);
                                    
                                    // Format the hour as a time range (e.g., "9:00 - 10:00")
                                    string hourDisplay = $"{hour:D2}:00 - {(hour + 1) % 24:D2}:00";
                                    
                                    reportContent.AppendLine($"{hourDisplay},{checkins},{percentage}%,{boothVisits},{generalCheckins}");
                                }
                                
                                if (!hasData)
                                {
                                    reportContent.AppendLine("No check-in data available");
                                }
                            }
                        }
                        
                        reportContent.AppendLine();
                        
                        // Resource Usage Metrics section
                        reportContent.AppendLine("RESOURCE USAGE METRICS");
                        reportContent.AppendLine("----------------------");
                        reportContent.AppendLine("Resource Type,Total Allocated,Used,Utilization Rate,Details");
                        
                        // First, add booth space utilization
                        string boothSpaceQuery = @"
                            SELECT 
                                COUNT(DISTINCT bv.BoothNumber) AS AllocatedBooths,
                                COUNT(DISTINCT CASE WHEN bv.CheckInTime IS NOT NULL THEN bv.BoothNumber END) AS UsedBooths,
                                CASE 
                                    WHEN COUNT(DISTINCT bv.BoothNumber) > 0 
                                    THEN CAST(COUNT(DISTINCT CASE WHEN bv.CheckInTime IS NOT NULL THEN bv.BoothNumber END) * 100.0 / 
                                         COUNT(DISTINCT bv.BoothNumber) AS DECIMAL(5,1))
                                    ELSE 0
                                END AS UtilizationRate
                            FROM BoothVisits bv
                            WHERE bv.BoothNumber IS NOT NULL";
                        
                        using (SqlCommand command = new SqlCommand(boothSpaceQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int allocatedBooths = Convert.ToInt32(reader["AllocatedBooths"]);
                                    int usedBooths = Convert.ToInt32(reader["UsedBooths"]);
                                    decimal utilizationRate = Convert.ToDecimal(reader["UtilizationRate"]);
                                    
                                    reportContent.AppendLine($"Booth Space,{allocatedBooths},{usedBooths},{utilizationRate}%,{usedBooths} of {allocatedBooths} booths had visitor activity");
                                }
                            }
                        }
                        
                        // Then add coordinator allocation
                        string coordinatorQuery = @"
                            WITH CoordinatorStats AS (
                                SELECT 
                                    COUNT(DISTINCT CoordinatorID) AS TotalCoordinators,
                                    COUNT(DISTINCT CASE WHEN AssignedFairID IS NOT NULL THEN CoordinatorID END) AS AssignedCoordinators
                                FROM BoothCoordinators
                            )
                            SELECT 
                                TotalCoordinators,
                                AssignedCoordinators,
                                CASE 
                                    WHEN TotalCoordinators > 0 
                                    THEN CAST(AssignedCoordinators * 100.0 / TotalCoordinators AS DECIMAL(5,1))
                                    ELSE 0
                                END AS UtilizationRate
                            FROM CoordinatorStats";
                        
                        using (SqlCommand command = new SqlCommand(coordinatorQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int totalCoordinators = Convert.ToInt32(reader["TotalCoordinators"]);
                                    int assignedCoordinators = Convert.ToInt32(reader["AssignedCoordinators"]);
                                    decimal utilizationRate = Convert.ToDecimal(reader["UtilizationRate"]);
                                    
                                    reportContent.AppendLine($"Coordinator Time,{totalCoordinators},{assignedCoordinators},{utilizationRate}%,{assignedCoordinators} of {totalCoordinators} coordinators assigned to fairs");
                                }
                            }
                        }
                        
                        // Finally, add timeslot usage data
                        string timeSlotQuery = @"
                            SELECT 
                                jf.EventTitle,
                                DATEDIFF(HOUR, jf.StartTime, jf.EndTime) AS TotalHours,
                                COUNT(DISTINCT DATEPART(HOUR, bv.CheckInTime)) AS ActiveHours,
                                CASE 
                                    WHEN DATEDIFF(HOUR, jf.StartTime, jf.EndTime) > 0 
                                    THEN CAST(COUNT(DISTINCT DATEPART(HOUR, bv.CheckInTime)) * 100.0 / 
                                         DATEDIFF(HOUR, jf.StartTime, jf.EndTime) AS DECIMAL(5,1))
                                    ELSE 0
                                END AS TimeUtilization
                            FROM JobFairEvents jf
                            LEFT JOIN BoothVisits bv ON jf.JobFairID = bv.JobFairID AND bv.CheckInTime IS NOT NULL
                            GROUP BY jf.EventTitle, jf.StartTime, jf.EndTime";
                        
                        using (SqlCommand command = new SqlCommand(timeSlotQuery, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                bool hasData = false;
                                while (reader.Read())
                                {
                                    hasData = true;
                                    string eventTitle = reader["EventTitle"].ToString();
                                    int totalHours = Convert.ToInt32(reader["TotalHours"]);
                                    int activeHours = Convert.ToInt32(reader["ActiveHours"]);
                                    decimal utilization = Convert.ToDecimal(reader["TimeUtilization"]);
                                    
                                    reportContent.AppendLine($"Time Slots,{totalHours},{activeHours},{utilization}%,{activeHours} of {totalHours} hours had activity for {eventTitle}");
                                }
                                
                                if (!hasData)
                                {
                                    reportContent.AppendLine("Time Slots,N/A,N/A,N/A,No time slot data available");
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

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            string reportType = cmbReportType.SelectedItem.ToString();
            DisplayReport(reportType);
        }

        private void DisplayReport(string reportType)
        {
            try
            {
                panel2.Controls.Clear();
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Create a ListView to display the report data
                    ListView listView = new ListView();
                    listView.View = View.Details;
                    listView.FullRowSelect = true;
                    listView.GridLines = true;
                    listView.Size = new Size(800, 230);
                    listView.Location = new Point(20, 10);
                    
                    Label lblSummary = new Label();
                    lblSummary.AutoSize = true;
                    lblSummary.Location = new Point(20, 200);
                    lblSummary.ForeColor = Color.Navy;
                    
                    switch (reportType)
                    {
                        case "Department-wise Registration":
                            listView.Columns.Add("Department", 200);
                            listView.Columns.Add("Student Count", 100);
                            listView.Columns.Add("Percentage", 100);
                            
                            string deptQuery = @"
                                SELECT 
                                    DegreeProgram,
                                    COUNT(*) AS StudentCount
                                FROM Students
                                GROUP BY DegreeProgram
                                ORDER BY StudentCount DESC";
                            
                            using (SqlCommand command = new SqlCommand(deptQuery, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    int totalStudents = 0;
                                    Dictionary<string, int> deptCounts = new Dictionary<string, int>();
                                    
                                    while (reader.Read())
                                    {
                                        string dept = reader["DegreeProgram"].ToString();
                                        int count = Convert.ToInt32(reader["StudentCount"]);
                                        deptCounts.Add(dept, count);
                                        totalStudents += count;
                                    }
                                    
                                    // Calculate percentages and populate ListView
                                    foreach (var dept in deptCounts)
                                    {
                                        double percentage = (double)dept.Value / totalStudents * 100;
                                        ListViewItem item = new ListViewItem(dept.Key);
                                        item.SubItems.Add(dept.Value.ToString());
                                        item.SubItems.Add($"{percentage:F1}%");
                                        listView.Items.Add(item);
                                    }
                                    
                                    lblSummary.Text = $"Total students registered: {totalStudents}";
                                }
                            }
                            break;
                            
                        case "GPA Distribution":
                            listView.Columns.Add("GPA Range", 200);
                            listView.Columns.Add("Student Count", 100);
                            listView.Columns.Add("Percentage", 100);
                            
                            string gpaQuery = @"
                                WITH GPARanges AS (
                                    SELECT 
                                        CASE 
                                            WHEN GPA >= 3.5 THEN '3.5 - 4.0'
                                            WHEN GPA >= 3.0 THEN '3.0 - 3.49'
                                            WHEN GPA >= 2.5 THEN '2.5 - 2.99'
                                            WHEN GPA >= 2.0 THEN '2.0 - 2.49'
                                            ELSE 'Below 2.0'
                                        END AS GPARange,
                                        CASE 
                                            WHEN GPA >= 3.5 THEN 1
                                            WHEN GPA >= 3.0 THEN 2
                                            WHEN GPA >= 2.5 THEN 3
                                            WHEN GPA >= 2.0 THEN 4
                                            ELSE 5
                                        END AS SortOrder,
                                        COUNT(*) AS StudentCount
                                    FROM Students
                                    GROUP BY 
                                        CASE 
                                            WHEN GPA >= 3.5 THEN '3.5 - 4.0'
                                            WHEN GPA >= 3.0 THEN '3.0 - 3.49'
                                            WHEN GPA >= 2.5 THEN '2.5 - 2.99'
                                            WHEN GPA >= 2.0 THEN '2.0 - 2.49'
                                            ELSE 'Below 2.0'
                                        END,
                                        CASE 
                                            WHEN GPA >= 3.5 THEN 1
                                            WHEN GPA >= 3.0 THEN 2
                                            WHEN GPA >= 2.5 THEN 3
                                            WHEN GPA >= 2.0 THEN 4
                                            ELSE 5
                                        END
                                )
                                SELECT GPARange, StudentCount 
                                FROM GPARanges
                                ORDER BY SortOrder";
                            
                            using (SqlCommand command = new SqlCommand(gpaQuery, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    int totalStudents = 0;
                                    Dictionary<string, int> gpaCounts = new Dictionary<string, int>();
                                    
                                    while (reader.Read())
                                    {
                                        string range = reader["GPARange"].ToString();
                                        int count = Convert.ToInt32(reader["StudentCount"]);
                                        gpaCounts.Add(range, count);
                                        totalStudents += count;
                                    }
                                    
                                    // Calculate percentages and populate ListView
                                    foreach (var range in gpaCounts)
                                    {
                                        double percentage = (double)range.Value / totalStudents * 100;
                                        ListViewItem item = new ListViewItem(range.Key);
                                        item.SubItems.Add(range.Value.ToString());
                                        item.SubItems.Add($"{percentage:F1}%");
                                        listView.Items.Add(item);
                                    }
                                    
                                    double averageGPA = 0;
                                    // Calculate approximate average GPA (weighted average of ranges)
                                    if (gpaCounts.ContainsKey("3.5 - 4.0")) averageGPA += gpaCounts["3.5 - 4.0"] * 3.75;
                                    if (gpaCounts.ContainsKey("3.0 - 3.49")) averageGPA += gpaCounts["3.0 - 3.49"] * 3.25;
                                    if (gpaCounts.ContainsKey("2.5 - 2.99")) averageGPA += gpaCounts["2.5 - 2.99"] * 2.75;
                                    if (gpaCounts.ContainsKey("2.0 - 2.49")) averageGPA += gpaCounts["2.0 - 2.49"] * 2.25;
                                    if (gpaCounts.ContainsKey("Below 2.0")) averageGPA += gpaCounts["Below 2.0"] * 1.75;
                                    
                                    averageGPA /= totalStudents;
                                    
                                    lblSummary.Text = $"Average GPA: {averageGPA:F2}";
                                }
                            }
                            break;
                            
                        case "Top Skills":
                            listView.Columns.Add("Skill", 250);
                            listView.Columns.Add("Student Count", 100);
                            listView.Columns.Add("Popularity", 150);
                            
                            string skillsQuery = @"
                                SELECT TOP 10
                                    s.SkillName,
                                    COUNT(ss.StudentID) AS StudentCount
                                FROM Skills s
                                JOIN StudentSkills ss ON s.SkillID = ss.SkillID
                                GROUP BY s.SkillName
                                ORDER BY StudentCount DESC";
                            
                            // Count total students
                            string totalQuery = "SELECT COUNT(*) FROM Students";
                            int totalStudentCount = 0;
                            
                            using (SqlCommand totCommand = new SqlCommand(totalQuery, connection))
                            {
                                totalStudentCount = (int)totCommand.ExecuteScalar();
                            }
                            
                            using (SqlCommand command = new SqlCommand(skillsQuery, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        string skill = reader["SkillName"].ToString();
                                        int count = Convert.ToInt32(reader["StudentCount"]);
                                        double percentage = (double)count / totalStudentCount * 100;
                                        
                                        ListViewItem item = new ListViewItem(skill);
                                        item.SubItems.Add(count.ToString());
                                        item.SubItems.Add($"{percentage:F1}% of students");
                                        listView.Items.Add(item);
                                    }
                                    
                                    lblSummary.Text = "Skills distribution among registered students";
                                }
                            }
                            break;
                            
                        case "Interviews by Company":
                            listView.Columns.Add("Company", 250);
                            listView.Columns.Add("Total Interviews", 120);
                            listView.Columns.Add("% of All Interviews", 150);
                            
                            string interviewsQuery = @"
                                SELECT 
                                    c.CompanyName,
                                    COUNT(i.InterviewID) AS InterviewCount
                                FROM Companies c
                                JOIN Recruiters r ON c.CompanyID = r.CompanyID
                                JOIN JobPostings jp ON c.CompanyID = jp.CompanyID
                                JOIN Applications a ON jp.JobID = a.JobID
                                JOIN Interviews i ON a.ApplicationID = i.ApplicationID
                                GROUP BY c.CompanyName
                                ORDER BY InterviewCount DESC";
                            
                            // Get total interviews count
                            string totalInterviewsQuery = "SELECT COUNT(*) FROM Interviews";
                            int totalInterviews = 0;
                            
                            using (SqlCommand totCommand = new SqlCommand(totalInterviewsQuery, connection))
                            {
                                var result = totCommand.ExecuteScalar();
                                if (result != null && result != DBNull.Value)
                                {
                                    totalInterviews = Convert.ToInt32(result);
                                }
                            }
                            
                            using (SqlCommand command = new SqlCommand(interviewsQuery, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    bool hasData = false;
                                    while (reader.Read())
                                    {
                                        hasData = true;
                                        string company = reader["CompanyName"].ToString();
                                        int count = Convert.ToInt32(reader["InterviewCount"]);
                                        double percentage = totalInterviews > 0 ? (double)count / totalInterviews * 100 : 0;
                                        
                                        ListViewItem item = new ListViewItem(company);
                                        item.SubItems.Add(count.ToString());
                                        item.SubItems.Add($"{percentage:F1}%");
                                        listView.Items.Add(item);
                                    }
                                    
                                    if (!hasData)
                                    {
                                        ListViewItem item = new ListViewItem("No interview data available");
                                        listView.Items.Add(item);
                                    }
                                    
                                    lblSummary.Text = $"Total interviews conducted: {totalInterviews}";
                                }
                            }
                            break;
                            
                        case "Offer Acceptance Ratios":
                            listView.Columns.Add("Company", 250);
                            listView.Columns.Add("Applications", 100);
                            listView.Columns.Add("Offers", 80);
                            listView.Columns.Add("Accepted", 80);
                            listView.Columns.Add("Acceptance Rate", 120);
                            
                            string offerQuery = @"
                                WITH ApplicationStats AS (
                                    SELECT 
                                        c.CompanyName,
                                        COUNT(a.ApplicationID) AS TotalApplications,
                                        SUM(CASE WHEN a.ApplicationStatus = 'Offered' OR a.ApplicationStatus = 'Accepted' THEN 1 ELSE 0 END) AS OfferedCount,
                                        SUM(CASE WHEN a.ApplicationStatus = 'Accepted' THEN 1 ELSE 0 END) AS AcceptedCount
                                    FROM Companies c
                                    JOIN JobPostings jp ON c.CompanyID = jp.CompanyID
                                    JOIN Applications a ON jp.JobID = a.JobID
                                    GROUP BY c.CompanyName
                                )
                                SELECT 
                                    CompanyName,
                                    TotalApplications,
                                    OfferedCount,
                                    AcceptedCount,
                                    CASE 
                                        WHEN OfferedCount > 0 THEN CAST((AcceptedCount * 100.0) / OfferedCount AS DECIMAL(5,1))
                                        ELSE 0
                                    END AS AcceptanceRate
                                FROM ApplicationStats
                                ORDER BY AcceptanceRate DESC";
                            
                            using (SqlCommand command = new SqlCommand(offerQuery, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    bool hasData = false;
                                    int totalApplications = 0;
                                    int totalOffers = 0;
                                    int totalAccepted = 0;
                                    
                                    while (reader.Read())
                                    {
                                        hasData = true;
                                        string company = reader["CompanyName"].ToString();
                                        int applications = Convert.ToInt32(reader["TotalApplications"]);
                                        int offers = Convert.ToInt32(reader["OfferedCount"]);
                                        int accepted = Convert.ToInt32(reader["AcceptedCount"]);
                                        decimal rate = Convert.ToDecimal(reader["AcceptanceRate"]);
                                        
                                        totalApplications += applications;
                                        totalOffers += offers;
                                        totalAccepted += accepted;
                                        
                                        ListViewItem item = new ListViewItem(company);
                                        item.SubItems.Add(applications.ToString());
                                        item.SubItems.Add(offers.ToString());
                                        item.SubItems.Add(accepted.ToString());
                                        item.SubItems.Add($"{rate}%");
                                        listView.Items.Add(item);
                                    }
                                    
                                    if (!hasData)
                                    {
                                        ListViewItem item = new ListViewItem("No application data available");
                                        listView.Items.Add(item);
                                    }
                                    
                                    decimal overallRate = totalOffers > 0 ? Math.Round((decimal)totalAccepted / totalOffers * 100, 1) : 0;
                                    lblSummary.Text = $"Overall acceptance rate: {overallRate}% ({totalAccepted} accepted out of {totalOffers} offers)";
                                }
                            }
                            break;
                            
                        case "Recruiter Ratings":
                            listView.Columns.Add("Company", 200);
                            listView.Columns.Add("Recruiter Name", 150);
                            listView.Columns.Add("Avg. Rating", 100);
                            listView.Columns.Add("Total Reviews", 100);
                            
                            string ratingsQuery = @"
                                SELECT 
                                    c.CompanyName,
                                    u.FullName AS RecruiterName,
                                    AVG(CAST(r.Rating AS DECIMAL(3,2))) AS AverageRating,
                                    COUNT(r.ReviewID) AS ReviewCount
                                FROM Reviews r
                                JOIN Recruiters rec ON r.RecruiterID = rec.RecruiterID
                                JOIN Users u ON rec.UserID = u.UserID
                                JOIN Companies c ON rec.CompanyID = c.CompanyID
                                GROUP BY c.CompanyName, u.FullName
                                ORDER BY AverageRating DESC";
                            
                            using (SqlCommand command = new SqlCommand(ratingsQuery, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    bool hasData = false;
                                    int totalReviews = 0;
                                    decimal weightedRatingSum = 0;
                                    
                                    while (reader.Read())
                                    {
                                        hasData = true;
                                        string company = reader["CompanyName"].ToString();
                                        string recruiter = reader["RecruiterName"].ToString();
                                        decimal avgRating = Convert.ToDecimal(reader["AverageRating"]);
                                        int reviewCount = Convert.ToInt32(reader["ReviewCount"]);
                                        
                                        totalReviews += reviewCount;
                                        weightedRatingSum += avgRating * reviewCount;
                                        
                                        ListViewItem item = new ListViewItem(company);
                                        item.SubItems.Add(recruiter);
                                        item.SubItems.Add($"{avgRating:F2}");
                                        item.SubItems.Add(reviewCount.ToString());
                                        listView.Items.Add(item);
                                    }
                                    
                                    if (!hasData)
                                    {
                                        ListViewItem item = new ListViewItem("No ratings data available");
                                        listView.Items.Add(item);
                                    }
                                    
                                    decimal overallRating = totalReviews > 0 ? Math.Round(weightedRatingSum / totalReviews, 2) : 0;
                                    lblSummary.Text = $"Overall recruiter rating: {overallRating:F2} (based on {totalReviews} reviews)";
                                }
                            }
                            break;
                            
                        case "Overall Placement Statistics":
                            listView.Columns.Add("Metric", 300);
                            listView.Columns.Add("Value", 150);
                            listView.Columns.Add("Percentage", 150);
                            
                            // Get total student data
                            string placementQuery = @"
                                SELECT 
                                    COUNT(DISTINCT s.StudentID) AS TotalStudents,
                                    COUNT(DISTINCT bv.StudentID) AS ParticipatedStudents,
                                    SUM(CASE WHEN a.ApplicationStatus = 'Accepted' THEN 1 ELSE 0 END) AS HiredStudents
                                FROM Students s
                                LEFT JOIN BoothVisits bv ON s.StudentID = bv.StudentID
                                LEFT JOIN Applications a ON s.StudentID = a.StudentID";
                            
                            using (SqlCommand command = new SqlCommand(placementQuery, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        int totalStudents = Convert.ToInt32(reader["TotalStudents"]);
                                        int participatedStudents = Convert.ToInt32(reader["ParticipatedStudents"]);
                                        int hiredStudents = Convert.ToInt32(reader["HiredStudents"]);
                                        
                                        double participationRate = totalStudents > 0 ? (double)participatedStudents / totalStudents * 100 : 0;
                                        double placementRate = participatedStudents > 0 ? (double)hiredStudents / participatedStudents * 100 : 0;
                                        double overallRate = totalStudents > 0 ? (double)hiredStudents / totalStudents * 100 : 0;
                                        
                                        // Total students
                                        ListViewItem item1 = new ListViewItem("Total Registered Students");
                                        item1.SubItems.Add(totalStudents.ToString());
                                        item1.SubItems.Add("100%");
                                        listView.Items.Add(item1);
                                        
                                        // Participated students
                                        ListViewItem item2 = new ListViewItem("Students Who Participated in Job Fairs");
                                        item2.SubItems.Add(participatedStudents.ToString());
                                        item2.SubItems.Add($"{participationRate:F1}% of total");
                                        listView.Items.Add(item2);
                                        
                                        // Hired students
                                        ListViewItem item3 = new ListViewItem("Students Who Accepted Job Offers");
                                        item3.SubItems.Add(hiredStudents.ToString());
                                        item3.SubItems.Add($"{placementRate:F1}% of participants");
                                        listView.Items.Add(item3);
                                        
                                        // Overall placement rate
                                        ListViewItem item4 = new ListViewItem("Overall Placement Rate");
                                        item4.SubItems.Add(hiredStudents.ToString());
                                        item4.SubItems.Add($"{overallRate:F1}% of total");
                                        listView.Items.Add(item4);
                                        
                                        lblSummary.Text = $"Overall placement rate: {placementRate:F1}% ({hiredStudents} hired out of {participatedStudents} participants)";
                                    }
                                    else
                                    {
                                        ListViewItem item = new ListViewItem("No placement data available");
                                        listView.Items.Add(item);
                                    }
                                }
                            }
                            break;
                            
                        case "Placement Rates by Department":
                            listView.Columns.Add("Degree Program", 150);
                            listView.Columns.Add("Total Students", 120);
                            listView.Columns.Add("Participants", 120);
                            listView.Columns.Add("Placed", 80);
                            listView.Columns.Add("Placement Rate", 150);
                            
                            string deptPlacementQuery = @"
                                WITH DepartmentStats AS (
                                    SELECT 
                                        s.DegreeProgram,
                                        COUNT(DISTINCT s.StudentID) AS TotalStudents,
                                        COUNT(DISTINCT bv.StudentID) AS ParticipatedStudents,
                                        SUM(CASE WHEN a.ApplicationStatus = 'Accepted' THEN 1 ELSE 0 END) AS HiredStudents
                                    FROM Students s
                                    LEFT JOIN BoothVisits bv ON s.StudentID = bv.StudentID
                                    LEFT JOIN Applications a ON s.StudentID = a.StudentID
                                    GROUP BY s.DegreeProgram
                                )
                                SELECT 
                                    DegreeProgram,
                                    TotalStudents,
                                    ParticipatedStudents,
                                    HiredStudents,
                                    CASE 
                                        WHEN ParticipatedStudents > 0 THEN CAST((HiredStudents * 100.0) / ParticipatedStudents AS DECIMAL(5,1))
                                        ELSE 0 
                                    END AS PlacementRate
                                FROM DepartmentStats
                                ORDER BY PlacementRate DESC";
                            
                            using (SqlCommand command = new SqlCommand(deptPlacementQuery, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    bool hasData = false;
                                    int totalStudents = 0;
                                    int totalParticipants = 0;
                                    int totalPlaced = 0;
                                    
                                    while (reader.Read())
                                    {
                                        hasData = true;
                                        string dept = reader["DegreeProgram"].ToString();
                                        int students = Convert.ToInt32(reader["TotalStudents"]);
                                        int participants = Convert.ToInt32(reader["ParticipatedStudents"]);
                                        int placed = Convert.ToInt32(reader["HiredStudents"]);
                                        decimal rate = Convert.ToDecimal(reader["PlacementRate"]);
                                        
                                        totalStudents += students;
                                        totalParticipants += participants;
                                        totalPlaced += placed;
                                        
                                        ListViewItem item = new ListViewItem(dept);
                                        item.SubItems.Add(students.ToString());
                                        item.SubItems.Add(participants.ToString());
                                        item.SubItems.Add(placed.ToString());
                                        item.SubItems.Add($"{rate}%");
                                        listView.Items.Add(item);
                                    }
                                    
                                    if (!hasData)
                                    {
                                        ListViewItem item = new ListViewItem("No placement data available");
                                        listView.Items.Add(item);
                                    }
                                    else
                                    {
                                        // Add overall summary row
                                        decimal overallRate = totalParticipants > 0 ? Math.Round((decimal)totalPlaced / totalParticipants * 100, 1) : 0;
                                        
                                        ListViewItem summaryItem = new ListViewItem("OVERALL");
                                        summaryItem.Font = new Font(listView.Font, FontStyle.Bold);
                                        summaryItem.SubItems.Add(totalStudents.ToString());
                                        summaryItem.SubItems.Add(totalParticipants.ToString());
                                        summaryItem.SubItems.Add(totalPlaced.ToString());
                                        summaryItem.SubItems.Add($"{overallRate}%");
                                        listView.Items.Add(summaryItem);
                                    }
                                    
                                    if (totalParticipants > 0)
                                    {
                                        decimal averageRate = Math.Round((decimal)totalPlaced / totalParticipants * 100, 1);
                                        lblSummary.Text = $"Average placement rate across all departments: {averageRate}%";
                                    }
                                    else
                                    {
                                        lblSummary.Text = "No placement data available";
                                    }
                                }
                            }
                            break;
                            
                        case "Average Salary by Program":
                            listView.Columns.Add("Degree Program", 150);
                            listView.Columns.Add("Students Placed", 120);
                            listView.Columns.Add("Avg. Salary Range", 200);
                            listView.Columns.Add("Most Common Range", 200);
                            
                            string salaryQuery = @"
                                WITH SalaryStats AS (
                                    SELECT 
                                        s.DegreeProgram,
                                        COUNT(DISTINCT a.StudentID) AS PlacedStudents,
                                        jp.SalaryRange,
                                        COUNT(jp.SalaryRange) AS RangeCount
                                    FROM Students s
                                    JOIN Applications a ON s.StudentID = a.StudentID AND a.ApplicationStatus = 'Accepted'
                                    JOIN JobPostings jp ON a.JobID = jp.JobID
                                    GROUP BY s.DegreeProgram, jp.SalaryRange
                                ),
                                RankedSalaries AS (
                                    SELECT 
                                        DegreeProgram,
                                        SalaryRange,
                                        RangeCount,
                                        ROW_NUMBER() OVER (PARTITION BY DegreeProgram ORDER BY RangeCount DESC) as RankNum
                                    FROM SalaryStats
                                ),
                                AggregatedStats AS (
                                    SELECT 
                                        ss.DegreeProgram,
                                        SUM(ss.PlacedStudents) AS TotalPlaced,
                                        STRING_AGG(ss.SalaryRange, ', ') AS AllSalaryRanges,
                                        (SELECT TOP 1 SalaryRange FROM RankedSalaries rs WHERE rs.DegreeProgram = ss.DegreeProgram AND RankNum = 1) AS MostCommonRange
                                    FROM SalaryStats ss
                                    GROUP BY ss.DegreeProgram
                                )
                                SELECT *
                                FROM AggregatedStats
                                ORDER BY TotalPlaced DESC";
                            
                            using (SqlCommand command = new SqlCommand(salaryQuery, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    bool hasData = false;
                                    int totalStudentsPlaced = 0;
                                    string commonSalaryRange = "N/A";
                                    
                                    while (reader.Read())
                                    {
                                        hasData = true;
                                        string dept = reader["DegreeProgram"].ToString();
                                        int placed = Convert.ToInt32(reader["TotalPlaced"]);
                                        string salaryRanges = reader["AllSalaryRanges"].ToString();
                                        string mostCommonRange = reader["MostCommonRange"].ToString();
                                        
                                        totalStudentsPlaced += placed;
                                        
                                        // Set the most common range for the very first record (highest placed count)
                                        if (commonSalaryRange == "N/A")
                                        {
                                            commonSalaryRange = mostCommonRange;
                                        }
                                        
                                        ListViewItem item = new ListViewItem(dept);
                                        item.SubItems.Add(placed.ToString());
                                        item.SubItems.Add(salaryRanges);
                                        item.SubItems.Add(mostCommonRange);
                                        listView.Items.Add(item);
                                    }
                                    
                                    if (!hasData)
                                    {
                                        ListViewItem item = new ListViewItem("No salary data available");
                                        listView.Items.Add(item);
                                        lblSummary.Text = "No salary data available for students";
                                    }
                                    else
                                    {
                                        lblSummary.Text = $"Total students placed: {totalStudentsPlaced}, Most common salary range: {commonSalaryRange}";
                                    }
                                }
                            }
                            break;
                            
                        case "Booth Traffic Analysis":
                            listView.Columns.Add("Company", 200);
                            listView.Columns.Add("Booth Number", 120);
                            listView.Columns.Add("Total Visits", 100);
                            listView.Columns.Add("Unique Students", 120);
                            listView.Columns.Add("Avg. Time (min)", 120);
                            
                            string boothTrafficQuery = @"
                                WITH BoothStats AS (
                                    SELECT 
                                        c.CompanyName,
                                        bv.BoothNumber,
                                        COUNT(bv.VisitID) AS TotalVisits,
                                        COUNT(DISTINCT bv.StudentID) AS UniqueStudents,
                                        AVG(DATEDIFF(MINUTE, bv.CheckInTime, DATEADD(MINUTE, 15, bv.CheckInTime))) AS AvgTimeSpent
                                    FROM BoothVisits bv
                                    JOIN Companies c ON bv.CompanyID = c.CompanyID
                                    WHERE bv.CheckInTime IS NOT NULL
                                    GROUP BY c.CompanyName, bv.BoothNumber
                                )
                                SELECT *
                                FROM BoothStats
                                ORDER BY TotalVisits DESC";
                            
                            using (SqlCommand command = new SqlCommand(boothTrafficQuery, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    bool hasData = false;
                                    int totalVisits = 0;
                                    int totalUniqueStudents = 0;
                                    decimal totalAvgTime = 0;
                                    int boothCount = 0;
                                    
                                    while (reader.Read())
                                    {
                                        hasData = true;
                                        boothCount++;
                                        
                                        string company = reader["CompanyName"].ToString();
                                        string boothNumber = reader["BoothNumber"].ToString();
                                        int visits = Convert.ToInt32(reader["TotalVisits"]);
                                        int uniqueStudents = Convert.ToInt32(reader["UniqueStudents"]);
                                        decimal avgTime = Math.Round(Convert.ToDecimal(reader["AvgTimeSpent"]), 1);
                                        
                                        totalVisits += visits;
                                        totalUniqueStudents += uniqueStudents;
                                        totalAvgTime += avgTime;
                                        
                                        ListViewItem item = new ListViewItem(company);
                                        item.SubItems.Add(boothNumber);
                                        item.SubItems.Add(visits.ToString());
                                        item.SubItems.Add(uniqueStudents.ToString());
                                        item.SubItems.Add(avgTime.ToString());
                                        listView.Items.Add(item);
                                    }
                                    
                                    if (!hasData)
                                    {
                                        ListViewItem item = new ListViewItem("No booth traffic data available");
                                        listView.Items.Add(item);
                                    }
                                    else
                                    {
                                        decimal systemAvgTime = boothCount > 0 ? Math.Round(totalAvgTime / boothCount, 1) : 0;
                                        
                                        // Add summary row
                                        ListViewItem summaryItem = new ListViewItem("TOTALS");
                                        summaryItem.Font = new Font(listView.Font, FontStyle.Bold);
                                        summaryItem.SubItems.Add(boothCount.ToString());
                                        summaryItem.SubItems.Add(totalVisits.ToString());
                                        summaryItem.SubItems.Add(totalUniqueStudents.ToString());
                                        summaryItem.SubItems.Add(systemAvgTime.ToString());
                                        listView.Items.Add(summaryItem);
                                        
                                        lblSummary.Text = $"Total visits across all booths: {totalVisits}, Average time spent per booth: {systemAvgTime} minutes";
                                    }
                                }
                            }
                            break;
                            
                        case "Peak Participation Hours":
                            listView.Columns.Add("Hour of Day", 120);
                            listView.Columns.Add("Total Check-ins", 120);
                            listView.Columns.Add("Percentage", 100);
                            listView.Columns.Add("Booth Visits", 120);
                            listView.Columns.Add("General Check-ins", 150);
                            
                            string peakHoursQuery = @"
                                WITH HourlyStats AS (
                                    SELECT 
                                        DATEPART(HOUR, CheckInTime) AS HourOfDay,
                                        COUNT(*) AS TotalCheckins,
                                        SUM(CASE WHEN CompanyID IS NOT NULL THEN 1 ELSE 0 END) AS BoothVisits,
                                        SUM(CASE WHEN CompanyID IS NULL THEN 1 ELSE 0 END) AS GeneralCheckins
                                    FROM BoothVisits
                                    WHERE CheckInTime IS NOT NULL
                                    GROUP BY DATEPART(HOUR, CheckInTime)
                                )
                                SELECT 
                                    HourOfDay,
                                    TotalCheckins,
                                    BoothVisits,
                                    GeneralCheckins,
                                    CAST(TotalCheckins * 100.0 / (SELECT SUM(TotalCheckins) FROM HourlyStats) AS DECIMAL(5,1)) AS CheckinPercentage
                                FROM HourlyStats
                                ORDER BY TotalCheckins DESC";
                            
                            using (SqlCommand command = new SqlCommand(peakHoursQuery, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    bool hasData = false;
                                    int totalCheckins = 0;
                                    int peakHour = 0;
                                    int peakCount = 0;
                                    
                                    while (reader.Read())
                                    {
                                        hasData = true;
                                        int hour = Convert.ToInt32(reader["HourOfDay"]);
                                        int checkins = Convert.ToInt32(reader["TotalCheckins"]);
                                        int boothVisits = Convert.ToInt32(reader["BoothVisits"]);
                                        int generalCheckins = Convert.ToInt32(reader["GeneralCheckins"]);
                                        decimal percentage = Convert.ToDecimal(reader["CheckinPercentage"]);
                                        
                                        // Track peak hour
                                        if (checkins > peakCount)
                                        {
                                            peakHour = hour;
                                            peakCount = checkins;
                                        }
                                        
                                        totalCheckins += checkins;
                                        
                                        // Format the hour as a time range (e.g., "9:00 - 10:00")
                                        string hourDisplay = $"{hour:D2}:00 - {(hour + 1) % 24:D2}:00";
                                        
                                        ListViewItem item = new ListViewItem(hourDisplay);
                                        item.SubItems.Add(checkins.ToString());
                                        item.SubItems.Add($"{percentage}%");
                                        item.SubItems.Add(boothVisits.ToString());
                                        item.SubItems.Add(generalCheckins.ToString());
                                        listView.Items.Add(item);
                                    }
                                    
                                    if (!hasData)
                                    {
                                        ListViewItem item = new ListViewItem("No check-in data available");
                                        listView.Items.Add(item);
                                    }
                                    else
                                    {
                                        string peakHourDisplay = $"{peakHour:D2}:00 - {(peakHour + 1) % 24:D2}:00";
                                        lblSummary.Text = $"Peak participation hour: {peakHourDisplay} with {peakCount} check-ins ({(decimal)peakCount / totalCheckins * 100:F1}% of total)";
                                    }
                                }
                            }
                            break;
                            
                        case "Resource Usage Metrics":
                            listView.Columns.Add("Resource Type", 200);
                            listView.Columns.Add("Total Allocated", 120);
                            listView.Columns.Add("Used", 100);
                            listView.Columns.Add("Utilization Rate", 130);
                            listView.Columns.Add("Details", 200);
                            
                            // First, add booth space utilization
                            string boothSpaceQuery = @"
                                SELECT 
                                    COUNT(DISTINCT bv.BoothNumber) AS AllocatedBooths,
                                    COUNT(DISTINCT CASE WHEN bv.CheckInTime IS NOT NULL THEN bv.BoothNumber END) AS UsedBooths,
                                    CASE 
                                        WHEN COUNT(DISTINCT bv.BoothNumber) > 0 
                                        THEN CAST(COUNT(DISTINCT CASE WHEN bv.CheckInTime IS NOT NULL THEN bv.BoothNumber END) * 100.0 / 
                                             COUNT(DISTINCT bv.BoothNumber) AS DECIMAL(5,1))
                                        ELSE 0
                                    END AS UtilizationRate
                                FROM BoothVisits bv
                                WHERE bv.BoothNumber IS NOT NULL";
                            
                            using (SqlCommand command = new SqlCommand(boothSpaceQuery, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        int allocatedBooths = Convert.ToInt32(reader["AllocatedBooths"]);
                                        int usedBooths = Convert.ToInt32(reader["UsedBooths"]);
                                        decimal utilizationRate = Convert.ToDecimal(reader["UtilizationRate"]);
                                        
                                        ListViewItem item = new ListViewItem("Booth Space");
                                        item.SubItems.Add(allocatedBooths.ToString());
                                        item.SubItems.Add(usedBooths.ToString());
                                        item.SubItems.Add($"{utilizationRate}%");
                                        item.SubItems.Add($"{usedBooths} of {allocatedBooths} booths had visitor activity");
                                        listView.Items.Add(item);
                                    }
                                }
                            }
                            
                            // Then add coordinator allocation
                            string coordinatorQuery = @"
                                WITH CoordinatorStats AS (
                                    SELECT 
                                        COUNT(DISTINCT CoordinatorID) AS TotalCoordinators,
                                        COUNT(DISTINCT CASE WHEN AssignedFairID IS NOT NULL THEN CoordinatorID END) AS AssignedCoordinators
                                    FROM BoothCoordinators
                                )
                                SELECT 
                                    TotalCoordinators,
                                    AssignedCoordinators,
                                    CASE 
                                        WHEN TotalCoordinators > 0 
                                        THEN CAST(AssignedCoordinators * 100.0 / TotalCoordinators AS DECIMAL(5,1))
                                        ELSE 0
                                    END AS UtilizationRate
                                FROM CoordinatorStats";
                            
                            using (SqlCommand command = new SqlCommand(coordinatorQuery, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        int totalCoordinators = Convert.ToInt32(reader["TotalCoordinators"]);
                                        int assignedCoordinators = Convert.ToInt32(reader["AssignedCoordinators"]);
                                        decimal utilizationRate = Convert.ToDecimal(reader["UtilizationRate"]);
                                        
                                        ListViewItem item = new ListViewItem("Coordinator Time");
                                        item.SubItems.Add(totalCoordinators.ToString());
                                        item.SubItems.Add(assignedCoordinators.ToString());
                                        item.SubItems.Add($"{utilizationRate}%");
                                        item.SubItems.Add($"{assignedCoordinators} of {totalCoordinators} coordinators assigned to fairs");
                                        listView.Items.Add(item);
                                    }
                                }
                            }
                            
                            // Finally, add timeslot usage data
                            string timeSlotQuery = @"
                                SELECT 
                                    jf.EventTitle,
                                    DATEDIFF(HOUR, jf.StartTime, jf.EndTime) AS TotalHours,
                                    COUNT(DISTINCT DATEPART(HOUR, bv.CheckInTime)) AS ActiveHours,
                                    CASE 
                                        WHEN DATEDIFF(HOUR, jf.StartTime, jf.EndTime) > 0 
                                        THEN CAST(COUNT(DISTINCT DATEPART(HOUR, bv.CheckInTime)) * 100.0 / 
                                             DATEDIFF(HOUR, jf.StartTime, jf.EndTime) AS DECIMAL(5,1))
                                        ELSE 0
                                    END AS TimeUtilization
                                FROM JobFairEvents jf
                                LEFT JOIN BoothVisits bv ON jf.JobFairID = bv.JobFairID AND bv.CheckInTime IS NOT NULL
                                GROUP BY jf.EventTitle, jf.StartTime, jf.EndTime";
                            
                            using (SqlCommand command = new SqlCommand(timeSlotQuery, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    bool hasData = false;
                                    while (reader.Read())
                                    {
                                        hasData = true;
                                        string eventTitle = reader["EventTitle"].ToString();
                                        int totalHours = Convert.ToInt32(reader["TotalHours"]);
                                        int activeHours = Convert.ToInt32(reader["ActiveHours"]);
                                        decimal utilization = Convert.ToDecimal(reader["TimeUtilization"]);
                                        
                                        ListViewItem item = new ListViewItem("Time Slots");
                                        item.SubItems.Add(totalHours.ToString());
                                        item.SubItems.Add(activeHours.ToString());
                                        item.SubItems.Add($"{utilization}%");
                                        item.SubItems.Add($"{activeHours} of {totalHours} hours had activity for {eventTitle}");
                                        listView.Items.Add(item);
                                    }
                                    
                                    if (!hasData)
                                    {
                                        ListViewItem item = new ListViewItem("Time Slots");
                                        item.SubItems.Add("N/A");
                                        item.SubItems.Add("N/A");
                                        item.SubItems.Add("N/A");
                                        item.SubItems.Add("No time slot data available");
                                        listView.Items.Add(item);
                                    }
                                }
                            }
                            
                            // Set summary text
                            lblSummary.Text = "Resource utilization analysis for job fairs";
                            break;
                    }
                    
                    panel2.Controls.Add(listView);
                    panel2.Controls.Add(lblSummary);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message,
                    "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 