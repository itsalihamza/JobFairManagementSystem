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
    public partial class JobFairRegistrationForm : Form
    {
        private string fairId;
        private string fairName;

        public JobFairRegistrationForm(string fairId, string fairName)
        {
            InitializeComponent();
            
            this.fairId = fairId;
            this.fairName = fairName;
            
            // Set fair name in title
            lblFairNameValue.Text = fairName;
            
            // Load fair details
            LoadFairDetails();
        }

        private void LoadFairDetails()
        {
            // In a real application, this would fetch data from the database
            // For now, we'll just set some dummy data based on the fair ID
            
            if (fairId == "1") // Spring 2023
            {
                lblDateValue.Text = "April 15, 2023";
                lblVenueValue.Text = "FAST-NUCES Auditorium";
                lblTimeValue.Text = "10:00 AM - 4:00 PM";
                lblRegistrationFeeValue.Text = "$500";
                
                txtDescription.Text = "The Spring 2023 Career Fair at FAST-NUCES Islamabad is an excellent opportunity " +
                    "for companies to connect with top talent in the IT industry. Students from CS, SE, AI, and DS " +
                    "programs will be attending. Each participating company will be provided with a booth, " +
                    "basic furniture, and Wi-Fi access.";
                
                // Pre-select some common job positions
                chkSoftwareEngineer.Checked = true;
                chkWebDeveloper.Checked = true;
            }
            else if (fairId == "2") // Fall 2023
            {
                lblDateValue.Text = "November 20, 2023";
                lblVenueValue.Text = "FAST-NUCES Main Hall";
                lblTimeValue.Text = "9:00 AM - 3:00 PM";
                lblRegistrationFeeValue.Text = "$600";
                
                txtDescription.Text = "The Fall 2023 Tech Expo at FAST-NUCES Islamabad will focus on cutting-edge technologies " +
                    "and innovation. This is a unique opportunity to meet with students specializing in AI, data science, " +
                    "cloud computing, and cybersecurity. Early registration is recommended as space is limited.";
                
                // Pre-select some common job positions
                chkDataScientist.Checked = true;
                chkAIEngineer.Checked = true;
            }
            else
            {
                txtDescription.Text = "Please contact the career center for more details about this job fair.";
                lblRegistrationFeeValue.Text = "TBD";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validate form input
            if (string.IsNullOrEmpty(txtCompanyReps.Text.Trim()))
            {
                MessageBox.Show("Please enter the names of company representatives.", 
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompanyReps.Focus();
                return;
            }

            if (!chkSoftwareEngineer.Checked && !chkWebDeveloper.Checked && 
                !chkDataScientist.Checked && !chkAIEngineer.Checked && 
                !chkUIUXDesigner.Checked && !chkNetworkEngineer.Checked && 
                string.IsNullOrEmpty(txtOtherPositions.Text.Trim()))
            {
                MessageBox.Show("Please select at least one job position or specify other positions.", 
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkAgreeTerms.Checked)
            {
                MessageBox.Show("You must agree to the terms and conditions to proceed.", 
                    "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // In a real application, this would save the registration to the database
            // For now, we'll just show a success message
            
            string message = $"Your company has been successfully registered for the {fairName}.\n\n" +
                $"A confirmation email with additional details will be sent shortly.";
            MessageBox.Show(message, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
} 