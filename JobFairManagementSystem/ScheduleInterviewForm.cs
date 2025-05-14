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
    public partial class ScheduleInterviewForm : Form
    {
        private string applicationId;
        private string studentName;
        private string jobTitle;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";

        public ScheduleInterviewForm(string applicationId, string studentName, string jobTitle)
        {
            InitializeComponent();
            this.applicationId = applicationId;
            this.studentName = studentName;
            this.jobTitle = jobTitle;
            
            lblStudentNameValue.Text = studentName;
            lblJobTitleValue.Text = jobTitle;
            
            // Set the minimum date to tomorrow
            dtpInterviewDate.MinDate = DateTime.Now.AddDays(1);
            
            // Default values
            dtpInterviewDate.Value = DateTime.Now.AddDays(3);
            dtpInterviewTime.Value = DateTime.Today.AddHours(10);
            cmbInterviewType.SelectedIndex = 0; // Online
            cmbDuration.SelectedIndex = 1; // 30 minutes
            
            // Load application information
            LoadApplicationInfo();
        }
        
        private void LoadApplicationInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Check if interview already exists
                    string checkQuery = @"
                        SELECT 
                            InterviewID,
                            CONVERT(VARCHAR(10), InterviewDate, 101) AS InterviewDateFormatted,
                            CONVERT(VARCHAR(10), StartTime, 108) AS StartTimeFormatted,
                            CONVERT(VARCHAR(10), EndTime, 108) AS EndTimeFormatted
                        FROM Interviews
                        WHERE ApplicationID = @ApplicationID";
                    
                    using (SqlCommand command = new SqlCommand(checkQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", applicationId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Interview already exists
                                string interviewDate = reader["InterviewDateFormatted"].ToString();
                                string startTime = reader["StartTimeFormatted"].ToString();
                                string endTime = reader["EndTimeFormatted"].ToString();
                                
                                MessageBox.Show($"An interview is already scheduled for this application on {interviewDate} from {startTime} to {endTime}. " +
                                    "You can update the existing interview or schedule a new one.",
                                    "Interview Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    
                    // Update application status if it's "Pending"
                    string updateQuery = @"
                        UPDATE Applications
                        SET ApplicationStatus = 'Shortlisted'
                        WHERE ApplicationID = @ApplicationID
                        AND ApplicationStatus = 'Pending'";
                    
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@ApplicationID", applicationId);
                        updateCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading application information: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            // Calculate expected end time based on duration selection
            DateTime startTime = dtpInterviewTime.Value;
            DateTime endTime = startTime;
            
            switch(cmbDuration.SelectedIndex)
            {
                case 0: // 15 minutes
                    endTime = startTime.AddMinutes(15);
                    break;
                case 1: // 30 minutes
                    endTime = startTime.AddMinutes(30);
                    break;
                case 2: // 45 minutes
                    endTime = startTime.AddMinutes(45);
                    break;
                case 3: // 1 hour
                    endTime = startTime.AddHours(1);
                    break;
                case 4: // 1.5 hours
                    endTime = startTime.AddMinutes(90);
                    break;
                case 5: // 2 hours
                    endTime = startTime.AddHours(2);
                    break;
                default:
                    endTime = startTime.AddMinutes(30);
                    break;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Check if interview already exists
                    string checkQuery = "SELECT COUNT(*) FROM Interviews WHERE ApplicationID = @ApplicationID";
                    
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@ApplicationID", applicationId);
                        int count = (int)checkCommand.ExecuteScalar();
                        
                        if (count > 0)
                        {
                            // Update existing interview
                            string updateQuery = @"
                                UPDATE Interviews
                                SET InterviewDate = @InterviewDate,
                                    StartTime = @StartTime,
                                    EndTime = @EndTime,
                                    InterviewResult = NULL
                                WHERE ApplicationID = @ApplicationID";
                            
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@InterviewDate", dtpInterviewDate.Value.Date);
                                updateCommand.Parameters.AddWithValue("@StartTime", dtpInterviewTime.Value.TimeOfDay);
                                updateCommand.Parameters.AddWithValue("@EndTime", endTime.TimeOfDay);
                                updateCommand.Parameters.AddWithValue("@ApplicationID", applicationId);
                                
                                updateCommand.ExecuteNonQuery();
                                
                                MessageBox.Show("Interview has been rescheduled successfully!",
                                    "Interview Rescheduled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            // Insert new interview
                            string insertQuery = @"
                                INSERT INTO Interviews (
                                    ApplicationID,
                                    InterviewDate,
                                    StartTime,
                                    EndTime,
                                    InterviewResult
                                )
                                VALUES (
                                    @ApplicationID,
                                    @InterviewDate,
                                    @StartTime,
                                    @EndTime,
                                    NULL
                                )";
                            
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@ApplicationID", applicationId);
                                insertCommand.Parameters.AddWithValue("@InterviewDate", dtpInterviewDate.Value.Date);
                                insertCommand.Parameters.AddWithValue("@StartTime", dtpInterviewTime.Value.TimeOfDay);
                                insertCommand.Parameters.AddWithValue("@EndTime", endTime.TimeOfDay);
                                
                                insertCommand.ExecuteNonQuery();
                                
                                MessageBox.Show("Interview has been scheduled successfully!",
                                    "Interview Scheduled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error scheduling interview: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbInterviewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update location hint based on interview type
            if (cmbInterviewType.SelectedIndex == 0) // Online
            {
                lblLocation.Text = "Meeting Link:";
                txtLocation.Text = "https://";
                txtLocation.PlaceholderText = "Enter video conference link";
            }
            else if (cmbInterviewType.SelectedIndex == 1) // In-person
            {
                lblLocation.Text = "Address:";
                txtLocation.Text = "";
                txtLocation.PlaceholderText = "Enter physical location";
            }
            else if (cmbInterviewType.SelectedIndex == 2) // Phone
            {
                lblLocation.Text = "Phone Number:";
                txtLocation.Text = "";
                txtLocation.PlaceholderText = "Enter phone number";
            }
        }
    }
} 