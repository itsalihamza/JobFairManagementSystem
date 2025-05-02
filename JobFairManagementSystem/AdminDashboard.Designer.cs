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
            lblWelcome = new Label();
            tabControl1 = new TabControl();
            tabJobFairs = new TabPage();
            btnManageFair = new Button();
            btnCreateFair = new Button();
            dgvJobFairs = new DataGridView();
            FairId = new DataGridViewTextBoxColumn();
            FairName = new DataGridViewTextBoxColumn();
            FairDate = new DataGridViewTextBoxColumn();
            Venue = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            tabCompanies = new TabPage();
            btnApproveCompany = new Button();
            dgvCompanies = new DataGridView();
            CompanyId = new DataGridViewTextBoxColumn();
            CompanyName = new DataGridViewTextBoxColumn();
            Industry = new DataGridViewTextBoxColumn();
            JobCount = new DataGridViewTextBoxColumn();
            CompanyStatus = new DataGridViewTextBoxColumn();
            tabStudents = new TabPage();
            btnVerifyStudent = new Button();
            dgvStudents = new DataGridView();
            StudentId = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            FastId = new DataGridViewTextBoxColumn();
            Degree = new DataGridViewTextBoxColumn();
            GPA = new DataGridViewTextBoxColumn();
            StudentStatus = new DataGridViewTextBoxColumn();
            tabReports = new TabPage();
            btnGenerateReports = new Button();
            panel1 = new Panel();
            btnLogout = new Button();
            tabControl1.SuspendLayout();
            tabJobFairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobFairs).BeginInit();
            tabCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompanies).BeginInit();
            tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            tabReports.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(30, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(200, 32);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Admin";
            
            // tabControl1
            // 
            tabControl1.Controls.Add(tabJobFairs);
            tabControl1.Controls.Add(tabCompanies);
            tabControl1.Controls.Add(tabStudents);
            tabControl1.Controls.Add(tabReports);
            tabControl1.Location = new Point(30, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(900, 450);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            
            // tabJobFairs
            // 
            tabJobFairs.Controls.Add(btnManageFair);
            tabJobFairs.Controls.Add(btnCreateFair);
            tabJobFairs.Controls.Add(dgvJobFairs);
            tabJobFairs.Location = new Point(4, 29);
            tabJobFairs.Name = "tabJobFairs";
            tabJobFairs.Padding = new Padding(3);
            tabJobFairs.Size = new Size(892, 417);
            tabJobFairs.TabIndex = 0;
            tabJobFairs.Text = "Job Fairs";
            tabJobFairs.UseVisualStyleBackColor = true;
            
            // btnManageFair
            // 
            btnManageFair.Location = new Point(720, 340);
            btnManageFair.Name = "btnManageFair";
            btnManageFair.Size = new Size(150, 40);
            btnManageFair.TabIndex = 2;
            btnManageFair.Text = "Manage Fair";
            btnManageFair.UseVisualStyleBackColor = true;
            btnManageFair.Click += btnManageFair_Click;
            
            // btnCreateFair
            // 
            btnCreateFair.BackColor = Color.ForestGreen;
            btnCreateFair.ForeColor = Color.White;
            btnCreateFair.Location = new Point(560, 340);
            btnCreateFair.Name = "btnCreateFair";
            btnCreateFair.Size = new Size(150, 40);
            btnCreateFair.TabIndex = 1;
            btnCreateFair.Text = "Create New Fair";
            btnCreateFair.UseVisualStyleBackColor = false;
            btnCreateFair.Click += btnCreateFair_Click;
            
            // dgvJobFairs
            // 
            dgvJobFairs.AllowUserToAddRows = false;
            dgvJobFairs.AllowUserToDeleteRows = false;
            dgvJobFairs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobFairs.Columns.AddRange(new DataGridViewColumn[] { FairId, FairName, FairDate, Venue, Status });
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
            FairName.Width = 250;
            
            // FairDate
            // 
            FairDate.HeaderText = "Date";
            FairDate.MinimumWidth = 6;
            FairDate.Name = "FairDate";
            FairDate.ReadOnly = true;
            FairDate.Width = 125;
            
            // Venue
            // 
            Venue.HeaderText = "Venue";
            Venue.MinimumWidth = 6;
            Venue.Name = "Venue";
            Venue.ReadOnly = true;
            Venue.Width = 200;
            
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            
            // tabCompanies
            // 
            tabCompanies.Controls.Add(btnApproveCompany);
            tabCompanies.Controls.Add(dgvCompanies);
            tabCompanies.Location = new Point(4, 29);
            tabCompanies.Name = "tabCompanies";
            tabCompanies.Padding = new Padding(3);
            tabCompanies.Size = new Size(892, 417);
            tabCompanies.TabIndex = 1;
            tabCompanies.Text = "Companies";
            tabCompanies.UseVisualStyleBackColor = true;
            
            // btnApproveCompany
            // 
            btnApproveCompany.BackColor = Color.RoyalBlue;
            btnApproveCompany.ForeColor = Color.White;
            btnApproveCompany.Location = new Point(720, 340);
            btnApproveCompany.Name = "btnApproveCompany";
            btnApproveCompany.Size = new Size(150, 40);
            btnApproveCompany.TabIndex = 1;
            btnApproveCompany.Text = "Approve Company";
            btnApproveCompany.UseVisualStyleBackColor = false;
            btnApproveCompany.Click += btnApproveCompany_Click;
            
            // dgvCompanies
            // 
            dgvCompanies.AllowUserToAddRows = false;
            dgvCompanies.AllowUserToDeleteRows = false;
            dgvCompanies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompanies.Columns.AddRange(new DataGridViewColumn[] { CompanyId, CompanyName, Industry, JobCount, CompanyStatus });
            dgvCompanies.Location = new Point(20, 20);
            dgvCompanies.MultiSelect = false;
            dgvCompanies.Name = "dgvCompanies";
            dgvCompanies.ReadOnly = true;
            dgvCompanies.RowHeadersWidth = 51;
            dgvCompanies.RowTemplate.Height = 29;
            dgvCompanies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompanies.Size = new Size(850, 300);
            dgvCompanies.TabIndex = 0;
            
            // CompanyId
            // 
            CompanyId.HeaderText = "ID";
            CompanyId.MinimumWidth = 6;
            CompanyId.Name = "CompanyId";
            CompanyId.ReadOnly = true;
            CompanyId.Width = 50;
            
            // CompanyName
            // 
            CompanyName.HeaderText = "Company Name";
            CompanyName.MinimumWidth = 6;
            CompanyName.Name = "CompanyName";
            CompanyName.ReadOnly = true;
            CompanyName.Width = 200;
            
            // Industry
            // 
            Industry.HeaderText = "Industry";
            Industry.MinimumWidth = 6;
            Industry.Name = "Industry";
            Industry.ReadOnly = true;
            Industry.Width = 150;
            
            // JobCount
            // 
            JobCount.HeaderText = "Job Postings";
            JobCount.MinimumWidth = 6;
            JobCount.Name = "JobCount";
            JobCount.ReadOnly = true;
            JobCount.Width = 125;
            
            // CompanyStatus
            // 
            CompanyStatus.HeaderText = "Status";
            CompanyStatus.MinimumWidth = 6;
            CompanyStatus.Name = "CompanyStatus";
            CompanyStatus.ReadOnly = true;
            CompanyStatus.Width = 125;
            
            // tabStudents
            // 
            tabStudents.Controls.Add(btnVerifyStudent);
            tabStudents.Controls.Add(dgvStudents);
            tabStudents.Location = new Point(4, 29);
            tabStudents.Name = "tabStudents";
            tabStudents.Size = new Size(892, 417);
            tabStudents.TabIndex = 2;
            tabStudents.Text = "Students";
            tabStudents.UseVisualStyleBackColor = true;
            
            // btnVerifyStudent
            // 
            btnVerifyStudent.BackColor = Color.ForestGreen;
            btnVerifyStudent.ForeColor = Color.White;
            btnVerifyStudent.Location = new Point(720, 340);
            btnVerifyStudent.Name = "btnVerifyStudent";
            btnVerifyStudent.Size = new Size(150, 40);
            btnVerifyStudent.TabIndex = 1;
            btnVerifyStudent.Text = "Verify Student";
            btnVerifyStudent.UseVisualStyleBackColor = false;
            btnVerifyStudent.Click += btnVerifyStudent_Click;
            
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { StudentId, StudentName, FastId, Degree, GPA, StudentStatus });
            dgvStudents.Location = new Point(20, 20);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.RowTemplate.Height = 29;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(850, 300);
            dgvStudents.TabIndex = 0;
            
            // StudentId
            // 
            StudentId.HeaderText = "ID";
            StudentId.MinimumWidth = 6;
            StudentId.Name = "StudentId";
            StudentId.ReadOnly = true;
            StudentId.Width = 50;
            
            // StudentName
            // 
            StudentName.HeaderText = "Name";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            StudentName.Width = 175;
            
            // FastId
            // 
            FastId.HeaderText = "FAST ID";
            FastId.MinimumWidth = 6;
            FastId.Name = "FastId";
            FastId.ReadOnly = true;
            FastId.Width = 125;
            
            // Degree
            // 
            Degree.HeaderText = "Degree";
            Degree.MinimumWidth = 6;
            Degree.Name = "Degree";
            Degree.ReadOnly = true;
            Degree.Width = 125;
            
            // GPA
            // 
            GPA.HeaderText = "GPA";
            GPA.MinimumWidth = 6;
            GPA.Name = "GPA";
            GPA.ReadOnly = true;
            GPA.Width = 75;
            
            // StudentStatus
            // 
            StudentStatus.HeaderText = "Status";
            StudentStatus.MinimumWidth = 6;
            StudentStatus.Name = "StudentStatus";
            StudentStatus.ReadOnly = true;
            StudentStatus.Width = 125;
            
            // tabReports
            // 
            tabReports.Controls.Add(btnGenerateReports);
            tabReports.Location = new Point(4, 29);
            tabReports.Name = "tabReports";
            tabReports.Size = new Size(892, 417);
            tabReports.TabIndex = 3;
            tabReports.Text = "Reports";
            tabReports.UseVisualStyleBackColor = true;
            
            // btnGenerateReports
            // 
            btnGenerateReports.BackColor = Color.RoyalBlue;
            btnGenerateReports.ForeColor = Color.White;
            btnGenerateReports.Location = new Point(346, 188);
            btnGenerateReports.Name = "btnGenerateReports";
            btnGenerateReports.Size = new Size(200, 50);
            btnGenerateReports.TabIndex = 0;
            btnGenerateReports.Text = "Generate Reports";
            btnGenerateReports.UseVisualStyleBackColor = false;
            btnGenerateReports.Click += btnGenerateReports_Click;
            
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
            
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(962, 653);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Controls.Add(lblWelcome);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Admin Dashboard";
            tabControl1.ResumeLayout(false);
            tabJobFairs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJobFairs).EndInit();
            tabCompanies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCompanies).EndInit();
            tabStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            tabReports.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Panel panel1;
        private Button btnLogout;
    }
} 