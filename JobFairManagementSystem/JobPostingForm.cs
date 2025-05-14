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
    public partial class JobPostingForm : Form
    {
        private int companyId;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";
        private List<string> skills = new List<string>();
        private Label lblCompanyNameValue;

        public JobPostingForm(int companyId)
        {
            InitializeComponent();
            this.companyId = companyId;
            
            // Setup job type combobox
            cmbJobType.Items.AddRange(new string[] { "Full-time", "Internship" });
            cmbJobType.SelectedIndex = 0;
            
            // Create the company name label dynamically since it's missing from the Designer
            lblCompanyNameValue = new Label();
            lblCompanyNameValue.AutoSize = true;
            lblCompanyNameValue.Location = new Point(200, 80);
            lblCompanyNameValue.Name = "lblCompanyNameValue";
            lblCompanyNameValue.Size = new Size(100, 20);
            lblCompanyNameValue.Text = "Loading...";
            this.Controls.Add(lblCompanyNameValue);
            
            // Load company information
            LoadCompanyInfo();
        }

        private void LoadCompanyInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT CompanyName FROM Companies WHERE CompanyID = @CompanyID";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CompanyID", companyId);
                        string companyName = (string)command.ExecuteScalar();
                        
                        if (!string.IsNullOrEmpty(companyName))
                        {
                            lblCompanyNameValue.Text = companyName;
                        }
                        else
                        {
                            MessageBox.Show("Company information not found.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading company information: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            string skill = txtSkill.Text.Trim();
            if (string.IsNullOrEmpty(skill))
            {
                MessageBox.Show("Please enter a skill.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!skills.Contains(skill))
            {
                skills.Add(skill);
                lstSkills.Items.Add(skill);
                txtSkill.Clear();
                txtSkill.Focus();
            }
            else
            {
                MessageBox.Show("This skill is already in the list.", "Duplicate Skill", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {
            if (lstSkills.SelectedIndex != -1)
            {
                skills.RemoveAt(lstSkills.SelectedIndex);
                lstSkills.Items.RemoveAt(lstSkills.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a skill to remove.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtJobTitle.Text))
            {
                MessageBox.Show("Please enter a job title.", 
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                MessageBox.Show("Please enter a salary range.", 
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalary.Focus();
                return;
            }

            if (lstSkills.Items.Count == 0)
            {
                MessageBox.Show("Please add at least one required skill.", 
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSkill.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a job description.", 
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = @"
                        INSERT INTO JobPostings (
                            CompanyID,
                            JobTitle,
                            JobType,
                            SalaryRange,
                            RequiredSkills,
                            Description
                        )
                        VALUES (
                            @CompanyID,
                            @JobTitle,
                            @JobType,
                            @SalaryRange,
                            @RequiredSkills,
                            @Description
                        )";
                    
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Join skills list into a comma-separated string
                        string requiredSkills = string.Join(", ", skills);
                        
                        command.Parameters.AddWithValue("@CompanyID", companyId);
                        command.Parameters.AddWithValue("@JobTitle", txtJobTitle.Text.Trim());
                        command.Parameters.AddWithValue("@JobType", cmbJobType.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@SalaryRange", txtSalary.Text.Trim());
                        command.Parameters.AddWithValue("@RequiredSkills", requiredSkills);
                        command.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                        
                        command.ExecuteNonQuery();
                        
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error posting job: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
} 