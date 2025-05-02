namespace JobFairManagementSystem
{
    partial class JobApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            panel1 = new Panel();
            lblJobTitleValue = new Label();
            lblJobTitle = new Label();
            lblCompanyValue = new Label();
            lblCompany = new Label();
            lblCoverLetter = new Label();
            txtCoverLetter = new TextBox();
            chkIncludeResume = new CheckBox();
            txtResumePath = new TextBox();
            btnBrowse = new Button();
            btnSubmit = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(220, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(202, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "JOB APPLICATION";
            
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblJobTitleValue);
            panel1.Controls.Add(lblJobTitle);
            panel1.Controls.Add(lblCompanyValue);
            panel1.Controls.Add(lblCompany);
            panel1.Location = new Point(50, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 100);
            panel1.TabIndex = 1;
            
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompany.Location = new Point(20, 20);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(81, 20);
            lblCompany.TabIndex = 0;
            lblCompany.Text = "Company:";
            
            // lblCompanyValue
            // 
            lblCompanyValue.AutoSize = true;
            lblCompanyValue.Location = new Point(120, 20);
            lblCompanyValue.Name = "lblCompanyValue";
            lblCompanyValue.Size = new Size(69, 20);
            lblCompanyValue.TabIndex = 1;
            lblCompanyValue.Text = "Microsoft";
            
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblJobTitle.Location = new Point(20, 50);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(73, 20);
            lblJobTitle.TabIndex = 2;
            lblJobTitle.Text = "Job Title:";
            
            // lblJobTitleValue
            // 
            lblJobTitleValue.AutoSize = true;
            lblJobTitleValue.Location = new Point(120, 50);
            lblJobTitleValue.Name = "lblJobTitleValue";
            lblJobTitleValue.Size = new Size(133, 20);
            lblJobTitleValue.TabIndex = 3;
            lblJobTitleValue.Text = "Software Engineer";
            
            // lblCoverLetter
            // 
            lblCoverLetter.AutoSize = true;
            lblCoverLetter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCoverLetter.Location = new Point(50, 180);
            lblCoverLetter.Name = "lblCoverLetter";
            lblCoverLetter.Size = new Size(99, 20);
            lblCoverLetter.TabIndex = 2;
            lblCoverLetter.Text = "Cover Letter:";
            
            // txtCoverLetter
            // 
            txtCoverLetter.Location = new Point(50, 210);
            txtCoverLetter.Multiline = true;
            txtCoverLetter.Name = "txtCoverLetter";
            txtCoverLetter.Size = new Size(550, 200);
            txtCoverLetter.TabIndex = 0;
            txtCoverLetter.PlaceholderText = "Enter your cover letter here...";
            
            // chkIncludeResume
            // 
            chkIncludeResume.AutoSize = true;
            chkIncludeResume.Checked = true;
            chkIncludeResume.CheckState = CheckState.Checked;
            chkIncludeResume.Location = new Point(50, 430);
            chkIncludeResume.Name = "chkIncludeResume";
            chkIncludeResume.Size = new Size(133, 24);
            chkIncludeResume.TabIndex = 1;
            chkIncludeResume.Text = "Include Resume";
            chkIncludeResume.UseVisualStyleBackColor = true;
            chkIncludeResume.CheckedChanged += chkIncludeResume_CheckedChanged;
            
            // txtResumePath
            // 
            txtResumePath.Location = new Point(50, 460);
            txtResumePath.Name = "txtResumePath";
            txtResumePath.ReadOnly = true;
            txtResumePath.Size = new Size(450, 27);
            txtResumePath.TabIndex = 2;
            
            // btnBrowse
            // 
            btnBrowse.Location = new Point(510, 460);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(90, 27);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.RoyalBlue;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(370, 510);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(110, 40);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            
            // btnCancel
            // 
            btnCancel.Location = new Point(490, 510);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            
            // JobApplicationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(650, 580);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(btnBrowse);
            Controls.Add(txtResumePath);
            Controls.Add(chkIncludeResume);
            Controls.Add(txtCoverLetter);
            Controls.Add(lblCoverLetter);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "JobApplicationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Job Application";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Label lblJobTitleValue;
        private Label lblJobTitle;
        private Label lblCompanyValue;
        private Label lblCompany;
        private Label lblCoverLetter;
        private TextBox txtCoverLetter;
        private CheckBox chkIncludeResume;
        private TextBox txtResumePath;
        private Button btnBrowse;
        private Button btnSubmit;
        private Button btnCancel;
    }
} 