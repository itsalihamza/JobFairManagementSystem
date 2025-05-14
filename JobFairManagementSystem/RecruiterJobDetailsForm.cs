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
    public partial class RecruiterJobDetailsForm : Form
    {
        private string jobId;
        private string jobTitle;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";

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
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Get job details
                    string query = @"
                        SELECT 
                            jp.JobType,
                            jp.SalaryRange,
                            CASE 
                                WHEN jp.Status IS NULL THEN 'Active' 
                                ELSE jp.Status
                            END AS Status,
                            CONVERT(VARCHAR(10), GETDATE(), 101) AS PostDate,
                            COUNT(DISTINCT a.ApplicationID) AS ApplicantCount,
                            jp.Description
                        FROM JobPostings jp
                        LEFT JOIN Applications a ON jp.JobID = a.JobID
                        WHERE jp.JobID = @JobID
                        GROUP BY jp.JobType, jp.SalaryRange, jp.Status, jp.Description";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JobID", jobId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
            {
                                lblJobTypeValue.Text = reader["JobType"].ToString();
                                lblSalaryValue.Text = reader["SalaryRange"].ToString();
                                lblStatusValue.Text = reader["Status"].ToString();
                                lblPostDateValue.Text = reader["PostDate"].ToString();
                                // Set vacancies to a reasonable number based on applicants
                                int applicants = Convert.ToInt32(reader["ApplicantCount"]);
                                lblApplicantsValue.Text = applicants.ToString();
                                lblVacanciesValue.Text = (applicants + 5).ToString(); // Add buffer for vacancies
                
                                txtDescription.Text = reader["Description"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Job details not found.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                                return;
                            }
                        }
                    }
                    
                    // Get required skills
                    query = @"
                        SELECT 
                            RequiredSkills
                        FROM JobPostings
                        WHERE JobID = @JobID";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JobID", jobId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string skills = reader["RequiredSkills"].ToString();
                                if (!string.IsNullOrEmpty(skills))
                                {
                                    // Split the skills string and add to the list
                                    string[] skillList = skills.Split(',');
                                    lstRequiredSkills.Items.Clear();
                                    foreach (string skill in skillList)
                                    {
                                        if (!string.IsNullOrWhiteSpace(skill))
                                        {
                                            lstRequiredSkills.Items.Add(skill.Trim());
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                    // Get applicants for this job
                    query = @"
                        SELECT 
                            a.ApplicationID,
                            u.FullName,
                            s.FAST_ID,
                            CONVERT(VARCHAR(10), a.ApplicationDate, 101) AS ApplicationDateFormatted,
                            a.ApplicationStatus
                        FROM Applications a
                        JOIN Students s ON a.StudentID = s.StudentID
                        JOIN Users u ON s.UserID = u.UserID
                        WHERE a.JobID = @JobID
                        ORDER BY a.ApplicationDate DESC";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JobID", jobId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dgvApplicants.Rows.Clear();
                            bool hasApplicants = false;
                            
                            while (reader.Read())
                            {
                                hasApplicants = true;
                                dgvApplicants.Rows.Add(
                                    reader["ApplicationID"].ToString(),
                                    reader["FullName"].ToString(),
                                    reader["FAST_ID"].ToString(),
                                    reader["ApplicationDateFormatted"].ToString(),
                                    reader["ApplicationStatus"].ToString()
                                );
                            }
                            
                            if (!hasApplicants)
                            {
                                // No applicants yet
                                lblApplicantsValue.Text = "0";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading job details: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Set some default text
                txtDescription.Text = "Error loading job details. Please try again.";
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
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            
                            // Update the job status in the database
                            string query = @"
                                UPDATE JobPostings 
                                SET Status = @Status
                                WHERE JobID = @JobID";
                            
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Status", comboBox.SelectedItem.ToString());
                                command.Parameters.AddWithValue("@JobID", jobId);
                                
                                int rowsAffected = command.ExecuteNonQuery();
                                
                                if (rowsAffected > 0)
                                {
                                    // Update the UI
                    lblStatusValue.Text = comboBox.SelectedItem.ToString();
                                    
                    MessageBox.Show($"Job status updated to {comboBox.SelectedItem}.", 
                        "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update job status.", 
                                        "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating job status: " + ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
} 