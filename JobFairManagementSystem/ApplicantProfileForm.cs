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
    public partial class ApplicantProfileForm : Form
    {
        private string studentName;
        private string fastId;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";

        public ApplicantProfileForm(string studentName, string fastId)
        {
            InitializeComponent();
            
            this.studentName = studentName;
            this.fastId = fastId;
            
            // Set title and labels
            this.Text = $"Profile - {studentName}";
            lblNameValue.Text = studentName;
            lblFastIdValue.Text = fastId;
            
            // Load profile data
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Get student information
                    string query = @"
                        SELECT 
                            s.StudentID,
                            s.DegreeProgram,
                            s.CurrentSemester,
                            s.GPA
                        FROM Students s
                        WHERE s.FAST_ID = @FAST_ID";
                    
                    int studentId = 0;
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FAST_ID", fastId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Set basic info
                                studentId = Convert.ToInt32(reader["StudentID"]);
                                lblDegreeValue.Text = reader["DegreeProgram"].ToString();
                                lblSemesterValue.Text = reader["CurrentSemester"].ToString();
                                lblGPAValue.Text = Convert.ToDouble(reader["GPA"]).ToString("F2");
                            }
                            else
                            {
                                // If no student found, show placeholder data
                                lblDegreeValue.Text = "N/A";
                                lblSemesterValue.Text = "N/A";
                                lblGPAValue.Text = "N/A";
                                
                                MessageBox.Show("Student profile not found in database.", 
                                    "Profile Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                    
                    // Get student skills
                    string skillsQuery = @"
                        SELECT 
                            sk.SkillName
                        FROM StudentSkills ss
                        JOIN Skills sk ON ss.SkillID = sk.SkillID
                        WHERE ss.StudentID = @StudentID
                        ORDER BY sk.SkillName";
                    
                    using (SqlCommand command = new SqlCommand(skillsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            lstSkills.Items.Clear();
                            while (reader.Read())
                            {
                                lstSkills.Items.Add(reader["SkillName"].ToString());
                            }
                            
                            if (lstSkills.Items.Count == 0)
                            {
                                lstSkills.Items.Add("No skills listed");
                            }
                        }
                    }
                    
                    // Get certifications
                    string certQuery = @"
                        SELECT 
                            Title,
                            IssuedBy,
                            IssueDate
                        FROM Certifications
                        WHERE StudentID = @StudentID
                        ORDER BY IssueDate DESC";
                    
                    using (SqlCommand command = new SqlCommand(certQuery, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            lstCertifications.Items.Clear();
                            bool hasCertifications = false;
                            
                            while (reader.Read())
                            {
                                hasCertifications = true;
                                string certText = reader["Title"].ToString();
                                
                                if (!reader.IsDBNull(reader.GetOrdinal("IssuedBy")))
                                {
                                    certText += $" by {reader["IssuedBy"]}";
                                }
                                
                                if (!reader.IsDBNull(reader.GetOrdinal("IssueDate")))
                                {
                                    DateTime issueDate = Convert.ToDateTime(reader["IssueDate"]);
                                    certText += $" ({issueDate.Year})";
                                }
                                
                                lstCertifications.Items.Add(certText);
                            }
                            
                            if (!hasCertifications)
                            {
                                lstCertifications.Items.Add("No certifications listed");
                            }
                        }
                    }
                    
                    // Generate education info based on degree program and semester
                    string degreeName = "Bachelor of Science";
                    switch (lblDegreeValue.Text)
                    {
                        case "CS":
                            degreeName += " in Computer Science";
                            break;
                        case "SE":
                            degreeName += " in Software Engineering";
                            break;
                        case "AI":
                            degreeName += " in Artificial Intelligence";
                            break;
                        case "DS":
                            degreeName += " in Data Science";
                            break;
                    }
                    
                    int semestersLeft = 8 - Convert.ToInt32(lblSemesterValue.Text);
                    int yearsLeft = (int)Math.Ceiling(semestersLeft / 2.0);
                    int graduationYear = DateTime.Now.Year + yearsLeft;
                    
                    txtEducation.Text = $"{degreeName}\r\nFAST-NUCES Islamabad\r\nExpected graduation: {graduationYear}";
                    
                    // Get experience from applications/interviews
                    string expQuery = @"
                        SELECT TOP 3
                            c.CompanyName,
                            jp.JobTitle,
                            CONVERT(VARCHAR(10), a.ApplicationDate, 101) AS ApplicationDateFormatted
                        FROM Applications a
                        JOIN JobPostings jp ON a.JobID = jp.JobID
                        JOIN Companies c ON jp.CompanyID = c.CompanyID
                        WHERE a.StudentID = @StudentID AND a.ApplicationStatus IN ('Accepted', 'Offered')
                        ORDER BY a.ApplicationDate DESC";
                    
                    using (SqlCommand command = new SqlCommand(expQuery, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            StringBuilder expText = new StringBuilder();
                            bool hasExperience = false;
                            
                            while (reader.Read())
                            {
                                hasExperience = true;
                                string jobTitle = reader["JobTitle"].ToString();
                                string company = reader["CompanyName"].ToString();
                                string date = reader["ApplicationDateFormatted"].ToString();
                                
                                expText.AppendLine($"{jobTitle}");
                                expText.AppendLine($"{company}");
                                expText.AppendLine($"{date}");
                                expText.AppendLine();
                            }
                            
                            if (hasExperience)
                            {
                                txtExperience.Text = expText.ToString().Trim();
                            }
                            else
                            {
                                txtExperience.Text = "No previous work experience on record.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile data: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Set default values in case of error
                lblDegreeValue.Text = "CS/SE/AI/DS";
                lblSemesterValue.Text = "1-8";
                lblGPAValue.Text = "3.0+";
                
                lstSkills.Items.Clear();
                lstSkills.Items.Add("Error loading skills");
                
                lstCertifications.Items.Clear();
                lstCertifications.Items.Add("Error loading certifications");
                
                txtEducation.Text = "Bachelor's degree in progress at FAST-NUCES";
                txtExperience.Text = "Error loading experience data";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 