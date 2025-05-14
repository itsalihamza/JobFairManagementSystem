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
                                lblLocationValue.Text = reader["Location"].ToString();
                                lblSectorValue.Text = reader["Sector"].ToString();
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
                                
                                // Check if the skills match student skills
                                if (studentId > 0)
                                {
                                    CheckSkillMatch(skills);
                                }
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
        
        private void CheckSkillMatch(string requiredSkills)
        {
            try
            {
                lblSkillMatch.Visible = true;
                
                if (string.IsNullOrEmpty(requiredSkills))
                {
                    lblSkillMatch.Text = "No specific skills required for this job.";
                    lblSkillMatch.ForeColor = Color.Green;
                    return;
                }
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Get student skills
                    string query = @"
                        SELECT s.SkillName
                        FROM StudentSkills ss
                        JOIN Skills s ON ss.SkillID = s.SkillID
                        WHERE ss.StudentID = @StudentID";
                    
                    List<string> studentSkills = new List<string>();
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                studentSkills.Add(reader["SkillName"].ToString().ToLower());
                            }
                        }
                    }
                    
                    if (studentSkills.Count == 0)
                    {
                        lblSkillMatch.Text = "You have no skills listed in your profile. Consider adding some!";
                        lblSkillMatch.ForeColor = Color.Red;
                        return;
                    }
                    
                    // Compare with required skills
                    string[] requiredSkillList = requiredSkills.Split(',');
                    int matchCount = 0;
                    
                    foreach (string skill in requiredSkillList)
                    {
                        string trimmedSkill = skill.Trim().ToLower();
                        if (!string.IsNullOrWhiteSpace(trimmedSkill))
                        {
                            // Check if any student skill contains this required skill
                            foreach (string studentSkill in studentSkills)
                            {
                                if (studentSkill.Contains(trimmedSkill) || trimmedSkill.Contains(studentSkill))
                                {
                                    matchCount++;
                                    break;
                                }
                            }
                        }
                    }
                    
                    int totalRequiredSkills = requiredSkillList.Count(s => !string.IsNullOrWhiteSpace(s));
                    
                    if (totalRequiredSkills == 0)
                    {
                        lblSkillMatch.Text = "No specific skills required for this job.";
                        lblSkillMatch.ForeColor = Color.Green;
                    }
                    else
                    {
                        double matchPercentage = (double)matchCount / totalRequiredSkills * 100;
                        
                        if (matchPercentage >= 80)
                        {
                            lblSkillMatch.Text = $"Great match! You have {matchCount} of {totalRequiredSkills} required skills.";
                            lblSkillMatch.ForeColor = Color.Green;
                        }
                        else if (matchPercentage >= 50)
                        {
                            lblSkillMatch.Text = $"Good match! You have {matchCount} of {totalRequiredSkills} required skills.";
                            lblSkillMatch.ForeColor = Color.Blue;
                        }
                        else if (matchCount > 0)
                        {
                            lblSkillMatch.Text = $"Partial match. You have {matchCount} of {totalRequiredSkills} required skills.";
                            lblSkillMatch.ForeColor = Color.Orange;
                        }
                        else
                        {
                            lblSkillMatch.Text = "Your skills don't match the requirements for this job.";
                            lblSkillMatch.ForeColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblSkillMatch.Text = "Error checking skill match.";
                lblSkillMatch.ForeColor = Color.Red;
                // Just silently log the error, don't bother the user as this is a non-critical feature
                Console.WriteLine("Error checking skill match: " + ex.Message);
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