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
    public partial class JobApplicationForm : Form
    {
        private string jobId;
        private string jobTitle;
        private string company;

        public JobApplicationForm(string jobId, string jobTitle, string company)
        {
            InitializeComponent();
            this.jobId = jobId;
            this.jobTitle = jobTitle;
            this.company = company;
            
            // Set labels
            lblJobTitle.Text = jobTitle;
            lblCompany.Text = company;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if cover letter is provided
            if (string.IsNullOrEmpty(txtCoverLetter.Text.Trim()))
            {
                MessageBox.Show("Please provide a cover letter.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // In a real application, this would save the application to the database
            MessageBox.Show("Your application has been submitted successfully!", 
                "Application Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Return OK result to the parent form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this application?", 
                "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
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