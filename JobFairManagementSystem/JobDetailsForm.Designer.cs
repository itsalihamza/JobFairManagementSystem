namespace JobFairManagementSystem
{
    partial class JobDetailsForm
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
            lblJobTypeValue = new Label();
            lblJobType = new Label();
            lblSalaryValue = new Label();
            lblSalary = new Label();
            lblJobTitleValue = new Label();
            lblJobTitle = new Label();
            lblCompanyValue = new Label();
            lblCompany = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblSkills = new Label();
            lstSkills = new ListBox();
            btnApply = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(240, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(165, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "JOB DETAILS";
            
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblJobTypeValue);
            panel1.Controls.Add(lblJobType);
            panel1.Controls.Add(lblSalaryValue);
            panel1.Controls.Add(lblSalary);
            panel1.Controls.Add(lblJobTitleValue);
            panel1.Controls.Add(lblJobTitle);
            panel1.Controls.Add(lblCompanyValue);
            panel1.Controls.Add(lblCompany);
            panel1.Location = new Point(50, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 150);
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
            lblCompanyValue.Location = new Point(160, 20);
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
            lblJobTitleValue.Location = new Point(160, 50);
            lblJobTitleValue.Name = "lblJobTitleValue";
            lblJobTitleValue.Size = new Size(133, 20);
            lblJobTitleValue.TabIndex = 3;
            lblJobTitleValue.Text = "Software Engineer";
            
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSalary.Location = new Point(20, 80);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(102, 20);
            lblSalary.TabIndex = 4;
            lblSalary.Text = "Salary Range:";
            
            // lblSalaryValue
            // 
            lblSalaryValue.AutoSize = true;
            lblSalaryValue.Location = new Point(160, 80);
            lblSalaryValue.Name = "lblSalaryValue";
            lblSalaryValue.Size = new Size(198, 20);
            lblSalaryValue.TabIndex = 5;
            lblSalaryValue.Text = "$90,000 - $120,000 per year";
            
            // lblJobType
            // 
            lblJobType.AutoSize = true;
            lblJobType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblJobType.Location = new Point(20, 110);
            lblJobType.Name = "lblJobType";
            lblJobType.Size = new Size(77, 20);
            lblJobType.TabIndex = 6;
            lblJobType.Text = "Job Type:";
            
            // lblJobTypeValue
            // 
            lblJobTypeValue.AutoSize = true;
            lblJobTypeValue.Location = new Point(160, 110);
            lblJobTypeValue.Name = "lblJobTypeValue";
            lblJobTypeValue.Size = new Size(68, 20);
            lblJobTypeValue.TabIndex = 7;
            lblJobTypeValue.Text = "Full-time";
            
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(50, 240);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(95, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ControlLightLight;
            txtDescription.Location = new Point(50, 270);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(550, 150);
            txtDescription.TabIndex = 3;
            
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSkills.Location = new Point(50, 440);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(120, 20);
            lblSkills.TabIndex = 4;
            lblSkills.Text = "Required Skills:";
            
            // lstSkills
            // 
            lstSkills.FormattingEnabled = true;
            lstSkills.ItemHeight = 20;
            lstSkills.Location = new Point(50, 470);
            lstSkills.Name = "lstSkills";
            lstSkills.Size = new Size(550, 100);
            lstSkills.TabIndex = 5;
            
            // btnApply
            // 
            btnApply.BackColor = Color.RoyalBlue;
            btnApply.ForeColor = Color.White;
            btnApply.Location = new Point(370, 590);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(110, 40);
            btnApply.TabIndex = 6;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            
            // btnClose
            // 
            btnClose.Location = new Point(490, 590);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 40);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            
            // JobDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(650, 650);
            Controls.Add(btnClose);
            Controls.Add(btnApply);
            Controls.Add(lstSkills);
            Controls.Add(lblSkills);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "JobDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Job Details";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Label lblJobTypeValue;
        private Label lblJobType;
        private Label lblSalaryValue;
        private Label lblSalary;
        private Label lblJobTitleValue;
        private Label lblJobTitle;
        private Label lblCompanyValue;
        private Label lblCompany;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblSkills;
        private ListBox lstSkills;
        private Button btnApply;
        private Button btnClose;
    }
} 