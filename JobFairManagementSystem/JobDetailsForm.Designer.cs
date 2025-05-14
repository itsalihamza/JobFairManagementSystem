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
            lblJobTitle = new Label();
            lblJobTitleValue = new Label();
            lblCompany = new Label();
            lblCompanyValue = new Label();
            lblLocation = new Label();
            lblLocationValue = new Label();
            lblSector = new Label();
            lblSectorValue = new Label();
            lblJobType = new Label();
            lblJobTypeValue = new Label();
            lblSalary = new Label();
            lblSalaryValue = new Label();
            lblSkills = new Label();
            lblSkillMatch = new Label();
            lstSkills = new ListBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnClose = new Button();
            btnApply = new Button();
            SuspendLayout();
            
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblJobTitle.Location = new Point(20, 20);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(73, 20);
            lblJobTitle.TabIndex = 0;
            lblJobTitle.Text = "Job Title:";
            
            // lblJobTitleValue
            // 
            lblJobTitleValue.AutoSize = true;
            lblJobTitleValue.Location = new Point(140, 20);
            lblJobTitleValue.Name = "lblJobTitleValue";
            lblJobTitleValue.Size = new Size(50, 20);
            lblJobTitleValue.TabIndex = 1;
            lblJobTitleValue.Text = "[Title]";
            
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompany.Location = new Point(20, 50);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(80, 20);
            lblCompany.TabIndex = 2;
            lblCompany.Text = "Company:";
            
            // lblCompanyValue
            // 
            lblCompanyValue.AutoSize = true;
            lblCompanyValue.Location = new Point(140, 50);
            lblCompanyValue.Name = "lblCompanyValue";
            lblCompanyValue.Size = new Size(80, 20);
            lblCompanyValue.TabIndex = 3;
            lblCompanyValue.Text = "[Company]";

            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLocation.Location = new Point(20, 80);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(75, 20);
            lblLocation.TabIndex = 4;
            lblLocation.Text = "Location:";
            
            // lblLocationValue
            // 
            lblLocationValue.AutoSize = true;
            lblLocationValue.Location = new Point(140, 80);
            lblLocationValue.Name = "lblLocationValue";
            lblLocationValue.Size = new Size(75, 20);
            lblLocationValue.TabIndex = 5;
            lblLocationValue.Text = "[Location]";
            
            // lblSector
            // 
            lblSector.AutoSize = true;
            lblSector.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSector.Location = new Point(20, 110);
            lblSector.Name = "lblSector";
            lblSector.Size = new Size(58, 20);
            lblSector.TabIndex = 6;
            lblSector.Text = "Sector:";
            
            // lblSectorValue
            // 
            lblSectorValue.AutoSize = true;
            lblSectorValue.Location = new Point(140, 110);
            lblSectorValue.Name = "lblSectorValue";
            lblSectorValue.Size = new Size(58, 20);
            lblSectorValue.TabIndex = 7;
            lblSectorValue.Text = "[Sector]";
            
            // lblJobType
            // 
            lblJobType.AutoSize = true;
            lblJobType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblJobType.Location = new Point(20, 140);
            lblJobType.Name = "lblJobType";
            lblJobType.Size = new Size(77, 20);
            lblJobType.TabIndex = 8;
            lblJobType.Text = "Job Type:";
            
            // lblJobTypeValue
            // 
            lblJobTypeValue.AutoSize = true;
            lblJobTypeValue.Location = new Point(140, 140);
            lblJobTypeValue.Name = "lblJobTypeValue";
            lblJobTypeValue.Size = new Size(80, 20);
            lblJobTypeValue.TabIndex = 9;
            lblJobTypeValue.Text = "[Job Type]";
            
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSalary.Location = new Point(20, 170);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(105, 20);
            lblSalary.TabIndex = 10;
            lblSalary.Text = "Salary Range:";
            
            // lblSalaryValue
            // 
            lblSalaryValue.AutoSize = true;
            lblSalaryValue.Location = new Point(140, 170);
            lblSalaryValue.Name = "lblSalaryValue";
            lblSalaryValue.Size = new Size(60, 20);
            lblSalaryValue.TabIndex = 11;
            lblSalaryValue.Text = "[Salary]";
            
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSkills.Location = new Point(20, 200);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(119, 20);
            lblSkills.TabIndex = 12;
            lblSkills.Text = "Required Skills:";
            
            // lblSkillMatch
            // 
            lblSkillMatch.AutoSize = true;
            lblSkillMatch.Location = new Point(20, 300);
            lblSkillMatch.Name = "lblSkillMatch";
            lblSkillMatch.Size = new Size(121, 20);
            lblSkillMatch.TabIndex = 13;
            lblSkillMatch.Text = "Skill Match Info";
            lblSkillMatch.Visible = false;
            
            // lstSkills
            // 
            lstSkills.FormattingEnabled = true;
            lstSkills.ItemHeight = 20;
            lstSkills.Location = new Point(20, 225);
            lstSkills.Name = "lstSkills";
            lstSkills.Size = new Size(200, 64);
            lstSkills.TabIndex = 14;
            
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(20, 330);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(94, 20);
            lblDescription.TabIndex = 15;
            lblDescription.Text = "Description:";
            
            // txtDescription
            // 
            txtDescription.Location = new Point(20, 355);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(460, 100);
            txtDescription.TabIndex = 16;
            
            // btnClose
            // 
            btnClose.Location = new Point(300, 465);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            
            // btnApply
            // 
            btnApply.BackColor = Color.ForestGreen;
            btnApply.ForeColor = Color.White;
            btnApply.Location = new Point(400, 465);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(80, 29);
            btnApply.TabIndex = 18;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            
            // JobDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 510);
            Controls.Add(btnApply);
            Controls.Add(btnClose);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(lstSkills);
            Controls.Add(lblSkillMatch);
            Controls.Add(lblSkills);
            Controls.Add(lblSalaryValue);
            Controls.Add(lblSalary);
            Controls.Add(lblJobTypeValue);
            Controls.Add(lblJobType);
            Controls.Add(lblSectorValue);
            Controls.Add(lblSector);
            Controls.Add(lblLocationValue);
            Controls.Add(lblLocation);
            Controls.Add(lblCompanyValue);
            Controls.Add(lblCompany);
            Controls.Add(lblJobTitleValue);
            Controls.Add(lblJobTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "JobDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Job Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJobTitle;
        private Label lblJobTitleValue;
        private Label lblCompany;
        private Label lblCompanyValue;
        private Label lblLocation;
        private Label lblLocationValue;
        private Label lblSector;
        private Label lblSectorValue;
        private Label lblJobType;
        private Label lblJobTypeValue;
        private Label lblSalary;
        private Label lblSalaryValue;
        private Label lblSkills;
        private Label lblSkillMatch;
        private ListBox lstSkills;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnClose;
        private Button btnApply;
    }
} 