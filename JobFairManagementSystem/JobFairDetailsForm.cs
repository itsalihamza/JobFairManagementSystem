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
    public partial class JobFairDetailsForm : Form
    {
        private string fairId;
        private string fairName;

        public JobFairDetailsForm(string fairId, string fairName)
        {
            InitializeComponent();
            this.fairId = fairId;
            this.fairName = fairName;

            // Set labels
            lblFairNameValue.Text = fairName;

            // Load fair details
            LoadFairDetails();
        }

        private void LoadFairDetails()
        {
            // In a real application, this would fetch the job fair details from the database
            // For now, we'll just set some dummy data based on the fair ID
            
            if (fairId == "1") // Spring 2023
            {
                lblDateValue.Text = "April 15, 2023";
                lblTimeValue.Text = "10:00 AM - 4:00 PM";
                lblVenueValue.Text = "FAST-NUCES Auditorium";
                
                txtDescription.Text = "The Spring 2023 Career Fair at FAST-NUCES Islamabad is an excellent opportunity for " +
                    "students to connect with top companies in the IT industry. Companies will be recruiting for " +
                    "both internships and full-time positions. Don't miss this opportunity to network and find your dream job!";
                
                // Add participating companies
                dgvCompanies.Rows.Add("Microsoft", "Software Engineer, Data Scientist", "10");
                dgvCompanies.Rows.Add("Google", "Web Developer, UI/UX Designer", "12");
                dgvCompanies.Rows.Add("Amazon", "Software Engineer, Product Manager", "15");
                dgvCompanies.Rows.Add("IBM", "Cloud Engineer, Data Analyst", "8");
                dgvCompanies.Rows.Add("Oracle", "Database Administrator, Java Developer", "6");
            }
            else if (fairId == "2") // Fall 2023
            {
                lblDateValue.Text = "November 20, 2023";
                lblTimeValue.Text = "9:00 AM - 3:00 PM";
                lblVenueValue.Text = "FAST-NUCES Main Hall";
                
                txtDescription.Text = "The Fall 2023 Tech Expo at FAST-NUCES Islamabad will focus on cutting-edge technologies " +
                    "and innovation. This is a unique opportunity for students to meet with tech companies and startups " +
                    "working on AI, blockchain, and cloud computing. There will also be tech talks and workshops throughout the day.";
                
                // Add participating companies
                dgvCompanies.Rows.Add("Nvidia", "AI Engineer, Machine Learning Engineer", "5");
                dgvCompanies.Rows.Add("Meta", "VR Developer, Software Engineer", "7");
                dgvCompanies.Rows.Add("Tesla", "Automation Engineer, Software Developer", "3");
                dgvCompanies.Rows.Add("Netflix", "Full Stack Developer, Data Engineer", "4");
                dgvCompanies.Rows.Add("Salesforce", "Cloud Developer, Technical Consultant", "6");
            }
            else
            {
                txtDescription.Text = "Details for this job fair are coming soon!";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to register for the {fairName}?", 
                "Confirm Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // In a real application, this would save to the database
                MessageBox.Show("You have successfully registered for the job fair!", 
                    "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 