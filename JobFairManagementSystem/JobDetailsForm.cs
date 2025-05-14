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
    public partial class JobDetailsForm : Form
    {
        private string jobId;
        private string jobTitle;
        private string company;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";
        private int studentId;

        public JobDetailsForm(string jobId, string jobTitle, string company, int studentId = 0)
        {
            InitializeComponent();
            this.jobId = jobId;
            this.jobTitle = jobTitle;
            this.company = company;
            this.studentId = studentId;
            
            this.Text = $"{jobTitle} - {company}";
            
            // Load job details from database
            LoadJobDetails();
        }
        
        private void LoadJobDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            jp.JobTitle,
                            c.CompanyName,
                            c.Location,
                            c.Sector,
                            jp.JobType,
                            jp.SalaryRange,
                            jp.RequiredSkills,
                            jp.Description
                        FROM JobPostings jp
                        JOIN Companies c ON jp.CompanyID = c.CompanyID
                        WHERE jp.JobID = @JobID";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JobID", jobId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblJobTitleValue.Text = reader["JobTitle"].ToString();
                                lblCompanyValue.Text = reader["CompanyName"].ToString();
                                
                                lblJobTypeValue.Text = reader["JobType"].ToString();
                                lblSalaryValue.Text = reader["SalaryRange"].ToString();
                                
                                string skills = reader["RequiredSkills"].ToString();
                                if (!string.IsNullOrEmpty(skills))
                                {
                                    string[] skillList = skills.Split(',');
                                    foreach (string skill in skillList)
                                    {
                                        if (!string.IsNullOrWhiteSpace(skill))
                                        {
                                            lstSkills.Items.Add(skill.Trim());
                                        }
                                    }
                                }
                                
                                txtDescription.Text = reader["Description"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Job details not found.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading job details: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (studentId <= 0)
            {
                MessageBox.Show("You need to be logged in as a student to apply for this job.",
                    "Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            // Open the application form
            JobApplicationForm applicationForm = new JobApplicationForm(jobId, jobTitle, company, studentId);
            applicationForm.ShowDialog();
            
            // Close the details form after application is submitted
            if (applicationForm.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
} 