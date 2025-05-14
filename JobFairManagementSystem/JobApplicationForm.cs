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
    public partial class JobApplicationForm : Form
    {
        private string jobId;
        private string jobTitle;
        private string company;
        private int studentId;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";

        public JobApplicationForm(string jobId, string jobTitle, string company, int studentId)
        {
            InitializeComponent();
            this.jobId = jobId;
            this.jobTitle = jobTitle;
            this.company = company;
            this.studentId = studentId;
            
            // Set job information
            lblJobTitleValue.Text = jobTitle;
            lblCompanyValue.Text = company;

            // Load student data - this will be used for the database operations but not displayed in the form
            LoadStudentData();
        }
        
        private void LoadStudentData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            s.FAST_ID,
                            s.DegreeProgram,
                            s.CurrentSemester,
                            s.GPA,
                            u.FullName,
                            u.Email
                        FROM Students s
                        JOIN Users u ON s.UserID = u.UserID
                        WHERE s.StudentID = @StudentID";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // We're retrieving the data, but not displaying it in labels
                                // since those labels don't exist in the actual form
                                // We could use this data for submission if needed
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCoverLetter.Text))
            {
                MessageBox.Show("Please enter a cover letter.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCoverLetter.Focus();
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Check if already applied
                    string checkQuery = @"
                        SELECT COUNT(*)
                        FROM Applications
                        WHERE StudentID = @StudentID
                        AND JobID = @JobID";
                    
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@StudentID", studentId);
                        checkCommand.Parameters.AddWithValue("@JobID", jobId);
                        
                        int applicationCount = (int)checkCommand.ExecuteScalar();
                        
                        if (applicationCount > 0)
                        {
                            MessageBox.Show("You have already applied for this job.",
                                "Duplicate Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    
                    // Insert application
                    string insertQuery = @"
                        INSERT INTO Applications (
                            StudentID, 
                            JobID, 
                            ApplicationStatus, 
                            ApplicationDate
                        )
                        VALUES (
                            @StudentID,
                            @JobID,
                            'Pending',
                            GETDATE()
                        )";
                    
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@StudentID", studentId);
                        insertCommand.Parameters.AddWithValue("@JobID", jobId);
                        
                        insertCommand.ExecuteNonQuery();
                        
                        MessageBox.Show("Your application has been submitted successfully!",
                            "Application Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting application: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chkIncludeResume_CheckedChanged(object sender, EventArgs e)
        {
            btnBrowse.Enabled = chkIncludeResume.Checked;
            txtResumePath.Enabled = chkIncludeResume.Checked;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Set up the file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Resume",
                Filter = "PDF Files (*.pdf)|*.pdf|Word Documents (*.doc;*.docx)|*.doc;*.docx|All Files (*.*)|*.*",
                FilterIndex = 1
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtResumePath.Text = openFileDialog.FileName;
            }
        }
    }
} 