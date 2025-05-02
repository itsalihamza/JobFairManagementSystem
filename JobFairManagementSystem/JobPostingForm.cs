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
    public partial class JobPostingForm : Form
    {
        private List<string> skills = new List<string>();

        public JobPostingForm()
        {
            InitializeComponent();
            
            // Initialize combo boxes
            cmbJobType.SelectedIndex = 0; // Default to Full-time
            cmbStatus.SelectedIndex = 0; // Default to Active
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
            // Validate form input
            if (string.IsNullOrEmpty(txtJobTitle.Text.Trim()))
            {
                MessageBox.Show("Please enter a job title.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJobTitle.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                MessageBox.Show("Please enter a job description.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }

            if (lstSkills.Items.Count == 0)
            {
                MessageBox.Show("Please add at least one required skill.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSkill.Focus();
                return;
            }

            if (!int.TryParse(txtVacancies.Text, out int vacancies) || vacancies <= 0)
            {
                MessageBox.Show("Please enter a valid number of vacancies.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVacancies.Focus();
                return;
            }

            // Get form data
            string jobTitle = txtJobTitle.Text.Trim();
            string description = txtDescription.Text.Trim();
            string salary = txtSalary.Text.Trim();
            string jobType = cmbJobType.SelectedItem.ToString();
            string status = cmbStatus.SelectedItem.ToString();
            int numVacancies = vacancies;
            DateTime postDate = dtpPostDate.Value;

            // In a real application, this would save the job posting to the database
            // For now, we'll just show a success message

            string message = $"Job posting for '{jobTitle}' has been created successfully.";
            MessageBox.Show(message, "Job Posted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
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