namespace JobFairManagementSystem
{
    partial class AdminDashboard
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabJobFairs = new System.Windows.Forms.TabPage();
            this.btnManageFair = new System.Windows.Forms.Button();
            this.btnCreateFair = new System.Windows.Forms.Button();
            this.dgvJobFairs = new System.Windows.Forms.DataGridView();
            this.FairId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FairName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FairDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCompanies = new System.Windows.Forms.TabPage();
            this.btnApproveCompany = new System.Windows.Forms.Button();
            this.dgvCompanies = new System.Windows.Forms.DataGridView();
            this.CompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Industry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.btnVerifyStudent = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FastId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabJobFairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobFairs)).BeginInit();
            this.tabCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).BeginInit();
            this.tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabReports.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(30, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(209, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Admin";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabJobFairs);
            this.tabControl1.Controls.Add(this.tabCompanies);
            this.tabControl1.Controls.Add(this.tabStudents);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Location = new System.Drawing.Point(30, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabJobFairs
            // 
            this.tabJobFairs.Controls.Add(this.btnManageFair);
            this.tabJobFairs.Controls.Add(this.btnCreateFair);
            this.tabJobFairs.Controls.Add(this.dgvJobFairs);
            this.tabJobFairs.Location = new System.Drawing.Point(4, 29);
            this.tabJobFairs.Name = "tabJobFairs";
            this.tabJobFairs.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobFairs.Size = new System.Drawing.Size(892, 417);
            this.tabJobFairs.TabIndex = 0;
            this.tabJobFairs.Text = "Job Fairs";
            this.tabJobFairs.UseVisualStyleBackColor = true;
            // 
            // btnManageFair
            // 
            this.btnManageFair.Location = new System.Drawing.Point(720, 340);
            this.btnManageFair.Name = "btnManageFair";
            this.btnManageFair.Size = new System.Drawing.Size(150, 40);
            this.btnManageFair.TabIndex = 2;
            this.btnManageFair.Text = "Manage Fair";
            this.btnManageFair.UseVisualStyleBackColor = true;
            // 
            // btnCreateFair
            // 
            this.btnCreateFair.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCreateFair.ForeColor = System.Drawing.Color.White;
            this.btnCreateFair.Location = new System.Drawing.Point(560, 340);
            this.btnCreateFair.Name = "btnCreateFair";
            this.btnCreateFair.Size = new System.Drawing.Size(150, 40);
            this.btnCreateFair.TabIndex = 1;
            this.btnCreateFair.Text = "Create New Fair";
            this.btnCreateFair.UseVisualStyleBackColor = false;
            // 
            // dgvJobFairs
            // 
            this.dgvJobFairs.AllowUserToAddRows = false;
            this.dgvJobFairs.AllowUserToDeleteRows = false;
            this.dgvJobFairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobFairs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FairId,
            this.FairName,
            this.FairDate,
            this.Venue,
            this.Status});
            this.dgvJobFairs.Location = new System.Drawing.Point(20, 20);
            this.dgvJobFairs.MultiSelect = false;
            this.dgvJobFairs.Name = "dgvJobFairs";
            this.dgvJobFairs.ReadOnly = true;
            this.dgvJobFairs.RowHeadersWidth = 51;
            this.dgvJobFairs.RowTemplate.Height = 29;
            this.dgvJobFairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobFairs.Size = new System.Drawing.Size(850, 300);
            this.dgvJobFairs.TabIndex = 0;
            this.dgvJobFairs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobFairs_CellContentClick);
            // 
            // FairId
            // 
            this.FairId.HeaderText = "ID";
            this.FairId.MinimumWidth = 6;
            this.FairId.Name = "FairId";
            this.FairId.ReadOnly = true;
            this.FairId.Width = 50;
            // 
            // FairName
            // 
            this.FairName.HeaderText = "Fair Name";
            this.FairName.MinimumWidth = 6;
            this.FairName.Name = "FairName";
            this.FairName.ReadOnly = true;
            this.FairName.Width = 250;
            // 
            // FairDate
            // 
            this.FairDate.HeaderText = "Date";
            this.FairDate.MinimumWidth = 6;
            this.FairDate.Name = "FairDate";
            this.FairDate.ReadOnly = true;
            this.FairDate.Width = 125;
            // 
            // Venue
            // 
            this.Venue.HeaderText = "Venue";
            this.Venue.MinimumWidth = 6;
            this.Venue.Name = "Venue";
            this.Venue.ReadOnly = true;
            this.Venue.Width = 200;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // tabCompanies
            // 
            this.tabCompanies.Controls.Add(this.btnApproveCompany);
            this.tabCompanies.Controls.Add(this.dgvCompanies);
            this.tabCompanies.Location = new System.Drawing.Point(4, 29);
            this.tabCompanies.Name = "tabCompanies";
            this.tabCompanies.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompanies.Size = new System.Drawing.Size(892, 417);
            this.tabCompanies.TabIndex = 1;
            this.tabCompanies.Text = "Companies";
            this.tabCompanies.UseVisualStyleBackColor = true;
            // 
            // btnApproveCompany
            // 
            this.btnApproveCompany.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnApproveCompany.ForeColor = System.Drawing.Color.White;
            this.btnApproveCompany.Location = new System.Drawing.Point(720, 340);
            this.btnApproveCompany.Name = "btnApproveCompany";
            this.btnApproveCompany.Size = new System.Drawing.Size(150, 40);
            this.btnApproveCompany.TabIndex = 1;
            this.btnApproveCompany.Text = "Approve Company";
            this.btnApproveCompany.UseVisualStyleBackColor = false;
            // 
            // dgvCompanies
            // 
            this.dgvCompanies.AllowUserToAddRows = false;
            this.dgvCompanies.AllowUserToDeleteRows = false;
            this.dgvCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyId,
            this.CompanyName,
            this.Industry,
            this.JobCount,
            this.CompanyStatus});
            this.dgvCompanies.Location = new System.Drawing.Point(20, 20);
            this.dgvCompanies.MultiSelect = false;
            this.dgvCompanies.Name = "dgvCompanies";
            this.dgvCompanies.ReadOnly = true;
            this.dgvCompanies.RowHeadersWidth = 51;
            this.dgvCompanies.RowTemplate.Height = 29;
            this.dgvCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompanies.Size = new System.Drawing.Size(850, 300);
            this.dgvCompanies.TabIndex = 0;
            // 
            // CompanyId
            // 
            this.CompanyId.HeaderText = "ID";
            this.CompanyId.MinimumWidth = 6;
            this.CompanyId.Name = "CompanyId";
            this.CompanyId.ReadOnly = true;
            this.CompanyId.Width = 50;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Company Name";
            this.CompanyName.MinimumWidth = 6;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 200;
            // 
            // Industry
            // 
            this.Industry.HeaderText = "Industry";
            this.Industry.MinimumWidth = 6;
            this.Industry.Name = "Industry";
            this.Industry.ReadOnly = true;
            this.Industry.Width = 150;
            // 
            // JobCount
            // 
            this.JobCount.HeaderText = "Job Postings";
            this.JobCount.MinimumWidth = 6;
            this.JobCount.Name = "JobCount";
            this.JobCount.ReadOnly = true;
            this.JobCount.Width = 125;
            // 
            // CompanyStatus
            // 
            this.CompanyStatus.HeaderText = "Status";
            this.CompanyStatus.MinimumWidth = 6;
            this.CompanyStatus.Name = "CompanyStatus";
            this.CompanyStatus.ReadOnly = true;
            this.CompanyStatus.Width = 125;
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.btnVerifyStudent);
            this.tabStudents.Controls.Add(this.dgvStudents);
            this.tabStudents.Location = new System.Drawing.Point(4, 29);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Size = new System.Drawing.Size(892, 417);
            this.tabStudents.TabIndex = 2;
            this.tabStudents.Text = "Students";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // btnVerifyStudent
            // 
            this.btnVerifyStudent.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVerifyStudent.ForeColor = System.Drawing.Color.White;
            this.btnVerifyStudent.Location = new System.Drawing.Point(720, 340);
            this.btnVerifyStudent.Name = "btnVerifyStudent";
            this.btnVerifyStudent.Size = new System.Drawing.Size(150, 40);
            this.btnVerifyStudent.TabIndex = 1;
            this.btnVerifyStudent.Text = "Verify Student";
            this.btnVerifyStudent.UseVisualStyleBackColor = false;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.FastId,
            this.Degree,
            this.GPA,
            this.StudentStatus});
            this.dgvStudents.Location = new System.Drawing.Point(20, 20);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 29;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(850, 300);
            this.dgvStudents.TabIndex = 0;
            // 
            // StudentId
            // 
            this.StudentId.HeaderText = "ID";
            this.StudentId.MinimumWidth = 6;
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Width = 50;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 175;
            // 
            // FastId
            // 
            this.FastId.HeaderText = "FAST ID";
            this.FastId.MinimumWidth = 6;
            this.FastId.Name = "FastId";
            this.FastId.ReadOnly = true;
            this.FastId.Width = 125;
            // 
            // Degree
            // 
            this.Degree.HeaderText = "Degree";
            this.Degree.MinimumWidth = 6;
            this.Degree.Name = "Degree";
            this.Degree.ReadOnly = true;
            this.Degree.Width = 125;
            // 
            // GPA
            // 
            this.GPA.HeaderText = "GPA";
            this.GPA.MinimumWidth = 6;
            this.GPA.Name = "GPA";
            this.GPA.ReadOnly = true;
            this.GPA.Width = 75;
            // 
            // StudentStatus
            // 
            this.StudentStatus.HeaderText = "Status";
            this.StudentStatus.MinimumWidth = 6;
            this.StudentStatus.Name = "StudentStatus";
            this.StudentStatus.ReadOnly = true;
            this.StudentStatus.Width = 125;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.btnGenerateReports);
            this.tabReports.Controls.Add(this.lblReportTitle);
            this.tabReports.Controls.Add(this.cmbReportType);
            this.tabReports.Controls.Add(this.btnShowReport);
            this.tabReports.Controls.Add(this.panel2);
            this.tabReports.Location = new System.Drawing.Point(4, 29);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(892, 417);
            this.tabReports.TabIndex = 3;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateReports.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReports.Location = new System.Drawing.Point(710, 360);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(160, 40);
            this.btnGenerateReports.TabIndex = 0;
            this.btnGenerateReports.Text = "Export to CSV";
            this.btnGenerateReports.UseVisualStyleBackColor = false;
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReportTitle.Location = new System.Drawing.Point(20, 20);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(179, 28);
            this.lblReportTitle.TabIndex = 1;
            this.lblReportTitle.Text = "System Analytics";
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Department-wise Registration",
            "GPA Distribution",
            "Top Skills",
            "Interviews by Company",
            "Offer Acceptance Ratios",
            "Recruiter Ratings",
            "Overall Placement Statistics",
            "Placement Rates by Department",
            "Average Salary by Program",
            "Booth Traffic Analysis",
            "Peak Participation Hours",
            "Resource Usage Metrics"});
            this.cmbReportType.Location = new System.Drawing.Point(20, 60);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(250, 28);
            this.cmbReportType.TabIndex = 2;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(290, 60);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(120, 28);
            this.btnShowReport.TabIndex = 3;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(20, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 250);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(30, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 80);
            this.panel1.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogout.Location = new System.Drawing.Point(700, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 40);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(962, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CareerConnect - Admin Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabJobFairs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobFairs)).EndInit();
            this.tabCompanies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).EndInit();
            this.tabStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            
            // Connect event handlers to buttons
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnCreateFair.Click += new System.EventHandler(this.btnCreateFair_Click);
            this.btnManageFair.Click += new System.EventHandler(this.btnManageFair_Click);
            this.btnApproveCompany.Click += new System.EventHandler(this.btnApproveCompany_Click);
            this.btnVerifyStudent.Click += new System.EventHandler(this.btnVerifyStudent_Click);
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWelcome;
        private TabControl tabControl1;
        private TabPage tabJobFairs;
        private TabPage tabCompanies;
        private TabPage tabStudents;
        private TabPage tabReports;
        private DataGridView dgvJobFairs;
        private Button btnCreateFair;
        private Button btnManageFair;
        private DataGridViewTextBoxColumn FairId;
        private DataGridViewTextBoxColumn FairName;
        private DataGridViewTextBoxColumn FairDate;
        private DataGridViewTextBoxColumn Venue;
        private DataGridViewTextBoxColumn Status;
        private DataGridView dgvCompanies;
        private Button btnApproveCompany;
        private DataGridViewTextBoxColumn CompanyId;
        private DataGridViewTextBoxColumn CompanyName;
        private DataGridViewTextBoxColumn Industry;
        private DataGridViewTextBoxColumn JobCount;
        private DataGridViewTextBoxColumn CompanyStatus;
        private DataGridView dgvStudents;
        private Button btnVerifyStudent;
        private DataGridViewTextBoxColumn StudentId;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn FastId;
        private DataGridViewTextBoxColumn Degree;
        private DataGridViewTextBoxColumn GPA;
        private DataGridViewTextBoxColumn StudentStatus;
        private Button btnGenerateReports;
        private Label lblReportTitle;
        private ComboBox cmbReportType;
        private Button btnShowReport;
        private Panel panel2;
        private Panel panel1;
        private Button btnLogout;
    }
} 