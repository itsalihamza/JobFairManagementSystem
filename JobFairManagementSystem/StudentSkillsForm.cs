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
    public partial class StudentSkillsForm : Form
    {
        private List<string> skills = new List<string>();
        private List<string> certifications = new List<string>();

        public StudentSkillsForm()
        {
            InitializeComponent();
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
                MessageBox.Show("This skill is already in your list.", "Duplicate Skill", 
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

        private void btnAddCert_Click(object sender, EventArgs e)
        {
            string certTitle = txtCertTitle.Text.Trim();
            string certIssuer = txtCertIssuer.Text.Trim();
            DateTime issueDate = dtpCertDate.Value;

            if (string.IsNullOrEmpty(certTitle) || string.IsNullOrEmpty(certIssuer))
            {
                MessageBox.Show("Please enter both the certification title and issuer.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string certification = $"{certTitle} by {certIssuer} ({issueDate.ToShortDateString()})";
            
            if (!certifications.Contains(certification))
            {
                certifications.Add(certification);
                lstCertifications.Items.Add(certification);
                txtCertTitle.Clear();
                txtCertIssuer.Clear();
                dtpCertDate.Value = DateTime.Today;
                txtCertTitle.Focus();
            }
            else
            {
                MessageBox.Show("This certification is already in your list.", "Duplicate Certification", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveCert_Click(object sender, EventArgs e)
        {
            if (lstCertifications.SelectedIndex != -1)
            {
                certifications.RemoveAt(lstCertifications.SelectedIndex);
                lstCertifications.Items.RemoveAt(lstCertifications.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a certification to remove.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Here we would normally save the skills and certifications to the database
            // For now, we'll just show a success message

            MessageBox.Show("Skills and certifications saved successfully!", 
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Redirect to student dashboard
            StudentDashboard dashboard = new StudentDashboard();
            this.Hide();
            dashboard.FormClosed += (s, args) => this.Close();
            dashboard.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel? All skills and certifications will be lost.", 
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
} 