namespace JobFairManagementSystem
{
    partial class JobPostingForm
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
            lblJobTitle = new Label();
            txtJobTitle = new TextBox();
            lblJobType = new Label();
            cmbJobType = new ComboBox();
            lblSalary = new Label();
            txtSalary = new TextBox();
            lblVacancies = new Label();
            txtVacancies = new TextBox();
            lblPostDate = new Label();
            dtpPostDate = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblSkills = new Label();
            txtSkill = new TextBox();
            btnAddSkill = new Button();
            btnRemoveSkill = new Button();
            lstSkills = new ListBox();
            btnPost = new Button();
            btnCancel = new Button();
            SuspendLayout();
            
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(260, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(182, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "POST A JOB";
            
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblJobTitle.Location = new Point(50, 80);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(73, 20);
            lblJobTitle.TabIndex = 1;
            lblJobTitle.Text = "Job Title:";
            
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(200, 80);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(450, 27);
            txtJobTitle.TabIndex = 0;
            
            // lblJobType
            // 
            lblJobType.AutoSize = true;
            lblJobType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblJobType.Location = new Point(50, 120);
            lblJobType.Name = "lblJobType";
            lblJobType.Size = new Size(77, 20);
            lblJobType.TabIndex = 3;
            lblJobType.Text = "Job Type:";
            
            // cmbJobType
            // 
            cmbJobType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJobType.FormattingEnabled = true;
            cmbJobType.Items.AddRange(new object[] { "Full-time", "Part-time", "Internship", "Contract", "Freelance" });
            cmbJobType.Location = new Point(200, 120);
            cmbJobType.Name = "cmbJobType";
            cmbJobType.Size = new Size(200, 28);
            cmbJobType.TabIndex = 1;
            
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSalary.Location = new Point(50, 160);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(102, 20);
            lblSalary.TabIndex = 5;
            lblSalary.Text = "Salary Range:";
            
            // txtSalary
            // 
            txtSalary.Location = new Point(200, 160);
            txtSalary.Name = "txtSalary";
            txtSalary.PlaceholderText = "e.g., $70,000 - $90,000 per year";
            txtSalary.Size = new Size(450, 27);
            txtSalary.TabIndex = 2;
            
            // lblVacancies
            // 
            lblVacancies.AutoSize = true;
            lblVacancies.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVacancies.Location = new Point(50, 200);
            lblVacancies.Name = "lblVacancies";
            lblVacancies.Size = new Size(83, 20);
            lblVacancies.TabIndex = 7;
            lblVacancies.Text = "Vacancies:";
            
            // txtVacancies
            // 
            txtVacancies.Location = new Point(200, 200);
            txtVacancies.Name = "txtVacancies";
            txtVacancies.Size = new Size(100, 27);
            txtVacancies.TabIndex = 3;
            txtVacancies.Text = "1";
            
            // lblPostDate
            // 
            lblPostDate.AutoSize = true;
            lblPostDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPostDate.Location = new Point(320, 200);
            lblPostDate.Name = "lblPostDate";
            lblPostDate.Size = new Size(82, 20);
            lblPostDate.TabIndex = 9;
            lblPostDate.Text = "Post Date:";
            
            // dtpPostDate
            // 
            dtpPostDate.Format = DateTimePickerFormat.Short;
            dtpPostDate.Location = new Point(410, 200);
            dtpPostDate.Name = "dtpPostDate";
            dtpPostDate.Size = new Size(150, 27);
            dtpPostDate.TabIndex = 4;
            
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(450, 120);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(57, 20);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status:";
            
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Draft", "Closed" });
            cmbStatus.Location = new Point(520, 120);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(130, 28);
            cmbStatus.TabIndex = 5;
            
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(50, 240);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(95, 20);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Description:";
            
            // txtDescription
            // 
            txtDescription.Location = new Point(200, 240);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(450, 150);
            txtDescription.TabIndex = 6;
            txtDescription.PlaceholderText = "Enter detailed job description here...";
            
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSkills.Location = new Point(50, 410);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(120, 20);
            lblSkills.TabIndex = 15;
            lblSkills.Text = "Required Skills:";
            
            // txtSkill
            // 
            txtSkill.Location = new Point(200, 410);
            txtSkill.Name = "txtSkill";
            txtSkill.Size = new Size(320, 27);
            txtSkill.TabIndex = 7;
            txtSkill.PlaceholderText = "Enter a skill and click Add";
            
            // btnAddSkill
            // 
            btnAddSkill.BackColor = Color.ForestGreen;
            btnAddSkill.ForeColor = Color.White;
            btnAddSkill.Location = new Point(530, 410);
            btnAddSkill.Name = "btnAddSkill";
            btnAddSkill.Size = new Size(60, 30);
            btnAddSkill.TabIndex = 8;
            btnAddSkill.Text = "Add";
            btnAddSkill.UseVisualStyleBackColor = false;
            btnAddSkill.Click += btnAddSkill_Click;
            
            // btnRemoveSkill
            // 
            btnRemoveSkill.BackColor = Color.Firebrick;
            btnRemoveSkill.ForeColor = Color.White;
            btnRemoveSkill.Location = new Point(590, 410);
            btnRemoveSkill.Name = "btnRemoveSkill";
            btnRemoveSkill.Size = new Size(60, 30);
            btnRemoveSkill.TabIndex = 9;
            btnRemoveSkill.Text = "Remove";
            btnRemoveSkill.UseVisualStyleBackColor = false;
            btnRemoveSkill.Click += btnRemoveSkill_Click;
            
            // lstSkills
            // 
            lstSkills.FormattingEnabled = true;
            lstSkills.ItemHeight = 20;
            lstSkills.Location = new Point(200, 450);
            lstSkills.Name = "lstSkills";
            lstSkills.Size = new Size(450, 104);
            lstSkills.TabIndex = 10;
            
            // btnPost
            // 
            btnPost.BackColor = Color.RoyalBlue;
            btnPost.ForeColor = Color.White;
            btnPost.Location = new Point(450, 580);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(100, 40);
            btnPost.TabIndex = 11;
            btnPost.Text = "Post Job";
            btnPost.UseVisualStyleBackColor = false;
            btnPost.Click += btnPost_Click;
            
            // btnCancel
            // 
            btnCancel.Location = new Point(550, 580);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            
            // JobPostingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(700, 650);
            Controls.Add(btnCancel);
            Controls.Add(btnPost);
            Controls.Add(lstSkills);
            Controls.Add(btnRemoveSkill);
            Controls.Add(btnAddSkill);
            Controls.Add(txtSkill);
            Controls.Add(lblSkills);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(dtpPostDate);
            Controls.Add(lblPostDate);
            Controls.Add(txtVacancies);
            Controls.Add(lblVacancies);
            Controls.Add(txtSalary);
            Controls.Add(lblSalary);
            Controls.Add(cmbJobType);
            Controls.Add(lblJobType);
            Controls.Add(txtJobTitle);
            Controls.Add(lblJobTitle);
            Controls.Add(lblTitle);
            Name = "JobPostingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Post a Job";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblJobTitle;
        private TextBox txtJobTitle;
        private Label lblJobType;
        private ComboBox cmbJobType;
        private Label lblSalary;
        private TextBox txtSalary;
        private Label lblVacancies;
        private TextBox txtVacancies;
        private Label lblPostDate;
        private DateTimePicker dtpPostDate;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblSkills;
        private TextBox txtSkill;
        private Button btnAddSkill;
        private Button btnRemoveSkill;
        private ListBox lstSkills;
        private Button btnPost;
        private Button btnCancel;
    }
} 