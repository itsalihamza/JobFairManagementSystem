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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            // Set welcome label
            lblWelcome.Text = "Welcome, Admin";
            
            // Load some dummy data for testing
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            // Load job fairs data
            dgvJobFairs.Rows.Add("1", "Spring 2023 Career Fair", "2023-04-15", "FAST-NUCES Auditorium", "Active");
            dgvJobFairs.Rows.Add("2", "Fall 2023 Tech Expo", "2023-11-20", "FAST-NUCES Main Hall", "Upcoming");
            
            // Load companies data
            dgvCompanies.Rows.Add("1", "Microsoft", "Tech", "5", "Approved");
            dgvCompanies.Rows.Add("2", "Google", "Tech", "3", "Approved");
            dgvCompanies.Rows.Add("3", "Amazon", "E-commerce", "4", "Pending");
            
            // Load students data
            dgvStudents.Rows.Add("1", "John Doe", "22K-1234", "CS", "3.7", "Verified");
            dgvStudents.Rows.Add("2", "Jane Smith", "22K-5678", "SE", "3.9", "Verified");
            dgvStudents.Rows.Add("3", "Mike Johnson", "21K-4321", "DS", "3.5", "Pending");
        }

        private void btnCreateFair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality will allow creating a new job fair.", 
                "Create Job Fair", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnManageFair_Click(object sender, EventArgs e)
        {
            if (dgvJobFairs.SelectedRows.Count > 0)
            {
                string fairId = dgvJobFairs.SelectedRows[0].Cells[0].Value.ToString();
                string fairName = dgvJobFairs.SelectedRows[0].Cells[1].Value.ToString();
                
                MessageBox.Show($"This would open the management interface for {fairName}.", 
                    "Manage Job Fair", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string companyName = dgvCompanies.SelectedRows[0].Cells[1].Value.ToString();
                string status = dgvCompanies.SelectedRows[0].Cells[4].Value.ToString();
                
                if (status == "Pending")
                {
                    dgvCompanies.SelectedRows[0].Cells[4].Value = "Approved";
                    MessageBox.Show($"{companyName} has been approved.", 
                        "Company Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string studentName = dgvStudents.SelectedRows[0].Cells[1].Value.ToString();
                string status = dgvStudents.SelectedRows[0].Cells[5].Value.ToString();
                
                if (status == "Pending")
                {
                    dgvStudents.SelectedRows[0].Cells[5].Value = "Verified";
                    MessageBox.Show($"{studentName} has been verified.", 
                        "Student Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Refresh data if needed when tab changes
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality will allow generating various reports.", 
                "Generate Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
} 