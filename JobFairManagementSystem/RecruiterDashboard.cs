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
    public partial class RecruiterDashboard : Form
    {
        public RecruiterDashboard()
        {
            InitializeComponent();
            // Just for testing, we'll load some dummy data
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            // Load applications
            dgvApplications.Rows.Add("1001", "John Doe", "22K-1234", "Software Engineer", "2023-04-16", "Shortlisted");
            dgvApplications.Rows.Add("1002", "Jane Smith", "22K-5678", "Software Engineer", "2023-04-18", "Pending");
            dgvApplications.Rows.Add("1003", "Mike Johnson", "21K-4321", "Software Engineer", "2023-04-20", "Rejected");
            
            // Load interviews
            dgvInterviews.Rows.Add("2001", "John Doe", "Software Engineer", "2023-04-25", "10:00 AM", "Online", "Scheduled");
            
            // Load job postings
            dgvJobs.Rows.Add("101", "Software Engineer", "Full-time", "20", "Active");
            dgvJobs.Rows.Add("102", "Web Developer", "Internship", "15", "Active");
            dgvJobs.Rows.Add("103", "UI/UX Designer", "Full-time", "10", "Closed");
            
            // Load job fairs
            dgvJobFairs.Rows.Add("1", "Spring 2023 Career Fair", "2023-04-15", "FAST-NUCES Auditorium", "Registered", "10");
            dgvJobFairs.Rows.Add("2", "Fall 2023 Tech Expo", "2023-11-20", "FAST-NUCES Main Hall", "Not Registered", "-");
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
                        // Update the status in the grid
                        dgvApplications.SelectedRows[0].Cells[5].Value = comboBox.SelectedItem.ToString();
                        
                        // In a real application, this would also update the database
                        MessageBox.Show($"Application status updated to {comboBox.SelectedItem}.", 
                            "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    // In a real application, refresh the interviews list
                    MessageBox.Show("Interview scheduled successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            JobPostingForm postingForm = new JobPostingForm();
            if (postingForm.ShowDialog() == DialogResult.OK)
            {
                // In a real application, refresh the job postings list
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
                JobFairRegistrationForm registrationForm = new JobFairRegistrationForm(fairId, fairName);
                if (registrationForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the status in the grid
                    dgvJobFairs.SelectedRows[0].Cells[4].Value = "Registered";
                    dgvJobFairs.SelectedRows[0].Cells[5].Value = "12"; // Booth number
                    
                    // In a real application, this would also update the database
                    MessageBox.Show("Successfully registered for the job fair!", "Registration Successful", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a job fair first.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // You can refresh data based on the selected tab if needed
        }
    }
} 