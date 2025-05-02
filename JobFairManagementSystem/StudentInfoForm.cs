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
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
            cmbDegree.SelectedIndex = 0; // Default to CS
            cmbSemester.SelectedIndex = 0; // Default to 1
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fastId = txtFastId.Text.Trim();
            string degreeProgram = cmbDegree.SelectedItem.ToString();
            int semester = int.Parse(cmbSemester.SelectedItem.ToString());
            float gpa = 0;

            // Simple validation
            if (string.IsNullOrEmpty(fastId))
            {
                MessageBox.Show("Please enter your FAST ID.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(txtGPA.Text, out gpa) || gpa < 0 || gpa > 4.0)
            {
                MessageBox.Show("Please enter a valid GPA (0.0 - 4.0).", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Here we would normally save the student info to the database
            // For now, we'll just show a success message

            MessageBox.Show("Student information saved successfully!", 
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Open the skill entry form
            StudentSkillsForm skillsForm = new StudentSkillsForm();
            this.Hide();
            skillsForm.FormClosed += (s, args) => this.Close();
            skillsForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 