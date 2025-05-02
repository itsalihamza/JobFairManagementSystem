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
    public partial class JobDetailsForm : Form
    {
        private string jobId;
        private string jobTitle;
        private string company;

        public JobDetailsForm(string jobId, string jobTitle, string company)
        {
            InitializeComponent();
            this.jobId = jobId;
            this.jobTitle = jobTitle;
            this.company = company;

            // Set labels
            lblJobTitleValue.Text = jobTitle;
            lblCompanyValue.Text = company;

            // Load job details
            LoadJobDetails();
        }

        private void LoadJobDetails()
        {
            // In a real application, this would fetch the job details from the database
            // For now, we'll just set some dummy data
            
            if (jobId == "101") // Software Engineer at Microsoft
            {
                lblJobTypeValue.Text = "Full-time";
                lblSalaryValue.Text = "$90,000 - $120,000 per year";
                txtDescription.Text = "Microsoft is seeking a talented Software Engineer to join our Windows development team. " +
                    "The ideal candidate will have strong skills in C#, .NET, and cloud technologies. " +
                    "Responsibilities include designing, coding, and testing new features for Windows operating system.";
                
                lstSkills.Items.Add("C#");
                lstSkills.Items.Add(".NET");
                lstSkills.Items.Add("Azure");
                lstSkills.Items.Add("SQL Server");
                lstSkills.Items.Add("Git");
            }
            else if (jobId == "102") // Web Developer at Google
            {
                lblJobTypeValue.Text = "Internship";
                lblSalaryValue.Text = "$30 - $40 per hour";
                txtDescription.Text = "Google is looking for a Web Developer intern to work on our front-end applications. " +
                    "You will be working with a team of experienced developers to build and maintain Google's web applications. " +
                    "This is a 3-month internship with possibility of extension.";
                
                lstSkills.Items.Add("JavaScript");
                lstSkills.Items.Add("React");
                lstSkills.Items.Add("HTML/CSS");
                lstSkills.Items.Add("TypeScript");
                lstSkills.Items.Add("Node.js");
            }
            else if (jobId == "103") // Data Scientist at Amazon
            {
                lblJobTypeValue.Text = "Full-time";
                lblSalaryValue.Text = "$110,000 - $150,000 per year";
                txtDescription.Text = "Amazon is seeking a Data Scientist to join our analytics team. " +
                    "The ideal candidate will have experience with machine learning, statistical analysis, and big data technologies. " +
                    "Responsibilities include developing algorithms and models to solve complex business problems.";
                
                lstSkills.Items.Add("Python");
                lstSkills.Items.Add("R");
                lstSkills.Items.Add("Machine Learning");
                lstSkills.Items.Add("SQL");
                lstSkills.Items.Add("Hadoop");
                lstSkills.Items.Add("Spark");
            }
            else if (jobId == "104") // AI Engineer at Nvidia
            {
                lblJobTypeValue.Text = "Full-time";
                lblSalaryValue.Text = "$120,000 - $160,000 per year";
                txtDescription.Text = "Nvidia is seeking an AI Engineer to work on cutting-edge deep learning technologies. " +
                    "The ideal candidate will have strong background in artificial intelligence, neural networks, and GPU computing. " +
                    "Responsibilities include developing and optimizing deep learning models for various applications.";
                
                lstSkills.Items.Add("Python");
                lstSkills.Items.Add("TensorFlow");
                lstSkills.Items.Add("PyTorch");
                lstSkills.Items.Add("CUDA");
                lstSkills.Items.Add("Deep Learning");
                lstSkills.Items.Add("Computer Vision");
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Open the application form
            JobApplicationForm applicationForm = new JobApplicationForm(jobId, jobTitle, company);
            applicationForm.ShowDialog();
            
            // Close the details form after application is submitted
            if (applicationForm.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
} 