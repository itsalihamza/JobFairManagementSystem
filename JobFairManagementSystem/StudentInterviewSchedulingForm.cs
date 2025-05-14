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
    public partial class StudentInterviewSchedulingForm : Form
    {
        private int studentId;
        private int applicationId;
        private string jobTitle;
        private string companyName;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";
        
        public StudentInterviewSchedulingForm(int studentId, int applicationId, string jobTitle, string companyName)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.applicationId = applicationId;
            this.jobTitle = jobTitle;
            this.companyName = companyName;
            
            // Set form title and labels
            this.Text = "Schedule Interview for " + jobTitle;
            lblCompany.Text = companyName;
            lblJobTitle.Text = jobTitle;
            
            // Load available time slots
            LoadAvailableTimeSlots();
        }
        
        private void LoadAvailableTimeSlots()
        {
            try
            {
                dgvTimeSlots.Rows.Clear();
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Get available time slots for the next 14 days, excluding weekends
                    DateTime startDate = DateTime.Today.AddDays(1);  // Start from tomorrow
                    DateTime endDate = startDate.AddDays(14);        // 2 weeks ahead
                    
                    // Query to check if the application already has a scheduled interview
                    string checkQuery = @"
                        SELECT COUNT(*) 
                        FROM Interviews 
                        WHERE ApplicationID = @ApplicationID";
                    
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@ApplicationID", applicationId);
                        int existingInterviews = (int)checkCommand.ExecuteScalar();
                        
                        if (existingInterviews > 0)
                        {
                            // Interview already scheduled
                            MessageBox.Show("An interview is already scheduled for this application.",
                                "Interview Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            // Load the existing interview details
                            string getDetailsQuery = @"
                                SELECT 
                                    CONVERT(VARCHAR(10), InterviewDate, 101) AS InterviewDateFormatted,
                                    CONVERT(VARCHAR(10), StartTime, 108) AS StartTimeFormatted,
                                    CONVERT(VARCHAR(10), EndTime, 108) AS EndTimeFormatted
                                FROM Interviews
                                WHERE ApplicationID = @ApplicationID";
                            
                            using (SqlCommand getDetailsCommand = new SqlCommand(getDetailsQuery, connection))
                            {
                                getDetailsCommand.Parameters.AddWithValue("@ApplicationID", applicationId);
                                using (SqlDataReader reader = getDetailsCommand.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        dgvTimeSlots.Rows.Add(
                                            reader["InterviewDateFormatted"].ToString(),
                                            reader["StartTimeFormatted"].ToString(),
                                            reader["EndTimeFormatted"].ToString(),
                                            "Already Scheduled"
                                        );
                                    }
                                }
                            }
                            
                            // Disable the schedule button
                            btnSchedule.Enabled = false;
                            
                            return;
                        }
                    }
                    
                    // Generate time slots
                    for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                    {
                        // Skip weekends
                        if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                        {
                            continue;
                        }
                        
                        // Start times from 9 AM to 4 PM with 1-hour slots
                        for (int hour = 9; hour < 16; hour++)
                        {
                            DateTime startTime = new DateTime(date.Year, date.Month, date.Day, hour, 0, 0);
                            DateTime endTime = startTime.AddHours(1);
                            
                            // Check if this time slot is already booked
                            string query = @"
                                SELECT COUNT(*) 
                                FROM Interviews i
                                JOIN Applications a ON i.ApplicationID = a.ApplicationID
                                JOIN JobPostings jp ON a.JobID = jp.JobID
                                WHERE i.InterviewDate = @Date
                                AND (
                                    (i.StartTime <= @StartTime AND i.EndTime > @StartTime) OR
                                    (i.StartTime < @EndTime AND i.EndTime >= @EndTime) OR
                                    (i.StartTime >= @StartTime AND i.EndTime <= @EndTime)
                                )
                                AND jp.CompanyID = (
                                    SELECT jp2.CompanyID
                                    FROM Applications a2
                                    JOIN JobPostings jp2 ON a2.JobID = jp2.JobID
                                    WHERE a2.ApplicationID = @ApplicationID
                                )";
                            
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Date", date);
                                command.Parameters.AddWithValue("@StartTime", startTime.TimeOfDay);
                                command.Parameters.AddWithValue("@EndTime", endTime.TimeOfDay);
                                command.Parameters.AddWithValue("@ApplicationID", applicationId);
                                
                                int conflictCount = (int)command.ExecuteScalar();
                                
                                string status = conflictCount > 0 ? "Booked" : "Available";
                                
                                dgvTimeSlots.Rows.Add(
                                    date.ToString("MM/dd/yyyy"),
                                    startTime.ToString("hh:mm tt"),
                                    endTime.ToString("hh:mm tt"),
                                    status
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available time slots: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (dgvTimeSlots.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a time slot.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string status = dgvTimeSlots.SelectedRows[0].Cells[3].Value.ToString();
            if (status != "Available")
            {
                MessageBox.Show("Please select an available time slot.",
                    "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string dateStr = dgvTimeSlots.SelectedRows[0].Cells[0].Value.ToString();
            string startTimeStr = dgvTimeSlots.SelectedRows[0].Cells[1].Value.ToString();
            string endTimeStr = dgvTimeSlots.SelectedRows[0].Cells[2].Value.ToString();
            
            // Parse the date and time
            DateTime date = DateTime.Parse(dateStr);
            DateTime startTime = DateTime.Parse(startTimeStr);
            DateTime endTime = DateTime.Parse(endTimeStr);
            
            // Confirm with the user
            if (MessageBox.Show($"Do you want to schedule an interview for {jobTitle} at {companyName} on {dateStr} from {startTimeStr} to {endTimeStr}?",
                "Confirm Interview", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        
                        // Insert the interview record
                        string query = @"
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
                        
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ApplicationID", applicationId);
                            command.Parameters.AddWithValue("@InterviewDate", date);
                            command.Parameters.AddWithValue("@StartTime", startTime.TimeOfDay);
                            command.Parameters.AddWithValue("@EndTime", endTime.TimeOfDay);
                            
                            command.ExecuteNonQuery();
                            
                            // Update application status
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
                            
                            MessageBox.Show("Interview has been scheduled successfully!",
                                "Interview Scheduled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
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
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
} 