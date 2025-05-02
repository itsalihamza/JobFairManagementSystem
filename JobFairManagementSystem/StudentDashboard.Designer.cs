namespace JobFairManagementSystem
{
    partial class StudentDashboard
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
            lblWelcome = new Label();
            tabControl1 = new TabControl();
            tabJobFairs = new TabPage();
            btnViewFairDetails = new Button();
            btnRegisterForFair = new Button();
            dgvJobFairs = new DataGridView();
            FairId = new DataGridViewTextBoxColumn();
            FairName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Venue = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            tabJobs = new TabPage();
            btnApplyForJob = new Button();
            btnViewJobDetails = new Button();
            dgvJobs = new DataGridView();
            JobId = new DataGridViewTextBoxColumn();
            JobTitle = new DataGridViewTextBoxColumn();
            Company = new DataGridViewTextBoxColumn();
            JobType = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            tabApplications = new TabPage();
            dgvApplications = new DataGridView();
            ApplicationId = new DataGridViewTextBoxColumn();
            AppJobTitle = new DataGridViewTextBoxColumn();
            AppCompany = new DataGridViewTextBoxColumn();
            AppliedDate = new DataGridViewTextBoxColumn();
            AppStatus = new DataGridViewTextBoxColumn();
            tabInterviews = new TabPage();
            dgvInterviews = new DataGridView();
            InterviewId = new DataGridViewTextBoxColumn();
            IntCompany = new DataGridViewTextBoxColumn();
            IntJobTitle = new DataGridViewTextBoxColumn();
            IntDate = new DataGridViewTextBoxColumn();
            IntTime = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnLogout = new Button();
            btnRefresh = new Button();
            btnManageSkills = new Button();
            btnUpdateProfile = new Button();
            tabControl1.SuspendLayout();
            tabJobFairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobFairs).BeginInit();
            tabJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            tabApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();
            tabInterviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInterviews).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(30, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(268, 32);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Student Name";
            
            // tabControl1
            // 
            tabControl1.Controls.Add(tabJobFairs);
            tabControl1.Controls.Add(tabJobs);
            tabControl1.Controls.Add(tabApplications);
            tabControl1.Controls.Add(tabInterviews);
            tabControl1.Location = new Point(30, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(900, 450);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            
            // tabJobFairs
            // 
            tabJobFairs.Controls.Add(btnViewFairDetails);
            tabJobFairs.Controls.Add(btnRegisterForFair);
            tabJobFairs.Controls.Add(dgvJobFairs);
            tabJobFairs.Location = new Point(4, 29);
            tabJobFairs.Name = "tabJobFairs";
            tabJobFairs.Padding = new Padding(3);
            tabJobFairs.Size = new Size(892, 417);
            tabJobFairs.TabIndex = 0;
            tabJobFairs.Text = "Job Fairs";
            tabJobFairs.UseVisualStyleBackColor = true;
            
            // dgvJobFairs
            // 
            dgvJobFairs.AllowUserToAddRows = false;
            dgvJobFairs.AllowUserToDeleteRows = false;
            dgvJobFairs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobFairs.Columns.AddRange(new DataGridViewColumn[] { FairId, FairName, Date, Venue, Time });
            dgvJobFairs.Location = new Point(20, 20);
            dgvJobFairs.MultiSelect = false;
            dgvJobFairs.Name = "dgvJobFairs";
            dgvJobFairs.ReadOnly = true;
            dgvJobFairs.RowHeadersWidth = 51;
            dgvJobFairs.RowTemplate.Height = 29;
            dgvJobFairs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobFairs.Size = new Size(850, 300);
            dgvJobFairs.TabIndex = 0;
            
            // FairId
            // 
            FairId.HeaderText = "ID";
            FairId.MinimumWidth = 6;
            FairId.Name = "FairId";
            FairId.ReadOnly = true;
            FairId.Width = 50;
            
            // FairName
            // 
            FairName.HeaderText = "Fair Name";
            FairName.MinimumWidth = 6;
            FairName.Name = "FairName";
            FairName.ReadOnly = true;
            FairName.Width = 220;
            
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 125;
            
            // Venue
            // 
            Venue.HeaderText = "Venue";
            Venue.MinimumWidth = 6;
            Venue.Name = "Venue";
            Venue.ReadOnly = true;
            Venue.Width = 200;
            
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Width = 150;
            
            // btnRegisterForFair
            // 
            btnRegisterForFair.BackColor = Color.ForestGreen;
            btnRegisterForFair.ForeColor = Color.White;
            btnRegisterForFair.Location = new Point(720, 340);
            btnRegisterForFair.Name = "btnRegisterForFair";
            btnRegisterForFair.Size = new Size(150, 40);
            btnRegisterForFair.TabIndex = 1;
            btnRegisterForFair.Text = "Register";
            btnRegisterForFair.UseVisualStyleBackColor = false;
            btnRegisterForFair.Click += btnRegisterForFair_Click;
            
            // btnViewFairDetails
            // 
            btnViewFairDetails.Location = new Point(560, 340);
            btnViewFairDetails.Name = "btnViewFairDetails";
            btnViewFairDetails.Size = new Size(150, 40);
            btnViewFairDetails.TabIndex = 2;
            btnViewFairDetails.Text = "View Details";
            btnViewFairDetails.UseVisualStyleBackColor = true;
            btnViewFairDetails.Click += btnViewFairDetails_Click;
            
            // tabJobs
            // 
            tabJobs.Controls.Add(btnApplyForJob);
            tabJobs.Controls.Add(btnViewJobDetails);
            tabJobs.Controls.Add(dgvJobs);
            tabJobs.Location = new Point(4, 29);
            tabJobs.Name = "tabJobs";
            tabJobs.Padding = new Padding(3);
            tabJobs.Size = new Size(892, 417);
            tabJobs.TabIndex = 1;
            tabJobs.Text = "Available Jobs";
            tabJobs.UseVisualStyleBackColor = true;
            
            // dgvJobs
            // 
            dgvJobs.AllowUserToAddRows = false;
            dgvJobs.AllowUserToDeleteRows = false;
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Columns.AddRange(new DataGridViewColumn[] { JobId, JobTitle, Company, JobType, Status });
            dgvJobs.Location = new Point(20, 20);
            dgvJobs.MultiSelect = false;
            dgvJobs.Name = "dgvJobs";
            dgvJobs.ReadOnly = true;
            dgvJobs.RowHeadersWidth = 51;
            dgvJobs.RowTemplate.Height = 29;
            dgvJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobs.Size = new Size(850, 300);
            dgvJobs.TabIndex = 0;
            
            // JobId
            // 
            JobId.HeaderText = "ID";
            JobId.MinimumWidth = 6;
            JobId.Name = "JobId";
            JobId.ReadOnly = true;
            JobId.Width = 50;
            
            // JobTitle
            // 
            JobTitle.HeaderText = "Job Title";
            JobTitle.MinimumWidth = 6;
            JobTitle.Name = "JobTitle";
            JobTitle.ReadOnly = true;
            JobTitle.Width = 200;
            
            // Company
            // 
            Company.HeaderText = "Company";
            Company.MinimumWidth = 6;
            Company.Name = "Company";
            Company.ReadOnly = true;
            Company.Width = 180;
            
            // JobType
            // 
            JobType.HeaderText = "Type";
            JobType.MinimumWidth = 6;
            JobType.Name = "JobType";
            JobType.ReadOnly = true;
            JobType.Width = 120;
            
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 150;
            
            // btnViewJobDetails
            // 
            btnViewJobDetails.Location = new Point(560, 340);
            btnViewJobDetails.Name = "btnViewJobDetails";
            btnViewJobDetails.Size = new Size(150, 40);
            btnViewJobDetails.TabIndex = 1;
            btnViewJobDetails.Text = "View Details";
            btnViewJobDetails.UseVisualStyleBackColor = true;
            btnViewJobDetails.Click += btnViewJobDetails_Click;
            
            // btnApplyForJob
            // 
            btnApplyForJob.BackColor = Color.RoyalBlue;
            btnApplyForJob.ForeColor = Color.White;
            btnApplyForJob.Location = new Point(720, 340);
            btnApplyForJob.Name = "btnApplyForJob";
            btnApplyForJob.Size = new Size(150, 40);
            btnApplyForJob.TabIndex = 2;
            btnApplyForJob.Text = "Apply";
            btnApplyForJob.UseVisualStyleBackColor = false;
            btnApplyForJob.Click += btnApplyForJob_Click;
            
            // tabApplications
            // 
            tabApplications.Controls.Add(dgvApplications);
            tabApplications.Location = new Point(4, 29);
            tabApplications.Name = "tabApplications";
            tabApplications.Size = new Size(892, 417);
            tabApplications.TabIndex = 2;
            tabApplications.Text = "My Applications";
            tabApplications.UseVisualStyleBackColor = true;
            
            // dgvApplications
            // 
            dgvApplications.AllowUserToAddRows = false;
            dgvApplications.AllowUserToDeleteRows = false;
            dgvApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplications.Columns.AddRange(new DataGridViewColumn[] { ApplicationId, AppJobTitle, AppCompany, AppliedDate, AppStatus });
            dgvApplications.Location = new Point(20, 20);
            dgvApplications.MultiSelect = false;
            dgvApplications.Name = "dgvApplications";
            dgvApplications.ReadOnly = true;
            dgvApplications.RowHeadersWidth = 51;
            dgvApplications.RowTemplate.Height = 29;
            dgvApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplications.Size = new Size(850, 370);
            dgvApplications.TabIndex = 0;
            
            // ApplicationId
            // 
            ApplicationId.HeaderText = "ID";
            ApplicationId.MinimumWidth = 6;
            ApplicationId.Name = "ApplicationId";
            ApplicationId.ReadOnly = true;
            ApplicationId.Width = 50;
            
            // AppJobTitle
            // 
            AppJobTitle.HeaderText = "Job Title";
            AppJobTitle.MinimumWidth = 6;
            AppJobTitle.Name = "AppJobTitle";
            AppJobTitle.ReadOnly = true;
            AppJobTitle.Width = 220;
            
            // AppCompany
            // 
            AppCompany.HeaderText = "Company";
            AppCompany.MinimumWidth = 6;
            AppCompany.Name = "AppCompany";
            AppCompany.ReadOnly = true;
            AppCompany.Width = 200;
            
            // AppliedDate
            // 
            AppliedDate.HeaderText = "Applied Date";
            AppliedDate.MinimumWidth = 6;
            AppliedDate.Name = "AppliedDate";
            AppliedDate.ReadOnly = true;
            AppliedDate.Width = 125;
            
            // AppStatus
            // 
            AppStatus.HeaderText = "Status";
            AppStatus.MinimumWidth = 6;
            AppStatus.Name = "AppStatus";
            AppStatus.ReadOnly = true;
            AppStatus.Width = 150;
            
            // tabInterviews
            // 
            tabInterviews.Controls.Add(dgvInterviews);
            tabInterviews.Location = new Point(4, 29);
            tabInterviews.Name = "tabInterviews";
            tabInterviews.Size = new Size(892, 417);
            tabInterviews.TabIndex = 3;
            tabInterviews.Text = "My Interviews";
            tabInterviews.UseVisualStyleBackColor = true;
            
            // dgvInterviews
            // 
            dgvInterviews.AllowUserToAddRows = false;
            dgvInterviews.AllowUserToDeleteRows = false;
            dgvInterviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInterviews.Columns.AddRange(new DataGridViewColumn[] { InterviewId, IntCompany, IntJobTitle, IntDate, IntTime, Location });
            dgvInterviews.Location = new Point(20, 20);
            dgvInterviews.MultiSelect = false;
            dgvInterviews.Name = "dgvInterviews";
            dgvInterviews.ReadOnly = true;
            dgvInterviews.RowHeadersWidth = 51;
            dgvInterviews.RowTemplate.Height = 29;
            dgvInterviews.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInterviews.Size = new Size(850, 370);
            dgvInterviews.TabIndex = 0;
            
            // InterviewId
            // 
            InterviewId.HeaderText = "ID";
            InterviewId.MinimumWidth = 6;
            InterviewId.Name = "InterviewId";
            InterviewId.ReadOnly = true;
            InterviewId.Width = 50;
            
            // IntCompany
            // 
            IntCompany.HeaderText = "Company";
            IntCompany.MinimumWidth = 6;
            IntCompany.Name = "IntCompany";
            IntCompany.ReadOnly = true;
            IntCompany.Width = 180;
            
            // IntJobTitle
            // 
            IntJobTitle.HeaderText = "Job Title";
            IntJobTitle.MinimumWidth = 6;
            IntJobTitle.Name = "IntJobTitle";
            IntJobTitle.ReadOnly = true;
            IntJobTitle.Width = 180;
            
            // IntDate
            // 
            IntDate.HeaderText = "Date";
            IntDate.MinimumWidth = 6;
            IntDate.Name = "IntDate";
            IntDate.ReadOnly = true;
            IntDate.Width = 125;
            
            // IntTime
            // 
            IntTime.HeaderText = "Time";
            IntTime.MinimumWidth = 6;
            IntTime.Name = "IntTime";
            IntTime.ReadOnly = true;
            IntTime.Width = 125;
            
            // Location
            // 
            Location.HeaderText = "Location";
            Location.MinimumWidth = 6;
            Location.Name = "Location";
            Location.ReadOnly = true;
            Location.Width = 125;
            
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnManageSkills);
            panel1.Controls.Add(btnUpdateProfile);
            panel1.Location = new Point(30, 540);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 80);
            panel1.TabIndex = 2;
            
            // btnUpdateProfile
            // 
            btnUpdateProfile.BackColor = SystemColors.GradientActiveCaption;
            btnUpdateProfile.Location = new Point(20, 20);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(180, 40);
            btnUpdateProfile.TabIndex = 0;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.UseVisualStyleBackColor = false;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            
            // btnManageSkills
            // 
            btnManageSkills.BackColor = SystemColors.GradientActiveCaption;
            btnManageSkills.Location = new Point(220, 20);
            btnManageSkills.Name = "btnManageSkills";
            btnManageSkills.Size = new Size(180, 40);
            btnManageSkills.TabIndex = 1;
            btnManageSkills.Text = "Manage Skills";
            btnManageSkills.UseVisualStyleBackColor = false;
            btnManageSkills.Click += btnManageSkills_Click;
            
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.GradientActiveCaption;
            btnRefresh.Location = new Point(420, 20);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(180, 40);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh Data";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightCoral;
            btnLogout.Location = new Point(700, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(180, 40);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(962, 653);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Controls.Add(lblWelcome);
            Name = "StudentDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Student Dashboard";
            tabControl1.ResumeLayout(false);
            tabJobFairs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJobFairs).EndInit();
            tabJobs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            tabApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            tabInterviews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInterviews).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private TabControl tabControl1;
        private TabPage tabJobFairs;
        private TabPage tabJobs;
        private TabPage tabApplications;
        private TabPage tabInterviews;
        private DataGridView dgvJobFairs;
        private Button btnViewFairDetails;
        private Button btnRegisterForFair;
        private DataGridViewTextBoxColumn FairId;
        private DataGridViewTextBoxColumn FairName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Venue;
        private DataGridViewTextBoxColumn Time;
        private Button btnApplyForJob;
        private Button btnViewJobDetails;
        private DataGridView dgvJobs;
        private DataGridViewTextBoxColumn JobId;
        private DataGridViewTextBoxColumn JobTitle;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn JobType;
        private DataGridViewTextBoxColumn Status;
        private DataGridView dgvApplications;
        private DataGridViewTextBoxColumn ApplicationId;
        private DataGridViewTextBoxColumn AppJobTitle;
        private DataGridViewTextBoxColumn AppCompany;
        private DataGridViewTextBoxColumn AppliedDate;
        private DataGridViewTextBoxColumn AppStatus;
        private DataGridView dgvInterviews;
        private DataGridViewTextBoxColumn InterviewId;
        private DataGridViewTextBoxColumn IntCompany;
        private DataGridViewTextBoxColumn IntJobTitle;
        private DataGridViewTextBoxColumn IntDate;
        private DataGridViewTextBoxColumn IntTime;
        private DataGridViewTextBoxColumn Location;
        private Panel panel1;
        private Button btnLogout;
        private Button btnRefresh;
        private Button btnManageSkills;
        private Button btnUpdateProfile;
    }
} 