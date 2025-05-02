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
    public partial class CoordinatorDashboard : Form
    {
        public CoordinatorDashboard()
        {
            InitializeComponent();
            // Set welcome label
            lblWelcome.Text = "Welcome, Coordinator";
            
            // Load some dummy data for testing
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            // Load job fairs data
            dgvJobFairs.Rows.Add("1", "Spring 2023 Career Fair", "2023-04-15", "FAST-NUCES Auditorium", "Active");
            dgvJobFairs.Rows.Add("2", "Fall 2023 Tech Expo", "2023-11-20", "FAST-NUCES Main Hall", "Upcoming");
            
            // Load companies registration data
            dgvCompanyRegistrations.Rows.Add("1", "Microsoft", "Spring 2023 Career Fair", "Booth 10", "Confirmed");
            dgvCompanyRegistrations.Rows.Add("2", "Google", "Spring 2023 Career Fair", "Booth 12", "Confirmed");
            dgvCompanyRegistrations.Rows.Add("3", "Amazon", "Spring 2023 Career Fair", "Booth 15", "Pending");
            
            // Load student registrations data
            dgvStudentRegistrations.Rows.Add("1", "John Doe", "22K-1234", "Spring 2023 Career Fair", "Registered");
            dgvStudentRegistrations.Rows.Add("2", "Jane Smith", "22K-5678", "Spring 2023 Career Fair", "Registered");
            dgvStudentRegistrations.Rows.Add("3", "Mike Johnson", "21K-4321", "Spring 2023 Career Fair", "Pending");
        }

        private void btnAssignBooth_Click(object sender, EventArgs e)
        {
            if (dgvCompanyRegistrations.SelectedRows.Count > 0)
            {
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
                        dgvCompanyRegistrations.SelectedRows[0].Cells[3].Value = textBox.Text;
                        dgvCompanyRegistrations.SelectedRows[0].Cells[4].Value = "Confirmed";
                        
                        MessageBox.Show($"{companyName} has been assigned to {textBox.Text}.", 
                            "Booth Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Reminders have been sent to all registered companies and students.", 
                "Reminders Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGenerateAttendanceList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attendance list has been generated and saved.", 
                "Attendance List", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
} 