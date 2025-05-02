namespace JobFairManagementSystem
{
    partial class CoordinatorDashboard
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
            dgvJobFairs = new DataGridView();
            FairId = new DataGridViewTextBoxColumn();
            FairName = new DataGridViewTextBoxColumn();
            FairDate = new DataGridViewTextBoxColumn();
            Venue = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            tabCompanyRegistrations = new TabPage();
            btnAssignBooth = new Button();
            dgvCompanyRegistrations = new DataGridView();
            RegId = new DataGridViewTextBoxColumn();
            CompanyName = new DataGridViewTextBoxColumn();
            FairNameReg = new DataGridViewTextBoxColumn();
            BoothNumber = new DataGridViewTextBoxColumn();
            RegStatus = new DataGridViewTextBoxColumn();
            tabStudentRegistrations = new TabPage();
            btnGenerateAttendanceList = new Button();
            dgvStudentRegistrations = new DataGridView();
            StudentRegId = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            FastId = new DataGridViewTextBoxColumn();
            FairNameStudent = new DataGridViewTextBoxColumn();
            StudentRegStatus = new DataGridViewTextBoxColumn();
            tabCommunication = new TabPage();
            btnSendReminders = new Button();
            panel1 = new Panel();
            btnLogout = new Button();
            tabControl1.SuspendLayout();
            tabJobFairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobFairs).BeginInit();
            tabCompanyRegistrations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompanyRegistrations).BeginInit();
            tabStudentRegistrations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentRegistrations).BeginInit();
            tabCommunication.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(30, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(265, 32);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Coordinator";
            
            // tabControl1
            // 
            tabControl1.Controls.Add(tabJobFairs);
            tabControl1.Controls.Add(tabCompanyRegistrations);
            tabControl1.Controls.Add(tabStudentRegistrations);
            tabControl1.Controls.Add(tabCommunication);
            tabControl1.Location = new Point(30, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(900, 450);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            
            // tabJobFairs
            // 
            tabJobFairs.Controls.Add(btnViewFairDetails);
            tabJobFairs.Controls.Add(dgvJobFairs);
            tabJobFairs.Location = new Point(4, 29);
            tabJobFairs.Name = "tabJobFairs";
            tabJobFairs.Padding = new Padding(3);
            tabJobFairs.Size = new Size(892, 417);
            tabJobFairs.TabIndex = 0;
            tabJobFairs.Text = "Job Fairs";
            tabJobFairs.UseVisualStyleBackColor = true;
            
            // btnViewFairDetails
            // 
            btnViewFairDetails.BackColor = Color.RoyalBlue;
            btnViewFairDetails.ForeColor = Color.White;
            btnViewFairDetails.Location = new Point(720, 340);
            btnViewFairDetails.Name = "btnViewFairDetails";
            btnViewFairDetails.Size = new Size(150, 40);
            btnViewFairDetails.TabIndex = 1;
            btnViewFairDetails.Text = "View Details";
            btnViewFairDetails.UseVisualStyleBackColor = false;
            btnViewFairDetails.Click += btnViewFairDetails_Click;
            
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
            
            // tabCompanyRegistrations
            // 
            tabCompanyRegistrations.Controls.Add(btnAssignBooth);
            tabCompanyRegistrations.Controls.Add(dgvCompanyRegistrations);
            tabCompanyRegistrations.Location = new Point(4, 29);
            tabCompanyRegistrations.Name = "tabCompanyRegistrations";
            tabCompanyRegistrations.Padding = new Padding(3);
            tabCompanyRegistrations.Size = new Size(892, 417);
            tabCompanyRegistrations.TabIndex = 1;
            tabCompanyRegistrations.Text = "Company Registrations";
            tabCompanyRegistrations.UseVisualStyleBackColor = true;
            
            // btnAssignBooth
            // 
            btnAssignBooth.BackColor = Color.ForestGreen;
            btnAssignBooth.ForeColor = Color.White;
            btnAssignBooth.Location = new Point(720, 340);
            btnAssignBooth.Name = "btnAssignBooth";
            btnAssignBooth.Size = new Size(150, 40);
            btnAssignBooth.TabIndex = 1;
            btnAssignBooth.Text = "Assign Booth";
            btnAssignBooth.UseVisualStyleBackColor = false;
            btnAssignBooth.Click += btnAssignBooth_Click;
            
            // dgvCompanyRegistrations
            // 
            dgvCompanyRegistrations.AllowUserToAddRows = false;
            dgvCompanyRegistrations.AllowUserToDeleteRows = false;
            dgvCompanyRegistrations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompanyRegistrations.Columns.AddRange(new DataGridViewColumn[] { RegId, CompanyName, FairNameReg, BoothNumber, RegStatus });
            dgvCompanyRegistrations.Location = new Point(20, 20);
            dgvCompanyRegistrations.MultiSelect = false;
            dgvCompanyRegistrations.Name = "dgvCompanyRegistrations";
            dgvCompanyRegistrations.ReadOnly = true;
            dgvCompanyRegistrations.RowHeadersWidth = 51;
            dgvCompanyRegistrations.RowTemplate.Height = 29;
            dgvCompanyRegistrations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompanyRegistrations.Size = new Size(850, 300);
            dgvCompanyRegistrations.TabIndex = 0;
            
            // RegId
            // 
            RegId.HeaderText = "ID";
            RegId.MinimumWidth = 6;
            RegId.Name = "RegId";
            RegId.ReadOnly = true;
            RegId.Width = 50;
            
            // CompanyName
            // 
            CompanyName.HeaderText = "Company Name";
            CompanyName.MinimumWidth = 6;
            CompanyName.Name = "CompanyName";
            CompanyName.ReadOnly = true;
            CompanyName.Width = 200;
            
            // FairNameReg
            // 
            FairNameReg.HeaderText = "Fair Name";
            FairNameReg.MinimumWidth = 6;
            FairNameReg.Name = "FairNameReg";
            FairNameReg.ReadOnly = true;
            FairNameReg.Width = 200;
            
            // BoothNumber
            // 
            BoothNumber.HeaderText = "Booth Number";
            BoothNumber.MinimumWidth = 6;
            BoothNumber.Name = "BoothNumber";
            BoothNumber.ReadOnly = true;
            BoothNumber.Width = 125;
            
            // RegStatus
            // 
            RegStatus.HeaderText = "Status";
            RegStatus.MinimumWidth = 6;
            RegStatus.Name = "RegStatus";
            RegStatus.ReadOnly = true;
            RegStatus.Width = 125;
            
            // tabStudentRegistrations
            // 
            tabStudentRegistrations.Controls.Add(btnGenerateAttendanceList);
            tabStudentRegistrations.Controls.Add(dgvStudentRegistrations);
            tabStudentRegistrations.Location = new Point(4, 29);
            tabStudentRegistrations.Name = "tabStudentRegistrations";
            tabStudentRegistrations.Size = new Size(892, 417);
            tabStudentRegistrations.TabIndex = 2;
            tabStudentRegistrations.Text = "Student Registrations";
            tabStudentRegistrations.UseVisualStyleBackColor = true;
            
            // btnGenerateAttendanceList
            // 
            btnGenerateAttendanceList.BackColor = Color.RoyalBlue;
            btnGenerateAttendanceList.ForeColor = Color.White;
            btnGenerateAttendanceList.Location = new Point(680, 340);
            btnGenerateAttendanceList.Name = "btnGenerateAttendanceList";
            btnGenerateAttendanceList.Size = new Size(190, 40);
            btnGenerateAttendanceList.TabIndex = 1;
            btnGenerateAttendanceList.Text = "Generate Attendance List";
            btnGenerateAttendanceList.UseVisualStyleBackColor = false;
            btnGenerateAttendanceList.Click += btnGenerateAttendanceList_Click;
            
            // dgvStudentRegistrations
            // 
            dgvStudentRegistrations.AllowUserToAddRows = false;
            dgvStudentRegistrations.AllowUserToDeleteRows = false;
            dgvStudentRegistrations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentRegistrations.Columns.AddRange(new DataGridViewColumn[] { StudentRegId, StudentName, FastId, FairNameStudent, StudentRegStatus });
            dgvStudentRegistrations.Location = new Point(20, 20);
            dgvStudentRegistrations.MultiSelect = false;
            dgvStudentRegistrations.Name = "dgvStudentRegistrations";
            dgvStudentRegistrations.ReadOnly = true;
            dgvStudentRegistrations.RowHeadersWidth = 51;
            dgvStudentRegistrations.RowTemplate.Height = 29;
            dgvStudentRegistrations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentRegistrations.Size = new Size(850, 300);
            dgvStudentRegistrations.TabIndex = 0;
            
            // StudentRegId
            // 
            StudentRegId.HeaderText = "ID";
            StudentRegId.MinimumWidth = 6;
            StudentRegId.Name = "StudentRegId";
            StudentRegId.ReadOnly = true;
            StudentRegId.Width = 50;
            
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
            
            // FairNameStudent
            // 
            FairNameStudent.HeaderText = "Fair Name";
            FairNameStudent.MinimumWidth = 6;
            FairNameStudent.Name = "FairNameStudent";
            FairNameStudent.ReadOnly = true;
            FairNameStudent.Width = 200;
            
            // StudentRegStatus
            // 
            StudentRegStatus.HeaderText = "Status";
            StudentRegStatus.MinimumWidth = 6;
            StudentRegStatus.Name = "StudentRegStatus";
            StudentRegStatus.ReadOnly = true;
            StudentRegStatus.Width = 125;
            
            // tabCommunication
            // 
            tabCommunication.Controls.Add(btnSendReminders);
            tabCommunication.Location = new Point(4, 29);
            tabCommunication.Name = "tabCommunication";
            tabCommunication.Size = new Size(892, 417);
            tabCommunication.TabIndex = 3;
            tabCommunication.Text = "Communication";
            tabCommunication.UseVisualStyleBackColor = true;
            
            // btnSendReminders
            // 
            btnSendReminders.BackColor = Color.ForestGreen;
            btnSendReminders.ForeColor = Color.White;
            btnSendReminders.Location = new Point(346, 188);
            btnSendReminders.Name = "btnSendReminders";
            btnSendReminders.Size = new Size(200, 50);
            btnSendReminders.TabIndex = 0;
            btnSendReminders.Text = "Send Reminders";
            btnSendReminders.UseVisualStyleBackColor = false;
            btnSendReminders.Click += btnSendReminders_Click;
            
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
            
            // CoordinatorDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(962, 653);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Controls.Add(lblWelcome);
            Name = "CoordinatorDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Coordinator Dashboard";
            tabControl1.ResumeLayout(false);
            tabJobFairs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJobFairs).EndInit();
            tabCompanyRegistrations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCompanyRegistrations).EndInit();
            tabStudentRegistrations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudentRegistrations).EndInit();
            tabCommunication.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private TabControl tabControl1;
        private TabPage tabJobFairs;
        private TabPage tabCompanyRegistrations;
        private TabPage tabStudentRegistrations;
        private TabPage tabCommunication;
        private DataGridView dgvJobFairs;
        private Button btnViewFairDetails;
        private DataGridViewTextBoxColumn FairId;
        private DataGridViewTextBoxColumn FairName;
        private DataGridViewTextBoxColumn FairDate;
        private DataGridViewTextBoxColumn Venue;
        private DataGridViewTextBoxColumn Status;
        private DataGridView dgvCompanyRegistrations;
        private Button btnAssignBooth;
        private DataGridViewTextBoxColumn RegId;
        private DataGridViewTextBoxColumn CompanyName;
        private DataGridViewTextBoxColumn FairNameReg;
        private DataGridViewTextBoxColumn BoothNumber;
        private DataGridViewTextBoxColumn RegStatus;
        private DataGridView dgvStudentRegistrations;
        private Button btnGenerateAttendanceList;
        private DataGridViewTextBoxColumn StudentRegId;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn FastId;
        private DataGridViewTextBoxColumn FairNameStudent;
        private DataGridViewTextBoxColumn StudentRegStatus;
        private Button btnSendReminders;
        private Panel panel1;
        private Button btnLogout;
    }
} 