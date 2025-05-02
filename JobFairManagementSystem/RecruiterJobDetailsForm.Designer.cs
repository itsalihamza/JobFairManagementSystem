namespace JobFairManagementSystem
{
    partial class RecruiterJobDetailsForm
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
            lblApplicantsValue = new Label();
            lblApplicants = new Label();
            lblVacanciesValue = new Label();
            lblVacancies = new Label();
            lblPostDateValue = new Label();
            lblPostDate = new Label();
            lblStatusValue = new Label();
            lblStatus = new Label();
            lblSalaryValue = new Label();
            lblSalary = new Label();
            lblJobTypeValue = new Label();
            lblJobType = new Label();
            lblJobTitleValue = new Label();
            lblJobTitle = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblRequiredSkills = new Label();
            lstRequiredSkills = new ListBox();
            lblApplicantsList = new Label();
            dgvApplicants = new DataGridView();
            ApplicantId = new DataGridViewTextBoxColumn();
            ApplicantName = new DataGridViewTextBoxColumn();
            ApplicantFastId = new DataGridViewTextBoxColumn();
            AppliedDate = new DataGridViewTextBoxColumn();
            ApplicantStatus = new DataGridViewTextBoxColumn();
            btnViewApplicant = new Button();
            btnEdit = new Button();
            btnChangeStatus = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).BeginInit();
            SuspendLayout();
            
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(320, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(165, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "JOB DETAILS";
            
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblApplicantsValue);
            panel1.Controls.Add(lblApplicants);
            panel1.Controls.Add(lblVacanciesValue);
            panel1.Controls.Add(lblVacancies);
            panel1.Controls.Add(lblPostDateValue);
            panel1.Controls.Add(lblPostDate);
            panel1.Controls.Add(lblStatusValue);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblSalaryValue);
            panel1.Controls.Add(lblSalary);
            panel1.Controls.Add(lblJobTypeValue);
            panel1.Controls.Add(lblJobType);
            panel1.Controls.Add(lblJobTitleValue);
            panel1.Controls.Add(lblJobTitle);
            panel1.Location = new Point(30, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 190);
            panel1.TabIndex = 1;
            
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
            lblJobTitleValue.Location = new Point(160, 20);
            lblJobTitleValue.Name = "lblJobTitleValue";
            lblJobTitleValue.Size = new Size(133, 20);
            lblJobTitleValue.TabIndex = 1;
            lblJobTitleValue.Text = "Software Engineer";
            
            // lblJobType
            // 
            lblJobType.AutoSize = true;
            lblJobType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblJobType.Location = new Point(20, 50);
            lblJobType.Name = "lblJobType";
            lblJobType.Size = new Size(77, 20);
            lblJobType.TabIndex = 2;
            lblJobType.Text = "Job Type:";
            
            // lblJobTypeValue
            // 
            lblJobTypeValue.AutoSize = true;
            lblJobTypeValue.Location = new Point(160, 50);
            lblJobTypeValue.Name = "lblJobTypeValue";
            lblJobTypeValue.Size = new Size(68, 20);
            lblJobTypeValue.TabIndex = 3;
            lblJobTypeValue.Text = "Full-time";
            
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
            
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(20, 110);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(57, 20);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status:";
            
            // lblStatusValue
            // 
            lblStatusValue.AutoSize = true;
            lblStatusValue.Location = new Point(160, 110);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new Size(51, 20);
            lblStatusValue.TabIndex = 7;
            lblStatusValue.Text = "Active";
            
            // lblPostDate
            // 
            lblPostDate.AutoSize = true;
            lblPostDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPostDate.Location = new Point(20, 140);
            lblPostDate.Name = "lblPostDate";
            lblPostDate.Size = new Size(82, 20);
            lblPostDate.TabIndex = 8;
            lblPostDate.Text = "Post Date:";
            
            // lblPostDateValue
            // 
            lblPostDateValue.AutoSize = true;
            lblPostDateValue.Location = new Point(160, 140);
            lblPostDateValue.Name = "lblPostDateValue";
            lblPostDateValue.Size = new Size(85, 20);
            lblPostDateValue.TabIndex = 9;
            lblPostDateValue.Text = "2023-04-01";
            
            // lblVacancies
            // 
            lblVacancies.AutoSize = true;
            lblVacancies.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVacancies.Location = new Point(400, 50);
            lblVacancies.Name = "lblVacancies";
            lblVacancies.Size = new Size(83, 20);
            lblVacancies.TabIndex = 10;
            lblVacancies.Text = "Vacancies:";
            
            // lblVacanciesValue
            // 
            lblVacanciesValue.AutoSize = true;
            lblVacanciesValue.Location = new Point(550, 50);
            lblVacanciesValue.Name = "lblVacanciesValue";
            lblVacanciesValue.Size = new Size(25, 20);
            lblVacanciesValue.TabIndex = 11;
            lblVacanciesValue.Text = "20";
            
            // lblApplicants
            // 
            lblApplicants.AutoSize = true;
            lblApplicants.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApplicants.Location = new Point(400, 80);
            lblApplicants.Name = "lblApplicants";
            lblApplicants.Size = new Size(126, 20);
            lblApplicants.TabIndex = 12;
            lblApplicants.Text = "Total Applicants:";
            
            // lblApplicantsValue
            // 
            lblApplicantsValue.AutoSize = true;
            lblApplicantsValue.Location = new Point(550, 80);
            lblApplicantsValue.Name = "lblApplicantsValue";
            lblApplicantsValue.Size = new Size(25, 20);
            lblApplicantsValue.TabIndex = 13;
            lblApplicantsValue.Text = "15";
            
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(30, 280);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(95, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ControlLightLight;
            txtDescription.Location = new Point(30, 310);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(740, 100);
            txtDescription.TabIndex = 3;
            
            // lblRequiredSkills
            // 
            lblRequiredSkills.AutoSize = true;
            lblRequiredSkills.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRequiredSkills.Location = new Point(30, 430);
            lblRequiredSkills.Name = "lblRequiredSkills";
            lblRequiredSkills.Size = new Size(120, 20);
            lblRequiredSkills.TabIndex = 4;
            lblRequiredSkills.Text = "Required Skills:";
            
            // lstRequiredSkills
            // 
            lstRequiredSkills.FormattingEnabled = true;
            lstRequiredSkills.ItemHeight = 20;
            lstRequiredSkills.Location = new Point(30, 460);
            lstRequiredSkills.Name = "lstRequiredSkills";
            lstRequiredSkills.Size = new Size(250, 144);
            lstRequiredSkills.TabIndex = 5;
            
            // lblApplicantsList
            // 
            lblApplicantsList.AutoSize = true;
            lblApplicantsList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApplicantsList.Location = new Point(300, 430);
            lblApplicantsList.Name = "lblApplicantsList";
            lblApplicantsList.Size = new Size(88, 20);
            lblApplicantsList.TabIndex = 6;
            lblApplicantsList.Text = "Applicants:";
            
            // dgvApplicants
            // 
            dgvApplicants.AllowUserToAddRows = false;
            dgvApplicants.AllowUserToDeleteRows = false;
            dgvApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicants.Columns.AddRange(new DataGridViewColumn[] { ApplicantId, ApplicantName, ApplicantFastId, AppliedDate, ApplicantStatus });
            dgvApplicants.Location = new Point(300, 460);
            dgvApplicants.MultiSelect = false;
            dgvApplicants.Name = "dgvApplicants";
            dgvApplicants.ReadOnly = true;
            dgvApplicants.RowHeadersWidth = 51;
            dgvApplicants.RowTemplate.Height = 29;
            dgvApplicants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicants.Size = new Size(470, 144);
            dgvApplicants.TabIndex = 7;
            
            // ApplicantId
            // 
            ApplicantId.HeaderText = "ID";
            ApplicantId.MinimumWidth = 6;
            ApplicantId.Name = "ApplicantId";
            ApplicantId.ReadOnly = true;
            ApplicantId.Width = 50;
            
            // ApplicantName
            // 
            ApplicantName.HeaderText = "Name";
            ApplicantName.MinimumWidth = 6;
            ApplicantName.Name = "ApplicantName";
            ApplicantName.ReadOnly = true;
            ApplicantName.Width = 120;
            
            // ApplicantFastId
            // 
            ApplicantFastId.HeaderText = "FAST ID";
            ApplicantFastId.MinimumWidth = 6;
            ApplicantFastId.Name = "ApplicantFastId";
            ApplicantFastId.ReadOnly = true;
            ApplicantFastId.Width = 90;
            
            // AppliedDate
            // 
            AppliedDate.HeaderText = "Applied Date";
            AppliedDate.MinimumWidth = 6;
            AppliedDate.Name = "AppliedDate";
            AppliedDate.ReadOnly = true;
            AppliedDate.Width = 110;
            
            // ApplicantStatus
            // 
            ApplicantStatus.HeaderText = "Status";
            ApplicantStatus.MinimumWidth = 6;
            ApplicantStatus.Name = "ApplicantStatus";
            ApplicantStatus.ReadOnly = true;
            ApplicantStatus.Width = 90;
            
            // btnViewApplicant
            // 
            btnViewApplicant.Location = new Point(300, 620);
            btnViewApplicant.Name = "btnViewApplicant";
            btnViewApplicant.Size = new Size(150, 40);
            btnViewApplicant.TabIndex = 8;
            btnViewApplicant.Text = "View Applicant";
            btnViewApplicant.UseVisualStyleBackColor = true;
            btnViewApplicant.Click += btnViewApplicant_Click;
            
            // btnEdit
            // 
            btnEdit.BackColor = Color.RoyalBlue;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(470, 620);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 40);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit Job";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            
            // btnChangeStatus
            // 
            btnChangeStatus.BackColor = Color.DarkOrange;
            btnChangeStatus.ForeColor = Color.White;
            btnChangeStatus.Location = new Point(580, 620);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(100, 40);
            btnChangeStatus.TabIndex = 10;
            btnChangeStatus.Text = "Change Status";
            btnChangeStatus.UseVisualStyleBackColor = false;
            btnChangeStatus.Click += btnChangeStatus_Click;
            
            // btnClose
            // 
            btnClose.Location = new Point(690, 620);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 40);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            
            // RecruiterJobDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 680);
            Controls.Add(btnClose);
            Controls.Add(btnChangeStatus);
            Controls.Add(btnEdit);
            Controls.Add(btnViewApplicant);
            Controls.Add(dgvApplicants);
            Controls.Add(lblApplicantsList);
            Controls.Add(lstRequiredSkills);
            Controls.Add(lblRequiredSkills);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "RecruiterJobDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Job Details";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Label lblApplicantsValue;
        private Label lblApplicants;
        private Label lblVacanciesValue;
        private Label lblVacancies;
        private Label lblPostDateValue;
        private Label lblPostDate;
        private Label lblStatusValue;
        private Label lblStatus;
        private Label lblSalaryValue;
        private Label lblSalary;
        private Label lblJobTypeValue;
        private Label lblJobType;
        private Label lblJobTitleValue;
        private Label lblJobTitle;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblRequiredSkills;
        private ListBox lstRequiredSkills;
        private Label lblApplicantsList;
        private DataGridView dgvApplicants;
        private DataGridViewTextBoxColumn ApplicantId;
        private DataGridViewTextBoxColumn ApplicantName;
        private DataGridViewTextBoxColumn ApplicantFastId;
        private DataGridViewTextBoxColumn AppliedDate;
        private DataGridViewTextBoxColumn ApplicantStatus;
        private Button btnViewApplicant;
        private Button btnEdit;
        private Button btnChangeStatus;
        private Button btnClose;
    }
} 