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
    public partial class RecruiterJobDetailsForm : Form
    {
        private string jobId;
        private string jobTitle;

        public RecruiterJobDetailsForm(string jobId, string jobTitle)
        {
            InitializeComponent();
            this.jobId = jobId;
            this.jobTitle = jobTitle;

            // Set labels
            lblJobTitleValue.Text = jobTitle;

            // Load job details
            LoadJobDetails();
        }

        private void LoadJobDetails()
        {
            // In a real application, this would fetch the job details from the database
            // For now, we'll just set some dummy data based on the job ID
            
            if (jobId == "101") // Software Engineer
            {
                lblJobTypeValue.Text = "Full-time";
                lblSalaryValue.Text = "$90,000 - $120,000 per year";
                lblStatusValue.Text = "Active";
                lblPostDateValue.Text = "2023-04-01";
                lblVacanciesValue.Text = "20";
                lblApplicantsValue.Text = "15";
                
                txtDescription.Text = "We are seeking a talented Software Engineer to join our development team. " +
                    "The ideal candidate will have strong skills in C#, .NET, and cloud technologies. " +
                    "Responsibilities include designing, coding, and testing new features for our products.";
                
                // Add required skills
                lstRequiredSkills.Items.Add("C#");
                lstRequiredSkills.Items.Add(".NET");
                lstRequiredSkills.Items.Add("Azure");
                lstRequiredSkills.Items.Add("SQL Server");
                lstRequiredSkills.Items.Add("Git");
                
                // Add applicants
                dgvApplicants.Rows.Add("1001", "John Doe", "22K-1234", "2023-04-16", "Shortlisted");
                dgvApplicants.Rows.Add("1002", "Jane Smith", "22K-5678", "2023-04-18", "Pending");
                dgvApplicants.Rows.Add("1003", "Mike Johnson", "21K-4321", "2023-04-20", "Rejected");
            }
            else if (jobId == "102") // Web Developer
            {
                lblJobTypeValue.Text = "Internship";
                lblSalaryValue.Text = "$30 - $40 per hour";
                lblStatusValue.Text = "Active";
                lblPostDateValue.Text = "2023-04-05";
                lblVacanciesValue.Text = "15";
                lblApplicantsValue.Text = "8";
                
                txtDescription.Text = "We are looking for a Web Developer intern to work on our front-end applications. " +
                    "You will be working with a team of experienced developers to build and maintain web applications. " +
                    "This is a 3-month internship with possibility of extension.";
                
                lstRequiredSkills.Items.Add("JavaScript");
                lstRequiredSkills.Items.Add("React");
                lstRequiredSkills.Items.Add("HTML/CSS");
                lstRequiredSkills.Items.Add("TypeScript");
                lstRequiredSkills.Items.Add("Node.js");
                
                dgvApplicants.Rows.Add("1004", "Alex Brown", "22K-8765", "2023-04-10", "Pending");
                dgvApplicants.Rows.Add("1005", "Sarah Wilson", "21K-5432", "2023-04-12", "Shortlisted");
            }
            else if (jobId == "103") // UI/UX Designer
            {
                lblJobTypeValue.Text = "Full-time";
                lblSalaryValue.Text = "$80,000 - $100,000 per year";
                lblStatusValue.Text = "Closed";
                lblPostDateValue.Text = "2023-03-15";
                lblVacanciesValue.Text = "10";
                lblApplicantsValue.Text = "12";
                
                txtDescription.Text = "We are seeking a creative UI/UX Designer to create amazing user experiences. " +
                    "The ideal candidate should have an eye for clean and artful design, possess superior UI/UX skills " +
                    "and be able to translate high-level requirements into interaction flows and artifacts.";
                
                lstRequiredSkills.Items.Add("Adobe XD");
                lstRequiredSkills.Items.Add("Figma");
                lstRequiredSkills.Items.Add("Sketch");
                lstRequiredSkills.Items.Add("Wireframing");
                lstRequiredSkills.Items.Add("Prototyping");
                
                dgvApplicants.Rows.Add("1006", "David Lee", "20K-9876", "2023-03-20", "Hired");
                dgvApplicants.Rows.Add("1007", "Emily Clark", "21K-7654", "2023-03-22", "Rejected");
                dgvApplicants.Rows.Add("1008", "Ryan Thomas", "22K-3456", "2023-03-25", "Shortlisted");
            }
            else
            {
                txtDescription.Text = "No detailed information available for this job.";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // In a real application, this would open a form to edit the job posting
            MessageBox.Show("Job editing functionality would be implemented here.", 
                "Edit Job", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnViewApplicant_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.SelectedRows.Count > 0)
            {
                string studentName = dgvApplicants.SelectedRows[0].Cells[1].Value.ToString();
                string fastId = dgvApplicants.SelectedRows[0].Cells[2].Value.ToString();
                
                // Open student profile viewer
                ApplicantProfileForm profileForm = new ApplicantProfileForm(studentName, fastId);
                profileForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an applicant first.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            // Create a simple dialog to change job status
            using (var form = new Form())
            {
                form.Text = "Change Job Status";
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
                comboBox.Items.AddRange(new string[] { "Active", "Closed", "Draft", "Archived" });
                comboBox.SelectedItem = lblStatusValue.Text;

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
                    lblStatusValue.Text = comboBox.SelectedItem.ToString();
                    MessageBox.Show($"Job status updated to {comboBox.SelectedItem}.", 
                        "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
} 