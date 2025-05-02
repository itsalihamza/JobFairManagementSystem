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
    public partial class ApplicantProfileForm : Form
    {
        private string studentName;
        private string fastId;

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
            // In a real application, this would fetch data from the database
            // For now, we'll just set dummy data based on the student name
            
            if (fastId == "22K-1234") // John Doe
            {
                lblDegreeValue.Text = "CS";
                lblSemesterValue.Text = "5";
                lblGPAValue.Text = "3.8";
                
                // Add skills
                lstSkills.Items.Add("C#");
                lstSkills.Items.Add("Java");
                lstSkills.Items.Add("Python");
                lstSkills.Items.Add("SQL");
                lstSkills.Items.Add("ASP.NET");
                
                // Add certifications
                lstCertifications.Items.Add("Microsoft Certified: Azure Developer Associate (2022)");
                lstCertifications.Items.Add("AWS Certified Developer – Associate (2021)");
                
                // Add education
                txtEducation.Text = "Bachelor of Science in Computer Science\r\nFAST-NUCES Islamabad\r\nExpected graduation: 2024";
                
                // Add experience
                txtExperience.Text = "Software Developer Intern\r\nTech Solutions Inc.\r\nSummer 2022\r\n\r\nJunior Web Developer\r\nWebCraft Studios\r\nSummer 2021";
            }
            else if (fastId == "22K-5678") // Jane Smith
            {
                lblDegreeValue.Text = "SE";
                lblSemesterValue.Text = "5";
                lblGPAValue.Text = "3.6";
                
                lstSkills.Items.Add("JavaScript");
                lstSkills.Items.Add("React");
                lstSkills.Items.Add("Node.js");
                lstSkills.Items.Add("HTML/CSS");
                lstSkills.Items.Add("UI/UX Design");
                
                lstCertifications.Items.Add("Google UX Design Professional Certificate (2022)");
                lstCertifications.Items.Add("Meta Front-End Developer Professional Certificate (2021)");
                
                txtEducation.Text = "Bachelor of Science in Software Engineering\r\nFAST-NUCES Islamabad\r\nExpected graduation: 2024";
                
                txtExperience.Text = "UI/UX Design Intern\r\nDesign Masters\r\nSummer 2022\r\n\r\nWeb Developer\r\nCreative Solutions\r\nPart-time, 2021-Present";
            }
            else if (fastId == "21K-4321") // Mike Johnson
            {
                lblDegreeValue.Text = "AI";
                lblSemesterValue.Text = "7";
                lblGPAValue.Text = "3.5";
                
                lstSkills.Items.Add("Python");
                lstSkills.Items.Add("TensorFlow");
                lstSkills.Items.Add("Machine Learning");
                lstSkills.Items.Add("Data Analysis");
                lstSkills.Items.Add("Computer Vision");
                
                lstCertifications.Items.Add("IBM AI Engineering Professional Certificate (2022)");
                lstCertifications.Items.Add("DeepLearning.AI TensorFlow Developer (2021)");
                
                txtEducation.Text = "Bachelor of Science in Artificial Intelligence\r\nFAST-NUCES Islamabad\r\nExpected graduation: 2023";
                
                txtExperience.Text = "Machine Learning Intern\r\nAI Innovations\r\nSummer 2022\r\n\r\nResearch Assistant\r\nFAST-NUCES AI Lab\r\n2021-Present";
            }
            else
            {
                // Default placeholder data
                lblDegreeValue.Text = "CS/SE/AI/DS";
                lblSemesterValue.Text = "1-8";
                lblGPAValue.Text = "3.0+";
                
                lstSkills.Items.Add("Programming");
                lstSkills.Items.Add("Problem Solving");
                
                txtEducation.Text = "Bachelor's degree in progress at FAST-NUCES";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 