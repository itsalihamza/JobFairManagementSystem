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
            panelJobFilters = new Panel();
            lblJobCount = new Label();
            btnClearFilters = new Button();
            btnSearch = new Button();
            checkedListSkills = new CheckedListBox();
            lblSkills = new Label();
            cmbLocation = new ComboBox();
            lblLocation = new Label();
            cmbSalaryRange = new ComboBox();
            lblSalary = new Label();
            cmbJobType = new ComboBox();
            lblJobType = new Label();
            txtSearchJobs = new TextBox();
            lblSearch = new Label();
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
            ScheduleInterview = new DataGridViewTextBoxColumn();
            JobIdHidden = new DataGridViewTextBoxColumn();
            tabInterviews = new TabPage();
            dgvInterviews = new DataGridView();
            InterviewId = new DataGridViewTextBoxColumn();
            IntCompany = new DataGridViewTextBoxColumn();
            IntJobTitle = new DataGridViewTextBoxColumn();
            IntDate = new DataGridViewTextBoxColumn();
            IntTime = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            tabPastInterviews = new TabPage();
            btnSubmitReview = new Button();
            dgvPastInterviews = new DataGridView();
            PastInterviewId = new DataGridViewTextBoxColumn();
            PastCompany = new DataGridViewTextBoxColumn();
            PastJobTitle = new DataGridViewTextBoxColumn();
            PastDate = new DataGridViewTextBoxColumn();
            PastTime = new DataGridViewTextBoxColumn();
            RecruiterId = new DataGridViewTextBoxColumn();
            ReviewStatus = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnLogout = new Button();
            btnRefresh = new Button();
            btnManageSkills = new Button();
            btnUpdateProfile = new Button();
            tabControl1.SuspendLayout();
            tabJobFairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobFairs).BeginInit();
            tabJobs.SuspendLayout();
            panelJobFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            tabApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();
            tabInterviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInterviews).BeginInit();
            tabPastInterviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPastInterviews).BeginInit();
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
            tabControl1.Controls.Add(tabPastInterviews);
            tabControl1.Location = new Point(30, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(900, 550);
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
            tabJobs.Controls.Add(panelJobFilters);
            tabJobs.Controls.Add(btnApplyForJob);
            tabJobs.Controls.Add(btnViewJobDetails);
            tabJobs.Controls.Add(dgvJobs);
            tabJobs.Location = new Point(4, 29);
            tabJobs.Name = "tabJobs";
            tabJobs.Padding = new Padding(3);
            tabJobs.Size = new Size(892, 517);
            tabJobs.TabIndex = 1;
            tabJobs.Text = "Available Jobs";
            tabJobs.UseVisualStyleBackColor = true;
            
            // panelJobFilters
            // 
            panelJobFilters.BorderStyle = BorderStyle.FixedSingle;
            panelJobFilters.Controls.Add(lblJobCount);
            panelJobFilters.Controls.Add(btnClearFilters);
            panelJobFilters.Controls.Add(btnSearch);
            panelJobFilters.Controls.Add(checkedListSkills);
            panelJobFilters.Controls.Add(lblSkills);
            panelJobFilters.Controls.Add(cmbLocation);
            panelJobFilters.Controls.Add(lblLocation);
            panelJobFilters.Controls.Add(cmbSalaryRange);
            panelJobFilters.Controls.Add(lblSalary);
            panelJobFilters.Controls.Add(cmbJobType);
            panelJobFilters.Controls.Add(lblJobType);
            panelJobFilters.Controls.Add(txtSearchJobs);
            panelJobFilters.Controls.Add(lblSearch);
            panelJobFilters.Location = new Point(20, 20);
            panelJobFilters.Name = "panelJobFilters";
            panelJobFilters.Size = new Size(850, 170);
            panelJobFilters.TabIndex = 3;
            
            // lblJobCount
            // 
            lblJobCount.AutoSize = true;
            lblJobCount.Location = new Point(10, 137);
            lblJobCount.Name = "lblJobCount";
            lblJobCount.Size = new Size(59, 20);
            lblJobCount.TabIndex = 12;
            lblJobCount.Text = "Found 0 job(s)";
            
            // btnClearFilters
            // 
            btnClearFilters.Location = new Point(715, 71);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(120, 30);
            btnClearFilters.TabIndex = 11;
            btnClearFilters.Text = "Clear Filters";
            btnClearFilters.UseVisualStyleBackColor = true;
            btnClearFilters.Click += btnClearFilters_Click;
            
            // btnSearch
            // 
            btnSearch.BackColor = Color.ForestGreen;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(715, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 30);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            
            // checkedListSkills
            // 
            checkedListSkills.FormattingEnabled = true;
            checkedListSkills.Location = new Point(510, 30);
            checkedListSkills.Name = "checkedListSkills";
            checkedListSkills.Size = new Size(180, 114);
            checkedListSkills.TabIndex = 9;
            
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Location = new Point(510, 10);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(111, 20);
            lblSkills.TabIndex = 8;
            lblSkills.Text = "Required Skills:";
            
            // cmbLocation
            // 
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(320, 120);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(165, 28);
            cmbLocation.TabIndex = 7;
            
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(320, 100);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(69, 20);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Location:";
            
            // cmbSalaryRange
            // 
            cmbSalaryRange.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSalaryRange.FormattingEnabled = true;
            cmbSalaryRange.Location = new Point(320, 60);
            cmbSalaryRange.Name = "cmbSalaryRange";
            cmbSalaryRange.Size = new Size(165, 28);
            cmbSalaryRange.TabIndex = 5;
            
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(320, 40);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(101, 20);
            lblSalary.TabIndex = 4;
            lblSalary.Text = "Salary Range:";
            
            // cmbJobType
            // 
            cmbJobType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJobType.FormattingEnabled = true;
            cmbJobType.Location = new Point(130, 60);
            cmbJobType.Name = "cmbJobType";
            cmbJobType.Size = new Size(165, 28);
            cmbJobType.TabIndex = 3;
            
            // lblJobType
            // 
            lblJobType.AutoSize = true;
            lblJobType.Location = new Point(130, 40);
            lblJobType.Name = "lblJobType";
            lblJobType.Size = new Size(73, 20);
            lblJobType.TabIndex = 2;
            lblJobType.Text = "Job Type:";
            
            // txtSearchJobs
            // 
            txtSearchJobs.Location = new Point(10, 60);
            txtSearchJobs.Name = "txtSearchJobs";
            txtSearchJobs.Size = new Size(100, 27);
            txtSearchJobs.TabIndex = 1;
            
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(10, 40);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(56, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            
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
            tabApplications.Padding = new Padding(3);
            tabApplications.Size = new Size(892, 517);
            tabApplications.TabIndex = 2;
            tabApplications.Text = "My Applications";
            tabApplications.UseVisualStyleBackColor = true;
            
            // dgvApplications
            // 
            dgvApplications.AllowUserToAddRows = false;
            dgvApplications.AllowUserToDeleteRows = false;
            dgvApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplications.Columns.AddRange(new DataGridViewColumn[] { 
                ApplicationId, AppJobTitle, AppCompany, AppliedDate, AppStatus, ScheduleInterview, JobIdHidden });
            dgvApplications.Location = new Point(20, 20);
            dgvApplications.MultiSelect = false;
            dgvApplications.Name = "dgvApplications";
            dgvApplications.ReadOnly = true;
            dgvApplications.RowHeadersWidth = 51;
            dgvApplications.RowTemplate.Height = 29;
            dgvApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplications.Size = new Size(850, 370);
            dgvApplications.TabIndex = 0;
            dgvApplications.CellContentClick += dgvApplications_CellContentClick;
            
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
            AppJobTitle.Width = 200;
            
            // AppCompany
            // 
            AppCompany.HeaderText = "Company";
            AppCompany.MinimumWidth = 6;
            AppCompany.Name = "AppCompany";
            AppCompany.ReadOnly = true;
            AppCompany.Width = 180;
            
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
            
            // ScheduleInterview
            // 
            ScheduleInterview.HeaderText = "Action";
            ScheduleInterview.MinimumWidth = 6;
            ScheduleInterview.Name = "ScheduleInterview";
            ScheduleInterview.ReadOnly = true;
            ScheduleInterview.Width = 125;
            
            // JobIdHidden
            // 
            JobIdHidden.HeaderText = "JobID";
            JobIdHidden.MinimumWidth = 6;
            JobIdHidden.Name = "JobIdHidden";
            JobIdHidden.ReadOnly = true;
            JobIdHidden.Visible = false;
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
            
            // tabPastInterviews
            // 
            tabPastInterviews.Controls.Add(btnSubmitReview);
            tabPastInterviews.Controls.Add(dgvPastInterviews);
            tabPastInterviews.Location = new Point(4, 29);
            tabPastInterviews.Name = "tabPastInterviews";
            tabPastInterviews.Padding = new Padding(3);
            tabPastInterviews.Size = new Size(892, 517);
            tabPastInterviews.TabIndex = 4;
            tabPastInterviews.Text = "Past Interviews";
            tabPastInterviews.UseVisualStyleBackColor = true;
            
            // btnSubmitReview
            // 
            btnSubmitReview.BackColor = Color.RoyalBlue;
            btnSubmitReview.ForeColor = Color.White;
            btnSubmitReview.Location = new Point(720, 440);
            btnSubmitReview.Name = "btnSubmitReview";
            btnSubmitReview.Size = new Size(150, 40);
            btnSubmitReview.TabIndex = 1;
            btnSubmitReview.Text = "Submit Review";
            btnSubmitReview.UseVisualStyleBackColor = false;
            btnSubmitReview.Click += btnSubmitReview_Click;
            
            // dgvPastInterviews
            // 
            dgvPastInterviews.AllowUserToAddRows = false;
            dgvPastInterviews.AllowUserToDeleteRows = false;
            dgvPastInterviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPastInterviews.Columns.AddRange(new DataGridViewColumn[] { 
                PastInterviewId, PastCompany, PastJobTitle, PastDate, PastTime, RecruiterId, ReviewStatus });
            dgvPastInterviews.Location = new Point(20, 20);
            dgvPastInterviews.MultiSelect = false;
            dgvPastInterviews.Name = "dgvPastInterviews";
            dgvPastInterviews.ReadOnly = true;
            dgvPastInterviews.RowHeadersWidth = 51;
            dgvPastInterviews.RowTemplate.Height = 29;
            dgvPastInterviews.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPastInterviews.Size = new Size(850, 400);
            dgvPastInterviews.TabIndex = 0;
            
            // PastInterviewId
            // 
            PastInterviewId.HeaderText = "ID";
            PastInterviewId.MinimumWidth = 6;
            PastInterviewId.Name = "PastInterviewId";
            PastInterviewId.ReadOnly = true;
            PastInterviewId.Width = 50;
            
            // PastCompany
            // 
            PastCompany.HeaderText = "Company";
            PastCompany.MinimumWidth = 6;
            PastCompany.Name = "PastCompany";
            PastCompany.ReadOnly = true;
            PastCompany.Width = 180;
            
            // PastJobTitle
            // 
            PastJobTitle.HeaderText = "Job Title";
            PastJobTitle.MinimumWidth = 6;
            PastJobTitle.Name = "PastJobTitle";
            PastJobTitle.ReadOnly = true;
            PastJobTitle.Width = 180;
            
            // PastDate
            // 
            PastDate.HeaderText = "Date";
            PastDate.MinimumWidth = 6;
            PastDate.Name = "PastDate";
            PastDate.ReadOnly = true;
            PastDate.Width = 125;
            
            // PastTime
            // 
            PastTime.HeaderText = "Time";
            PastTime.MinimumWidth = 6;
            PastTime.Name = "PastTime";
            PastTime.ReadOnly = true;
            PastTime.Width = 125;
            
            // RecruiterId
            // 
            RecruiterId.HeaderText = "RecruiterID";
            RecruiterId.MinimumWidth = 6;
            RecruiterId.Name = "RecruiterId";
            RecruiterId.ReadOnly = true;
            RecruiterId.Visible = false;
            RecruiterId.Width = 125;
            
            // ReviewStatus
            // 
            ReviewStatus.HeaderText = "Review Status";
            ReviewStatus.MinimumWidth = 6;
            ReviewStatus.Name = "ReviewStatus";
            ReviewStatus.ReadOnly = true;
            ReviewStatus.Width = 140;
            
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
            ClientSize = new Size(950, 700);  // Adjusted size for new content
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
            panelJobFilters.ResumeLayout(false);
            panelJobFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            tabApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            tabInterviews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInterviews).EndInit();
            tabPastInterviews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPastInterviews).EndInit();
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
        private TabPage tabPastInterviews;
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
        
        // New controls for job search and filtering
        private Panel panelJobFilters;
        private Label lblSearch;
        private TextBox txtSearchJobs;
        private Label lblJobType;
        private ComboBox cmbJobType;
        private Label lblSalary;
        private ComboBox cmbSalaryRange;
        private Label lblLocation;
        private ComboBox cmbLocation;
        private Label lblSkills;
        private CheckedListBox checkedListSkills;
        private Button btnSearch;
        private Button btnClearFilters;
        private Label lblJobCount;
        
        // New controls for interview reviews
        private DataGridView dgvPastInterviews;
        private Button btnSubmitReview;
        private DataGridViewTextBoxColumn PastInterviewId;
        private DataGridViewTextBoxColumn PastCompany;
        private DataGridViewTextBoxColumn PastJobTitle;
        private DataGridViewTextBoxColumn PastDate;
        private DataGridViewTextBoxColumn PastTime;
        private DataGridViewTextBoxColumn RecruiterId;
        private DataGridViewTextBoxColumn ReviewStatus;
        private DataGridViewTextBoxColumn ScheduleInterview;
        private DataGridViewTextBoxColumn JobIdHidden;
    }
} 