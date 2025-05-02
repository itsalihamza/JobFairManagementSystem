namespace JobFairManagementSystem
{
    partial class RecruiterDashboard
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
            tabApplications = new TabPage();
            btnScheduleInterview = new Button();
            btnUpdateStatus = new Button();
            btnViewApplicantProfile = new Button();
            dgvApplications = new DataGridView();
            ApplicationId = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            FastId = new DataGridViewTextBoxColumn();
            AppJobTitle = new DataGridViewTextBoxColumn();
            AppliedDate = new DataGridViewTextBoxColumn();
            AppStatus = new DataGridViewTextBoxColumn();
            tabInterviews = new TabPage();
            dgvInterviews = new DataGridView();
            InterviewId = new DataGridViewTextBoxColumn();
            IntStudentName = new DataGridViewTextBoxColumn();
            IntJobTitle = new DataGridViewTextBoxColumn();
            IntDate = new DataGridViewTextBoxColumn();
            IntTime = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            IntStatus = new DataGridViewTextBoxColumn();
            tabJobs = new TabPage();
            btnPostNewJob = new Button();
            btnViewJobDetails = new Button();
            dgvJobs = new DataGridView();
            JobId = new DataGridViewTextBoxColumn();
            JobTitle = new DataGridViewTextBoxColumn();
            JobType = new DataGridViewTextBoxColumn();
            Applicants = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            tabJobFairs = new TabPage();
            btnRegisterForFair = new Button();
            dgvJobFairs = new DataGridView();
            FairId = new DataGridViewTextBoxColumn();
            FairName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Venue = new DataGridViewTextBoxColumn();
            RegStatus = new DataGridViewTextBoxColumn();
            BoothNumber = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnLogout = new Button();
            tabControl1.SuspendLayout();
            tabApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();
            tabInterviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInterviews).BeginInit();
            tabJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            tabJobFairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobFairs).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(30, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(307, 32);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Recruiter Name";
            
            // tabControl1
            // 
            tabControl1.Controls.Add(tabApplications);
            tabControl1.Controls.Add(tabInterviews);
            tabControl1.Controls.Add(tabJobs);
            tabControl1.Controls.Add(tabJobFairs);
            tabControl1.Location = new Point(30, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(900, 450);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            
            // tabApplications
            // 
            tabApplications.Controls.Add(btnScheduleInterview);
            tabApplications.Controls.Add(btnUpdateStatus);
            tabApplications.Controls.Add(btnViewApplicantProfile);
            tabApplications.Controls.Add(dgvApplications);
            tabApplications.Location = new Point(4, 29);
            tabApplications.Name = "tabApplications";
            tabApplications.Padding = new Padding(3);
            tabApplications.Size = new Size(892, 417);
            tabApplications.TabIndex = 0;
            tabApplications.Text = "Applications";
            tabApplications.UseVisualStyleBackColor = true;
            
            // btnScheduleInterview
            // 
            btnScheduleInterview.BackColor = Color.RoyalBlue;
            btnScheduleInterview.ForeColor = Color.White;
            btnScheduleInterview.Location = new Point(720, 340);
            btnScheduleInterview.Name = "btnScheduleInterview";
            btnScheduleInterview.Size = new Size(150, 40);
            btnScheduleInterview.TabIndex = 3;
            btnScheduleInterview.Text = "Schedule Interview";
            btnScheduleInterview.UseVisualStyleBackColor = false;
            btnScheduleInterview.Click += btnScheduleInterview_Click;
            
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.DarkOrange;
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(560, 340);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(150, 40);
            btnUpdateStatus.TabIndex = 2;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            
            // btnViewApplicantProfile
            // 
            btnViewApplicantProfile.Location = new Point(400, 340);
            btnViewApplicantProfile.Name = "btnViewApplicantProfile";
            btnViewApplicantProfile.Size = new Size(150, 40);
            btnViewApplicantProfile.TabIndex = 1;
            btnViewApplicantProfile.Text = "View Profile";
            btnViewApplicantProfile.UseVisualStyleBackColor = true;
            btnViewApplicantProfile.Click += btnViewApplicantProfile_Click;
            
            // dgvApplications
            // 
            dgvApplications.AllowUserToAddRows = false;
            dgvApplications.AllowUserToDeleteRows = false;
            dgvApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplications.Columns.AddRange(new DataGridViewColumn[] { ApplicationId, StudentName, FastId, AppJobTitle, AppliedDate, AppStatus });
            dgvApplications.Location = new Point(20, 20);
            dgvApplications.MultiSelect = false;
            dgvApplications.Name = "dgvApplications";
            dgvApplications.ReadOnly = true;
            dgvApplications.RowHeadersWidth = 51;
            dgvApplications.RowTemplate.Height = 29;
            dgvApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplications.Size = new Size(850, 300);
            dgvApplications.TabIndex = 0;
            
            // ApplicationId
            // 
            ApplicationId.HeaderText = "ID";
            ApplicationId.MinimumWidth = 6;
            ApplicationId.Name = "ApplicationId";
            ApplicationId.ReadOnly = true;
            ApplicationId.Width = 50;
            
            // StudentName
            // 
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            StudentName.Width = 170;
            
            // FastId
            // 
            FastId.HeaderText = "FAST ID";
            FastId.MinimumWidth = 6;
            FastId.Name = "FastId";
            FastId.ReadOnly = true;
            FastId.Width = 125;
            
            // AppJobTitle
            // 
            AppJobTitle.HeaderText = "Job Title";
            AppJobTitle.MinimumWidth = 6;
            AppJobTitle.Name = "AppJobTitle";
            AppJobTitle.ReadOnly = true;
            AppJobTitle.Width = 170;
            
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
            AppStatus.Width = 125;
            
            // tabInterviews
            // 
            tabInterviews.Controls.Add(dgvInterviews);
            tabInterviews.Location = new Point(4, 29);
            tabInterviews.Name = "tabInterviews";
            tabInterviews.Padding = new Padding(3);
            tabInterviews.Size = new Size(892, 417);
            tabInterviews.TabIndex = 1;
            tabInterviews.Text = "Interviews";
            tabInterviews.UseVisualStyleBackColor = true;
            
            // dgvInterviews
            // 
            dgvInterviews.AllowUserToAddRows = false;
            dgvInterviews.AllowUserToDeleteRows = false;
            dgvInterviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInterviews.Columns.AddRange(new DataGridViewColumn[] { InterviewId, IntStudentName, IntJobTitle, IntDate, IntTime, Location, IntStatus });
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
            
            // IntStudentName
            // 
            IntStudentName.HeaderText = "Student Name";
            IntStudentName.MinimumWidth = 6;
            IntStudentName.Name = "IntStudentName";
            IntStudentName.ReadOnly = true;
            IntStudentName.Width = 170;
            
            // IntJobTitle
            // 
            IntJobTitle.HeaderText = "Job Title";
            IntJobTitle.MinimumWidth = 6;
            IntJobTitle.Name = "IntJobTitle";
            IntJobTitle.ReadOnly = true;
            IntJobTitle.Width = 170;
            
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
            
            // IntStatus
            // 
            IntStatus.HeaderText = "Status";
            IntStatus.MinimumWidth = 6;
            IntStatus.Name = "IntStatus";
            IntStatus.ReadOnly = true;
            IntStatus.Width = 125;
            
            // tabJobs
            // 
            tabJobs.Controls.Add(btnPostNewJob);
            tabJobs.Controls.Add(btnViewJobDetails);
            tabJobs.Controls.Add(dgvJobs);
            tabJobs.Location = new Point(4, 29);
            tabJobs.Name = "tabJobs";
            tabJobs.Size = new Size(892, 417);
            tabJobs.TabIndex = 2;
            tabJobs.Text = "Jobs";
            tabJobs.UseVisualStyleBackColor = true;
            
            // btnPostNewJob
            // 
            btnPostNewJob.BackColor = Color.ForestGreen;
            btnPostNewJob.ForeColor = Color.White;
            btnPostNewJob.Location = new Point(720, 340);
            btnPostNewJob.Name = "btnPostNewJob";
            btnPostNewJob.Size = new Size(150, 40);
            btnPostNewJob.TabIndex = 2;
            btnPostNewJob.Text = "Post New Job";
            btnPostNewJob.UseVisualStyleBackColor = false;
            btnPostNewJob.Click += btnPostNewJob_Click;
            
            // btnViewJobDetails
            // 
            btnViewJobDetails.Location = new Point(560, 340);
            btnViewJobDetails.Name = "btnViewJobDetails";
            btnViewJobDetails.Size = new Size(150, 40);
            btnViewJobDetails.TabIndex = 1;
            btnViewJobDetails.Text = "View Details";
            btnViewJobDetails.UseVisualStyleBackColor = true;
            btnViewJobDetails.Click += btnViewJobDetails_Click;
            
            // dgvJobs
            // 
            dgvJobs.AllowUserToAddRows = false;
            dgvJobs.AllowUserToDeleteRows = false;
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Columns.AddRange(new DataGridViewColumn[] { JobId, JobTitle, JobType, Applicants, Status });
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
            
            // JobType
            // 
            JobType.HeaderText = "Type";
            JobType.MinimumWidth = 6;
            JobType.Name = "JobType";
            JobType.ReadOnly = true;
            JobType.Width = 125;
            
            // Applicants
            // 
            Applicants.HeaderText = "Applicants";
            Applicants.MinimumWidth = 6;
            Applicants.Name = "Applicants";
            Applicants.ReadOnly = true;
            Applicants.Width = 125;
            
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            
            // tabJobFairs
            // 
            tabJobFairs.Controls.Add(btnRegisterForFair);
            tabJobFairs.Controls.Add(dgvJobFairs);
            tabJobFairs.Location = new Point(4, 29);
            tabJobFairs.Name = "tabJobFairs";
            tabJobFairs.Size = new Size(892, 417);
            tabJobFairs.TabIndex = 3;
            tabJobFairs.Text = "Job Fairs";
            tabJobFairs.UseVisualStyleBackColor = true;
            
            // btnRegisterForFair
            // 
            btnRegisterForFair.BackColor = Color.RoyalBlue;
            btnRegisterForFair.ForeColor = Color.White;
            btnRegisterForFair.Location = new Point(720, 340);
            btnRegisterForFair.Name = "btnRegisterForFair";
            btnRegisterForFair.Size = new Size(150, 40);
            btnRegisterForFair.TabIndex = 1;
            btnRegisterForFair.Text = "Register";
            btnRegisterForFair.UseVisualStyleBackColor = false;
            btnRegisterForFair.Click += btnRegisterForFair_Click;
            
            // dgvJobFairs
            // 
            dgvJobFairs.AllowUserToAddRows = false;
            dgvJobFairs.AllowUserToDeleteRows = false;
            dgvJobFairs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobFairs.Columns.AddRange(new DataGridViewColumn[] { FairId, FairName, Date, Venue, RegStatus, BoothNumber });
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
            FairName.Width = 200;
            
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
            
            // RegStatus
            // 
            RegStatus.HeaderText = "Status";
            RegStatus.MinimumWidth = 6;
            RegStatus.Name = "RegStatus";
            RegStatus.ReadOnly = true;
            RegStatus.Width = 125;
            
            // BoothNumber
            // 
            BoothNumber.HeaderText = "Booth #";
            BoothNumber.MinimumWidth = 6;
            BoothNumber.Name = "BoothNumber";
            BoothNumber.ReadOnly = true;
            BoothNumber.Width = 70;
            
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(30, 540);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 80);
            panel1.TabIndex = 2;
            
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightCoral;
            btnLogout.Location = new Point(700, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(180, 40);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            
            // RecruiterDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(962, 653);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Controls.Add(lblWelcome);
            Name = "RecruiterDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Recruiter Dashboard";
            tabControl1.ResumeLayout(false);
            tabApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            tabInterviews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInterviews).EndInit();
            tabJobs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            tabJobFairs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJobFairs).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private TabControl tabControl1;
        private TabPage tabApplications;
        private TabPage tabInterviews;
        private TabPage tabJobs;
        private TabPage tabJobFairs;
        private Panel panel1;
        private Button btnLogout;
        private DataGridView dgvApplications;
        private Button btnViewApplicantProfile;
        private Button btnUpdateStatus;
        private Button btnScheduleInterview;
        private DataGridView dgvInterviews;
        private DataGridView dgvJobs;
        private Button btnViewJobDetails;
        private Button btnPostNewJob;
        private DataGridView dgvJobFairs;
        private Button btnRegisterForFair;
        private DataGridViewTextBoxColumn ApplicationId;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn FastId;
        private DataGridViewTextBoxColumn AppJobTitle;
        private DataGridViewTextBoxColumn AppliedDate;
        private DataGridViewTextBoxColumn AppStatus;
        private DataGridViewTextBoxColumn InterviewId;
        private DataGridViewTextBoxColumn IntStudentName;
        private DataGridViewTextBoxColumn IntJobTitle;
        private DataGridViewTextBoxColumn IntDate;
        private DataGridViewTextBoxColumn IntTime;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn IntStatus;
        private DataGridViewTextBoxColumn JobId;
        private DataGridViewTextBoxColumn JobTitle;
        private DataGridViewTextBoxColumn JobType;
        private DataGridViewTextBoxColumn Applicants;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn FairId;
        private DataGridViewTextBoxColumn FairName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Venue;
        private DataGridViewTextBoxColumn RegStatus;
        private DataGridViewTextBoxColumn BoothNumber;
    }
} 