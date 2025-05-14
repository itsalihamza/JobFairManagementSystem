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
    public partial class CoordinatorDashboard : Form
    {
        private int userId;
        private int coordinatorId;
        private int assignedFairId;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";
        
        public CoordinatorDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            
            // Get coordinator info and assigned fair
            GetCoordinatorInfo();
            
            // Load real data from database
            LoadData();
        }

        private void GetCoordinatorInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            c.CoordinatorID,
                            c.AssignedFairID,
                            u.FullName,
                            jf.EventTitle
                        FROM BoothCoordinators c
                        JOIN Users u ON c.UserID = u.UserID
                        LEFT JOIN JobFairEvents jf ON c.AssignedFairID = jf.JobFairID
                        WHERE c.UserID = @UserID";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                coordinatorId = Convert.ToInt32(reader["CoordinatorID"]);
                                
                                if (reader["AssignedFairID"] != DBNull.Value)
                                {
                                    assignedFairId = Convert.ToInt32(reader["AssignedFairID"]);
                                    lblWelcome.Text = $"Welcome, {reader["FullName"]}";
                                    lblAssignedFair.Text = $"Assigned Fair: {reader["EventTitle"]}";
                                }
                                else
                                {
                                    lblWelcome.Text = $"Welcome, {reader["FullName"]}";
                                    lblAssignedFair.Text = "No job fair assigned yet";
                                    MessageBox.Show("You have not been assigned to a job fair yet. Please contact the administrator.",
                                        "No Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Coordinator profile not found. Please contact the administrator.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving coordinator information: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            if (assignedFairId > 0)
            {
                LoadJobFairs();
                LoadCompanyRegistrations();
                LoadStudentRegistrations();
                LoadAttendance();
            }
            else
            {
                // Clear all data grids if no fair is assigned
                dgvJobFairs.Rows.Clear();
                dgvCompanyRegistrations.Rows.Clear();
                dgvStudentRegistrations.Rows.Clear();
                dgvAttendance.Rows.Clear();
                
                MessageBox.Show("No job fair is currently assigned to you. Please contact the administrator.",
                    "No Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            JobFairID,
                            EventTitle,
                            CONVERT(VARCHAR(10), EventDate, 101) AS EventDateFormatted,
                            Venue,
                            CASE 
                                WHEN EventDate > GETDATE() THEN 'Upcoming' 
                                WHEN EventDate = CONVERT(DATE, GETDATE()) THEN 'Active'
                                ELSE 'Completed' 
                            END AS Status
                        FROM JobFairEvents
                        WHERE JobFairID = @AssignedFairID";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AssignedFairID", assignedFairId);
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
        
        private void LoadCompanyRegistrations()
        {
            try
            {
                dgvCompanyRegistrations.Rows.Clear();
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            c.CompanyID,
                            c.CompanyName,
                            jf.EventTitle,
                            COALESCE(bv.BoothNumber, 'Not Assigned') AS BoothNumber,
                            CASE 
                                WHEN bv.BoothNumber IS NOT NULL THEN 'Confirmed' 
                                ELSE 'Pending' 
                            END AS Status
                        FROM Companies c
                        CROSS JOIN JobFairEvents jf 
                        LEFT JOIN BoothVisits bv ON c.CompanyID = bv.CompanyID AND bv.JobFairID = jf.JobFairID
                        WHERE jf.JobFairID = @JobFairID
                        AND c.CompanyID IN (
                            SELECT DISTINCT jp.CompanyID
                            FROM JobPostings jp
                        )
                        ORDER BY c.CompanyName";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JobFairID", assignedFairId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvCompanyRegistrations.Rows.Add(
                                    reader["CompanyID"].ToString(),
                                    reader["CompanyName"].ToString(),
                                    reader["EventTitle"].ToString(),
                                    reader["BoothNumber"].ToString(),
                                    reader["Status"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading company registrations: " + ex.Message + 
                    "\n\nThis might be due to missing columns in the database. Please contact your administrator.",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Try to continue with other functions
                dgvCompanyRegistrations.Rows.Clear();
            }
        }
        
        private void LoadStudentRegistrations()
        {
            try
            {
                dgvStudentRegistrations.Rows.Clear();
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            s.StudentID,
                            u.FullName,
                            s.FAST_ID,
                            jf.EventTitle,
                            CASE 
                                WHEN bv.CheckInTime IS NULL THEN 'Registered' 
                                ELSE 'Checked In' 
                            END AS Status
                        FROM Students s
                        JOIN Users u ON s.UserID = u.UserID
                        JOIN BoothVisits bv ON s.StudentID = bv.StudentID
                        JOIN JobFairEvents jf ON bv.JobFairID = jf.JobFairID
                        WHERE bv.JobFairID = @JobFairID";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JobFairID", assignedFairId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvStudentRegistrations.Rows.Add(
                                    reader["StudentID"].ToString(),
                                    reader["FullName"].ToString(),
                                    reader["FAST_ID"].ToString(),
                                    reader["EventTitle"].ToString(),
                                    reader["Status"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student registrations: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadAttendance()
        {
            try
            {
                dgvAttendance.Rows.Clear();
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            bv.VisitID,
                            u.FullName,
                            s.FAST_ID,
                            c.CompanyName,
                            CONVERT(VARCHAR(20), bv.CheckInTime, 120) AS CheckInTimeFormatted
                        FROM BoothVisits bv
                        JOIN Students s ON bv.StudentID = s.StudentID
                        JOIN Users u ON s.UserID = u.UserID
                        LEFT JOIN Companies c ON bv.CompanyID = c.CompanyID
                        WHERE bv.JobFairID = @JobFairID
                        AND bv.CheckInTime IS NOT NULL
                        ORDER BY bv.CheckInTime DESC";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JobFairID", assignedFairId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvAttendance.Rows.Add(
                                    reader["VisitID"].ToString(),
                                    reader["FullName"].ToString(),
                                    reader["FAST_ID"].ToString(),
                                    reader["CompanyName"] == DBNull.Value ? "General Check-in" : reader["CompanyName"].ToString(),
                                    reader["CheckInTimeFormatted"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance data: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAssignBooth_Click(object sender, EventArgs e)
        {
            if (dgvCompanyRegistrations.SelectedRows.Count > 0)
            {
                string companyId = dgvCompanyRegistrations.SelectedRows[0].Cells[0].Value.ToString();
                string companyName = dgvCompanyRegistrations.SelectedRows[0].Cells[1].Value.ToString();
                
                // Create a simple input dialog for booth assignment
                using (var form = new Form())
                {
                    form.Text = "Assign Booth";
                    form.Size = new Size(300, 180);
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.FormBorderStyle = FormBorderStyle.FixedDialog;
                    form.MaximizeBox = false;
                    form.MinimizeBox = false;

                    var label = new Label() { Text = $"Assign booth for {companyName}:", Left = 20, Top = 20, Width = 240 };
                    var textBox = new TextBox() { Left = 20, Top = 50, Width = 240, Text = "Booth " };

                    var buttonOk = new Button() { 
                        Text = "Assign", 
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
                    form.Controls.Add(textBox);
                    form.Controls.Add(buttonOk);
                    form.Controls.Add(buttonCancel);

                    form.AcceptButton = buttonOk;
                    form.CancelButton = buttonCancel;

                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string boothNumber = textBox.Text.Trim();
                        
                        try
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                
                                // Check if a BoothVisits record exists for this company and job fair
                                string checkQuery = @"
                                    SELECT COUNT(*) 
                                    FROM BoothVisits 
                                    WHERE CompanyID = @CompanyID 
                                    AND JobFairID = @JobFairID";
                                
                                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                                {
                                    checkCommand.Parameters.AddWithValue("@CompanyID", companyId);
                                    checkCommand.Parameters.AddWithValue("@JobFairID", assignedFairId);
                                    
                                    int recordCount = (int)checkCommand.ExecuteScalar();
                                    
                                    string query;
                                    if (recordCount > 0)
                                    {
                                        // Update existing record
                                        query = @"
                                            UPDATE BoothVisits 
                                            SET BoothNumber = @BoothNumber
                                            WHERE CompanyID = @CompanyID 
                                            AND JobFairID = @JobFairID";
                                    }
                                    else
                                    {
                                        // Insert new record
                                        query = @"
                                            INSERT INTO BoothVisits (CompanyID, JobFairID, BoothNumber)
                                            VALUES (@CompanyID, @JobFairID, @BoothNumber)";
                                    }
                                    
                                    using (SqlCommand command = new SqlCommand(query, connection))
                                    {
                                        command.Parameters.AddWithValue("@CompanyID", companyId);
                                        command.Parameters.AddWithValue("@JobFairID", assignedFairId);
                                        command.Parameters.AddWithValue("@BoothNumber", boothNumber);
                                        
                                        command.ExecuteNonQuery();
                                        
                                        // Update UI
                                        dgvCompanyRegistrations.SelectedRows[0].Cells[3].Value = boothNumber;
                                        dgvCompanyRegistrations.SelectedRows[0].Cells[4].Value = "Confirmed";
                                        
                                        MessageBox.Show($"{companyName} has been assigned to {boothNumber}.", 
                                            "Booth Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error assigning booth: " + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a company registration first.", 
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewFairDetails_Click(object sender, EventArgs e)
        {
            if (dgvJobFairs.SelectedRows.Count > 0)
            {
                string fairId = dgvJobFairs.SelectedRows[0].Cells[0].Value.ToString();
                string fairName = dgvJobFairs.SelectedRows[0].Cells[1].Value.ToString();
                
                // Show fair details in a new form
                JobFairDetailsForm fairDetailsForm = new JobFairDetailsForm(fairId, fairName);
                fairDetailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a job fair first.", 
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSendReminders_Click(object sender, EventArgs e)
        {
            if (assignedFairId <= 0)
            {
                MessageBox.Show("No job fair assigned. Please contact the administrator.",
                    "No Assignment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                int studentReminders = 0;
                int companyReminders = 0;
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // In a real application, this would send emails or notifications
                    // For now, we'll update the last reminder date in the BoothVisits table
                    
                    // Update students
                    string studentQuery = @"
                        UPDATE BoothVisits
                        SET LastReminderDate = GETDATE()
                        WHERE JobFairID = @JobFairID
                        AND StudentID IS NOT NULL";
                    
                    using (SqlCommand command = new SqlCommand(studentQuery, connection))
                    {
                        command.Parameters.AddWithValue("@JobFairID", assignedFairId);
                        studentReminders = command.ExecuteNonQuery();
                    }
                    
                    // Update companies
                    string companyQuery = @"
                        UPDATE BoothVisits
                        SET LastReminderDate = GETDATE()
                        WHERE JobFairID = @JobFairID
                        AND CompanyID IS NOT NULL";
                    
                    using (SqlCommand command = new SqlCommand(companyQuery, connection))
                    {
                        command.Parameters.AddWithValue("@JobFairID", assignedFairId);
                        companyReminders = command.ExecuteNonQuery();
                    }
                }
                
                MessageBox.Show($"Reminders have been sent to {studentReminders} students and {companyReminders} companies for the upcoming job fair.",
                    "Reminders Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Refresh the data
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending reminders: " + ex.Message + 
                    "\n\nThis might be due to missing columns in the database. Please check if the LastReminderDate column exists.",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateAttendanceList_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.Rows.Count > 0)
            {
                // Create a SaveFileDialog to let the user choose where to save the file
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveDialog.FileName = "Attendance_List_" + DateTime.Now.ToString("yyyyMMdd");
                
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Export the DataGridView to CSV
                        using (StreamWriter sw = new StreamWriter(saveDialog.FileName))
                        {
                            // Write the headers
                            List<string> headers = new List<string>();
                            foreach (DataGridViewColumn col in dgvAttendance.Columns)
                            {
                                if (col.Visible)
                                {
                                    headers.Add(col.HeaderText);
                                }
                            }
                            sw.WriteLine(string.Join(",", headers));
                            
                            // Write the rows
                            foreach (DataGridViewRow row in dgvAttendance.Rows)
                            {
                                List<string> cells = new List<string>();
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (dgvAttendance.Columns[cell.ColumnIndex].Visible)
                                    {
                                        if (cell.Value != null)
                                        {
                                            string value = cell.Value.ToString();
                                            // Escape commas and quotes
                                            if (value.Contains(",") || value.Contains("\""))
                                            {
                                                cells.Add($"\"{value.Replace("\"", "\"\"")}\"");
                                            }
                                            else
                                            {
                                                cells.Add(value);
                                            }
                                        }
                                        else
                                        {
                                            cells.Add("");
                                        }
                                    }
                                }
                                sw.WriteLine(string.Join(",", cells));
                            }
                        }
                        
                        MessageBox.Show("Attendance list has been generated and saved.", 
                            "Attendance List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving attendance list: " + ex.Message,
                            "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No attendance data to export.", 
                    "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Refresh data if needed when tab changes
            switch (tabControl1.SelectedIndex)
            {
                case 0: // Job Fairs tab
                    LoadJobFairs();
                    break;
                case 1: // Company Registrations tab
                    LoadCompanyRegistrations();
                    break;
                case 2: // Student Registrations tab
                    LoadStudentRegistrations();
                    break;
                case 3: // Attendance tab
                    LoadAttendance();
                    break;
            }
        }

        private void CoordinatorDashboard_Load(object sender, EventArgs e)
        {
            // Already loaded in constructor
        }
        
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string fastId = txtFastId.Text.Trim();
            
            if (string.IsNullOrEmpty(fastId))
            {
                MessageBox.Show("Please enter a FAST ID to check in.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFastId.Focus();
                return;
            }
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Find the student by FAST ID
                    string findStudentQuery = @"
                        SELECT s.StudentID, u.FullName 
                        FROM Students s
                        JOIN Users u ON s.UserID = u.UserID
                        WHERE s.FAST_ID = @FAST_ID";
                    
                    using (SqlCommand findCommand = new SqlCommand(findStudentQuery, connection))
                    {
                        findCommand.Parameters.AddWithValue("@FAST_ID", fastId);
                        using (SqlDataReader reader = findCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int studentId = Convert.ToInt32(reader["StudentID"]);
                                string studentName = reader["FullName"].ToString();
                                reader.Close();
                                
                                // Check if student is registered for this fair
                                string checkRegistrationQuery = @"
                                    SELECT COUNT(*) 
                                    FROM BoothVisits 
                                    WHERE StudentID = @StudentID 
                                    AND JobFairID = @JobFairID";
                                
                                using (SqlCommand checkCommand = new SqlCommand(checkRegistrationQuery, connection))
                                {
                                    checkCommand.Parameters.AddWithValue("@StudentID", studentId);
                                    checkCommand.Parameters.AddWithValue("@JobFairID", assignedFairId);
                                    
                                    int registrationCount = (int)checkCommand.ExecuteScalar();
                                    
                                    if (registrationCount == 0)
                                    {
                                        // Student not registered, let's register them on the spot
                                        string registerQuery = @"
                                            INSERT INTO BoothVisits (StudentID, CompanyID, JobFairID, CheckInTime)
                                            VALUES (@StudentID, NULL, @JobFairID, @CheckInTime)";
                                        
                                        using (SqlCommand registerCommand = new SqlCommand(registerQuery, connection))
                                        {
                                            registerCommand.Parameters.AddWithValue("@StudentID", studentId);
                                            registerCommand.Parameters.AddWithValue("@JobFairID", assignedFairId);
                                            registerCommand.Parameters.AddWithValue("@CheckInTime", DateTime.Now);
                                            
                                            registerCommand.ExecuteNonQuery();
                                            
                                            MessageBox.Show($"{studentName} has been registered and checked in for the job fair.",
                                                "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            
                                            txtFastId.Clear();
                                            txtFastId.Focus();
                                            
                                            // Refresh the student list and attendance
                                            LoadStudentRegistrations();
                                            LoadAttendance();
                                            
                                            return;
                                        }
                                    }
                                    
                                    // Check if already checked in
                                    string checkCheckedInQuery = @"
                                        SELECT COUNT(*) 
                                        FROM BoothVisits 
                                        WHERE StudentID = @StudentID 
                                        AND JobFairID = @JobFairID 
                                        AND CheckInTime IS NOT NULL";
                                    
                                    using (SqlCommand checkCheckedInCommand = new SqlCommand(checkCheckedInQuery, connection))
                                    {
                                        checkCheckedInCommand.Parameters.AddWithValue("@StudentID", studentId);
                                        checkCheckedInCommand.Parameters.AddWithValue("@JobFairID", assignedFairId);
                                        
                                        int checkedInCount = (int)checkCheckedInCommand.ExecuteScalar();
                                        
                                        if (checkedInCount > 0)
                                        {
                                            MessageBox.Show($"{studentName} has already been checked in for this job fair.",
                                                "Already Checked In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            txtFastId.Clear();
                                            txtFastId.Focus();
                                            return;
                                        }
                                    }
                                    
                                    // Update check-in time
                                    string updateQuery = @"
                                        UPDATE BoothVisits 
                                        SET CheckInTime = @CheckInTime 
                                        WHERE StudentID = @StudentID 
                                        AND JobFairID = @JobFairID";
                                    
                                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@StudentID", studentId);
                                        updateCommand.Parameters.AddWithValue("@JobFairID", assignedFairId);
                                        updateCommand.Parameters.AddWithValue("@CheckInTime", DateTime.Now);
                                        
                                        updateCommand.ExecuteNonQuery();
                                        
                                        MessageBox.Show($"{studentName} has been successfully checked in!",
                                            "Check-in Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        
                                        txtFastId.Clear();
                                        txtFastId.Focus();
                                        
                                        // Refresh the student list and attendance
                                        LoadStudentRegistrations();
                                        LoadAttendance();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Student not found with the provided FAST ID. Please check and try again.",
                                    "Student Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtFastId.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking in student: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnBoothCheckin_Click(object sender, EventArgs e)
        {
            // First, make sure a company is selected
            if (dgvCompanyRegistrations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a company booth first.",
                    "No Booth Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string companyId = dgvCompanyRegistrations.SelectedRows[0].Cells[0].Value.ToString();
            string companyName = dgvCompanyRegistrations.SelectedRows[0].Cells[1].Value.ToString();
            string fastId = txtBoothFastId.Text.Trim();
            
            if (string.IsNullOrEmpty(fastId))
            {
                MessageBox.Show("Please enter a FAST ID to check in.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoothFastId.Focus();
                return;
            }
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Find the student by FAST ID
                    string findStudentQuery = @"
                        SELECT s.StudentID, u.FullName 
                        FROM Students s
                        JOIN Users u ON s.UserID = u.UserID
                        WHERE s.FAST_ID = @FAST_ID";
                    
                    using (SqlCommand findCommand = new SqlCommand(findStudentQuery, connection))
                    {
                        findCommand.Parameters.AddWithValue("@FAST_ID", fastId);
                        using (SqlDataReader reader = findCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int studentId = Convert.ToInt32(reader["StudentID"]);
                                string studentName = reader["FullName"].ToString();
                                reader.Close();
                                
                                // Log the booth visit
                                string insertQuery = @"
                                    INSERT INTO BoothVisits (StudentID, CompanyID, JobFairID, CheckInTime)
                                    VALUES (@StudentID, @CompanyID, @JobFairID, @CheckInTime)";
                                
                                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@StudentID", studentId);
                                    insertCommand.Parameters.AddWithValue("@CompanyID", companyId);
                                    insertCommand.Parameters.AddWithValue("@JobFairID", assignedFairId);
                                    insertCommand.Parameters.AddWithValue("@CheckInTime", DateTime.Now);
                                    
                                    insertCommand.ExecuteNonQuery();
                                    
                                    MessageBox.Show($"{studentName} has been checked in at {companyName} booth!",
                                        "Booth Visit Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
                                    txtBoothFastId.Clear();
                                    txtBoothFastId.Focus();
                                    
                                    // Refresh the attendance data
                                    LoadAttendance();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Student not found with the provided FAST ID. Please check and try again.",
                                    "Student Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtBoothFastId.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording booth visit: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 