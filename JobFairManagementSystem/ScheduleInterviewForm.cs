using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public ScheduleInterviewForm(string applicationId, string studentName, string jobTitle)
        {
            InitializeComponent();
            
            this.applicationId = applicationId;
            this.studentName = studentName;
            this.jobTitle = jobTitle;
            
            // Set labels with applicant information
            lblStudentNameValue.Text = studentName;
            lblJobTitleValue.Text = jobTitle;
            
            // Set default date to tomorrow
            dtpInterviewDate.Value = DateTime.Today.AddDays(1);
            
            // Initialize combo boxes
            cmbInterviewType.SelectedIndex = 0; // Default to Online
            cmbDuration.SelectedIndex = 2; // Default to 45 minutes
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(txtLocation.Text))
            {
                MessageBox.Show("Please enter the interview location.", "Missing Information", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus();
                return;
            }

            // In a real application, this would save the interview details to the database
            // For simplicity, we'll just show a success message

            string interviewDate = dtpInterviewDate.Value.ToShortDateString();
            string interviewTime = dtpInterviewTime.Value.ToShortTimeString();
            string interviewType = cmbInterviewType.SelectedItem.ToString();
            string duration = cmbDuration.SelectedItem.ToString();
            string location = txtLocation.Text;
            string notes = txtNotes.Text;

            string message = $"Interview with {studentName} for {jobTitle} position has been scheduled for " +
                $"{interviewDate} at {interviewTime}.\n\n" +
                $"Type: {interviewType}\n" +
                $"Duration: {duration}\n" +
                $"Location: {location}";

            MessageBox.Show(message, "Interview Scheduled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
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