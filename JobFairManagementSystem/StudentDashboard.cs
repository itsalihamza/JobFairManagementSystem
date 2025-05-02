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
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
            // Just for testing, we'll load some dummy data
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            // Load job fairs
            dgvJobFairs.Rows.Add("1", "Spring 2023 Career Fair", "2023-04-15", "FAST-NUCES Auditorium", "10:00 AM - 4:00 PM");
            dgvJobFairs.Rows.Add("2", "Fall 2023 Tech Expo", "2023-11-20", "FAST-NUCES Main Hall", "9:00 AM - 3:00 PM");
            
            // Load jobs
            dgvJobs.Rows.Add("101", "Software Engineer", "Microsoft", "Full-time", "New Applications Open");
            dgvJobs.Rows.Add("102", "Web Developer", "Google", "Internship", "New Applications Open");
            dgvJobs.Rows.Add("103", "Data Scientist", "Amazon", "Full-time", "New Applications Open");
            dgvJobs.Rows.Add("104", "AI Engineer", "Nvidia", "Full-time", "New Applications Open");
            
            // Load applications
            dgvApplications.Rows.Add("1001", "Software Engineer", "Microsoft", "2023-04-16", "Shortlisted");
            dgvApplications.Rows.Add("1002", "Web Developer", "Google", "2023-04-18", "Pending");
            
            // Load interviews
            dgvInterviews.Rows.Add("2001", "Microsoft", "Software Engineer", "2023-04-25", "10:00 AM", "Online");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can refresh data based on the selected tab if needed
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
                JobApplicationForm applicationForm = new JobApplicationForm(jobId, jobTitle, company);
                if (applicationForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the applications tab
                    // In a real application, this would fetch from the database
                    dgvApplications.Rows.Add("1003", jobTitle, company, DateTime.Now.ToShortDateString(), "Pending");
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
                    // In a real application, this would save to the database
                    MessageBox.Show("You have successfully registered for the job fair!", 
                        "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            StudentInfoForm infoForm = new StudentInfoForm();
            infoForm.ShowDialog();
        }

        private void btnManageSkills_Click(object sender, EventArgs e)
        {
            StudentSkillsForm skillsForm = new StudentSkillsForm();
            skillsForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // In a real application, this would refresh data from the database
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