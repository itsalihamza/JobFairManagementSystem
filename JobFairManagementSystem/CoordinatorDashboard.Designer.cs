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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAssignedFair = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabJobFairs = new System.Windows.Forms.TabPage();
            this.btnViewFairDetails = new System.Windows.Forms.Button();
            this.dgvJobFairs = new System.Windows.Forms.DataGridView();
            this.FairId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FairName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCompanies = new System.Windows.Forms.TabPage();
            this.grpBoothCheckin = new System.Windows.Forms.GroupBox();
            this.btnBoothCheckin = new System.Windows.Forms.Button();
            this.txtBoothFastId = new System.Windows.Forms.TextBox();
            this.lblBoothFastId = new System.Windows.Forms.Label();
            this.lblSelectCompany = new System.Windows.Forms.Label();
            this.btnAssignBooth = new System.Windows.Forms.Button();
            this.dgvCompanyRegistrations = new System.Windows.Forms.DataGridView();
            this.CompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobFair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoothNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.grpStudentCheckin = new System.Windows.Forms.GroupBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.txtFastId = new System.Windows.Forms.TextBox();
            this.lblFastId = new System.Windows.Forms.Label();
            this.btnSendReminders = new System.Windows.Forms.Button();
            this.dgvStudentRegistrations = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FASTId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentJobFair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckinStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.btnGenerateAttendanceList = new System.Windows.Forms.Button();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.VisitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendeeStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendeeFastId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoothCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabJobFairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobFairs)).BeginInit();
            this.tabCompanies.SuspendLayout();
            this.grpBoothCheckin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyRegistrations)).BeginInit();
            this.tabStudents.SuspendLayout();
            this.grpStudentCheckin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRegistrations)).BeginInit();
            this.tabAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(30, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(268, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Coordinator";
            // 
            // lblAssignedFair
            // 
            this.lblAssignedFair.AutoSize = true;
            this.lblAssignedFair.Location = new System.Drawing.Point(32, 52);
            this.lblAssignedFair.Name = "lblAssignedFair";
            this.lblAssignedFair.Size = new System.Drawing.Size(136, 20);
            this.lblAssignedFair.TabIndex = 1;
            this.lblAssignedFair.Text = "Assigned Job Fair: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabJobFairs);
            this.tabControl1.Controls.Add(this.tabCompanies);
            this.tabControl1.Controls.Add(this.tabStudents);
            this.tabControl1.Controls.Add(this.tabAttendance);
            this.tabControl1.Location = new System.Drawing.Point(30, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 500);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabJobFairs
            // 
            this.tabJobFairs.Controls.Add(this.btnViewFairDetails);
            this.tabJobFairs.Controls.Add(this.dgvJobFairs);
            this.tabJobFairs.Location = new System.Drawing.Point(4, 29);
            this.tabJobFairs.Name = "tabJobFairs";
            this.tabJobFairs.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobFairs.Size = new System.Drawing.Size(892, 467);
            this.tabJobFairs.TabIndex = 0;
            this.tabJobFairs.Text = "Job Fair";
            this.tabJobFairs.UseVisualStyleBackColor = true;
            // 
            // btnViewFairDetails
            // 
            this.btnViewFairDetails.Location = new System.Drawing.Point(700, 425);
            this.btnViewFairDetails.Name = "btnViewFairDetails";
            this.btnViewFairDetails.Size = new System.Drawing.Size(170, 29);
            this.btnViewFairDetails.TabIndex = 1;
            this.btnViewFairDetails.Text = "View Fair Details";
            this.btnViewFairDetails.UseVisualStyleBackColor = true;
            this.btnViewFairDetails.Click += new System.EventHandler(this.btnViewFairDetails_Click);
            // 
            // dgvJobFairs
            // 
            this.dgvJobFairs.AllowUserToAddRows = false;
            this.dgvJobFairs.AllowUserToDeleteRows = false;
            this.dgvJobFairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobFairs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FairId,
            this.FairName,
            this.Date,
            this.Venue,
            this.Status});
            this.dgvJobFairs.Location = new System.Drawing.Point(20, 20);
            this.dgvJobFairs.MultiSelect = false;
            this.dgvJobFairs.Name = "dgvJobFairs";
            this.dgvJobFairs.ReadOnly = true;
            this.dgvJobFairs.RowHeadersWidth = 51;
            this.dgvJobFairs.RowTemplate.Height = 29;
            this.dgvJobFairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobFairs.Size = new System.Drawing.Size(850, 385);
            this.dgvJobFairs.TabIndex = 0;
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
            this.FairName.HeaderText = "Job Fair Name";
            this.FairName.MinimumWidth = 6;
            this.FairName.Name = "FairName";
            this.FairName.ReadOnly = true;
            this.FairName.Width = 240;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
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
            this.tabCompanies.Controls.Add(this.grpBoothCheckin);
            this.tabCompanies.Controls.Add(this.btnAssignBooth);
            this.tabCompanies.Controls.Add(this.dgvCompanyRegistrations);
            this.tabCompanies.Location = new System.Drawing.Point(4, 29);
            this.tabCompanies.Name = "tabCompanies";
            this.tabCompanies.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompanies.Size = new System.Drawing.Size(892, 467);
            this.tabCompanies.TabIndex = 1;
            this.tabCompanies.Text = "Company Booths";
            this.tabCompanies.UseVisualStyleBackColor = true;
            // 
            // grpBoothCheckin
            // 
            this.grpBoothCheckin.Controls.Add(this.btnBoothCheckin);
            this.grpBoothCheckin.Controls.Add(this.txtBoothFastId);
            this.grpBoothCheckin.Controls.Add(this.lblBoothFastId);
            this.grpBoothCheckin.Controls.Add(this.lblSelectCompany);
            this.grpBoothCheckin.Location = new System.Drawing.Point(20, 305);
            this.grpBoothCheckin.Name = "grpBoothCheckin";
            this.grpBoothCheckin.Size = new System.Drawing.Size(500, 150);
            this.grpBoothCheckin.TabIndex = 2;
            this.grpBoothCheckin.TabStop = false;
            this.grpBoothCheckin.Text = "Record Booth Visit";
            // 
            // btnBoothCheckin
            // 
            this.btnBoothCheckin.BackColor = System.Drawing.Color.Green;
            this.btnBoothCheckin.ForeColor = System.Drawing.Color.White;
            this.btnBoothCheckin.Location = new System.Drawing.Point(320, 100);
            this.btnBoothCheckin.Name = "btnBoothCheckin";
            this.btnBoothCheckin.Size = new System.Drawing.Size(150, 35);
            this.btnBoothCheckin.TabIndex = 3;
            this.btnBoothCheckin.Text = "Check In at Booth";
            this.btnBoothCheckin.UseVisualStyleBackColor = false;
            this.btnBoothCheckin.Click += new System.EventHandler(this.btnBoothCheckin_Click);
            // 
            // txtBoothFastId
            // 
            this.txtBoothFastId.Location = new System.Drawing.Point(140, 100);
            this.txtBoothFastId.Name = "txtBoothFastId";
            this.txtBoothFastId.Size = new System.Drawing.Size(150, 27);
            this.txtBoothFastId.TabIndex = 2;
            // 
            // lblBoothFastId
            // 
            this.lblBoothFastId.AutoSize = true;
            this.lblBoothFastId.Location = new System.Drawing.Point(20, 103);
            this.lblBoothFastId.Name = "lblBoothFastId";
            this.lblBoothFastId.Size = new System.Drawing.Size(108, 20);
            this.lblBoothFastId.TabIndex = 1;
            this.lblBoothFastId.Text = "Student FAST ID:";
            // 
            // lblSelectCompany
            // 
            this.lblSelectCompany.AutoSize = true;
            this.lblSelectCompany.Location = new System.Drawing.Point(20, 40);
            this.lblSelectCompany.Name = "lblSelectCompany";
            this.lblSelectCompany.Size = new System.Drawing.Size(433, 40);
            this.lblSelectCompany.TabIndex = 0;
            this.lblSelectCompany.Text = "1. Select a company booth from the table above\r\n2. Enter the student's FAST ID and click Check In to record their visit";
            // 
            // btnAssignBooth
            // 
            this.btnAssignBooth.Location = new System.Drawing.Point(720, 270);
            this.btnAssignBooth.Name = "btnAssignBooth";
            this.btnAssignBooth.Size = new System.Drawing.Size(150, 29);
            this.btnAssignBooth.TabIndex = 1;
            this.btnAssignBooth.Text = "Assign Booth";
            this.btnAssignBooth.UseVisualStyleBackColor = true;
            this.btnAssignBooth.Click += new System.EventHandler(this.btnAssignBooth_Click);
            // 
            // dgvCompanyRegistrations
            // 
            this.dgvCompanyRegistrations.AllowUserToAddRows = false;
            this.dgvCompanyRegistrations.AllowUserToDeleteRows = false;
            this.dgvCompanyRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanyRegistrations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyId,
            this.CompanyName,
            this.JobFair,
            this.BoothNumber,
            this.RegistrationStatus});
            this.dgvCompanyRegistrations.Location = new System.Drawing.Point(20, 20);
            this.dgvCompanyRegistrations.MultiSelect = false;
            this.dgvCompanyRegistrations.Name = "dgvCompanyRegistrations";
            this.dgvCompanyRegistrations.ReadOnly = true;
            this.dgvCompanyRegistrations.RowHeadersWidth = 51;
            this.dgvCompanyRegistrations.RowTemplate.Height = 29;
            this.dgvCompanyRegistrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompanyRegistrations.Size = new System.Drawing.Size(850, 230);
            this.dgvCompanyRegistrations.TabIndex = 0;
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
            // JobFair
            // 
            this.JobFair.HeaderText = "Job Fair";
            this.JobFair.MinimumWidth = 6;
            this.JobFair.Name = "JobFair";
            this.JobFair.ReadOnly = true;
            this.JobFair.Width = 220;
            // 
            // BoothNumber
            // 
            this.BoothNumber.HeaderText = "Booth Number";
            this.BoothNumber.MinimumWidth = 6;
            this.BoothNumber.Name = "BoothNumber";
            this.BoothNumber.ReadOnly = true;
            this.BoothNumber.Width = 125;
            // 
            // RegistrationStatus
            // 
            this.RegistrationStatus.HeaderText = "Status";
            this.RegistrationStatus.MinimumWidth = 6;
            this.RegistrationStatus.Name = "RegistrationStatus";
            this.RegistrationStatus.ReadOnly = true;
            this.RegistrationStatus.Width = 125;
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.grpStudentCheckin);
            this.tabStudents.Controls.Add(this.btnSendReminders);
            this.tabStudents.Controls.Add(this.dgvStudentRegistrations);
            this.tabStudents.Location = new System.Drawing.Point(4, 29);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(892, 467);
            this.tabStudents.TabIndex = 2;
            this.tabStudents.Text = "Student Registrations";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // grpStudentCheckin
            // 
            this.grpStudentCheckin.Controls.Add(this.btnCheckIn);
            this.grpStudentCheckin.Controls.Add(this.txtFastId);
            this.grpStudentCheckin.Controls.Add(this.lblFastId);
            this.grpStudentCheckin.Location = new System.Drawing.Point(20, 340);
            this.grpStudentCheckin.Name = "grpStudentCheckin";
            this.grpStudentCheckin.Size = new System.Drawing.Size(500, 110);
            this.grpStudentCheckin.TabIndex = 2;
            this.grpStudentCheckin.TabStop = false;
            this.grpStudentCheckin.Text = "Student Check-in";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Green;
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(320, 50);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(150, 35);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // txtFastId
            // 
            this.txtFastId.Location = new System.Drawing.Point(140, 50);
            this.txtFastId.Name = "txtFastId";
            this.txtFastId.Size = new System.Drawing.Size(150, 27);
            this.txtFastId.TabIndex = 1;
            // 
            // lblFastId
            // 
            this.lblFastId.AutoSize = true;
            this.lblFastId.Location = new System.Drawing.Point(20, 53);
            this.lblFastId.Name = "lblFastId";
            this.lblFastId.Size = new System.Drawing.Size(108, 20);
            this.lblFastId.TabIndex = 0;
            this.lblFastId.Text = "Student FAST ID:";
            // 
            // btnSendReminders
            // 
            this.btnSendReminders.Location = new System.Drawing.Point(720, 340);
            this.btnSendReminders.Name = "btnSendReminders";
            this.btnSendReminders.Size = new System.Drawing.Size(150, 29);
            this.btnSendReminders.TabIndex = 1;
            this.btnSendReminders.Text = "Send Reminders";
            this.btnSendReminders.UseVisualStyleBackColor = true;
            this.btnSendReminders.Click += new System.EventHandler(this.btnSendReminders_Click);
            // 
            // dgvStudentRegistrations
            // 
            this.dgvStudentRegistrations.AllowUserToAddRows = false;
            this.dgvStudentRegistrations.AllowUserToDeleteRows = false;
            this.dgvStudentRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentRegistrations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.FASTId,
            this.StudentJobFair,
            this.CheckinStatus});
            this.dgvStudentRegistrations.Location = new System.Drawing.Point(20, 20);
            this.dgvStudentRegistrations.MultiSelect = false;
            this.dgvStudentRegistrations.Name = "dgvStudentRegistrations";
            this.dgvStudentRegistrations.ReadOnly = true;
            this.dgvStudentRegistrations.RowHeadersWidth = 51;
            this.dgvStudentRegistrations.RowTemplate.Height = 29;
            this.dgvStudentRegistrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentRegistrations.Size = new System.Drawing.Size(850, 300);
            this.dgvStudentRegistrations.TabIndex = 0;
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
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 200;
            // 
            // FASTId
            // 
            this.FASTId.HeaderText = "FAST ID";
            this.FASTId.MinimumWidth = 6;
            this.FASTId.Name = "FASTId";
            this.FASTId.ReadOnly = true;
            this.FASTId.Width = 125;
            // 
            // StudentJobFair
            // 
            this.StudentJobFair.HeaderText = "Fair Name";
            this.StudentJobFair.MinimumWidth = 6;
            this.StudentJobFair.Name = "StudentJobFair";
            this.StudentJobFair.ReadOnly = true;
            this.StudentJobFair.Width = 200;
            // 
            // CheckinStatus
            // 
            this.CheckinStatus.HeaderText = "Status";
            this.CheckinStatus.MinimumWidth = 6;
            this.CheckinStatus.Name = "CheckinStatus";
            this.CheckinStatus.ReadOnly = true;
            this.CheckinStatus.Width = 125;
            // 
            // tabAttendance
            // 
            this.tabAttendance.Controls.Add(this.btnGenerateAttendanceList);
            this.tabAttendance.Controls.Add(this.dgvAttendance);
            this.tabAttendance.Location = new System.Drawing.Point(4, 29);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Size = new System.Drawing.Size(892, 467);
            this.tabAttendance.TabIndex = 3;
            this.tabAttendance.Text = "Attendance";
            this.tabAttendance.UseVisualStyleBackColor = true;
            // 
            // btnGenerateAttendanceList
            // 
            this.btnGenerateAttendanceList.Location = new System.Drawing.Point(720, 340);
            this.btnGenerateAttendanceList.Name = "btnGenerateAttendanceList";
            this.btnGenerateAttendanceList.Size = new System.Drawing.Size(150, 29);
            this.btnGenerateAttendanceList.TabIndex = 1;
            this.btnGenerateAttendanceList.Text = "Generate Attendance List";
            this.btnGenerateAttendanceList.UseVisualStyleBackColor = true;
            this.btnGenerateAttendanceList.Click += new System.EventHandler(this.btnGenerateAttendanceList_Click);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VisitId,
            this.AttendeeStudent,
            this.AttendeeFastId,
            this.BoothCompany,
            this.CheckInTime});
            this.dgvAttendance.Location = new System.Drawing.Point(20, 20);
            this.dgvAttendance.MultiSelect = false;
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 29;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(850, 385);
            this.dgvAttendance.TabIndex = 0;
            // 
            // VisitId
            // 
            this.VisitId.HeaderText = "Visit ID";
            this.VisitId.MinimumWidth = 6;
            this.VisitId.Name = "VisitId";
            this.VisitId.ReadOnly = true;
            this.VisitId.Width = 125;
            // 
            // AttendeeStudent
            // 
            this.AttendeeStudent.HeaderText = "Student Name";
            this.AttendeeStudent.MinimumWidth = 6;
            this.AttendeeStudent.Name = "AttendeeStudent";
            this.AttendeeStudent.ReadOnly = true;
            this.AttendeeStudent.Width = 200;
            // 
            // AttendeeFastId
            // 
            this.AttendeeFastId.HeaderText = "Student FAST ID";
            this.AttendeeFastId.MinimumWidth = 6;
            this.AttendeeFastId.Name = "AttendeeFastId";
            this.AttendeeFastId.ReadOnly = true;
            this.AttendeeFastId.Width = 125;
            // 
            // BoothCompany
            // 
            this.BoothCompany.HeaderText = "Company Booth";
            this.BoothCompany.MinimumWidth = 6;
            this.BoothCompany.Name = "BoothCompany";
            this.BoothCompany.ReadOnly = true;
            this.BoothCompany.Width = 200;
            // 
            // CheckInTime
            // 
            this.CheckInTime.HeaderText = "Check-in Time";
            this.CheckInTime.MinimumWidth = 6;
            this.CheckInTime.Name = "CheckInTime";
            this.CheckInTime.ReadOnly = true;
            this.CheckInTime.Width = 125;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(830, 600);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 29);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(34, 587);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 50);
            this.panel1.TabIndex = 4;
            // 
            // CoordinatorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblAssignedFair);
            this.Controls.Add(this.lblWelcome);
            this.Name = "CoordinatorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CareerConnect - Booth Coordinator Dashboard";
            this.Load += new System.EventHandler(this.CoordinatorDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabJobFairs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobFairs)).EndInit();
            this.tabCompanies.ResumeLayout(false);
            this.grpBoothCheckin.ResumeLayout(false);
            this.grpBoothCheckin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyRegistrations)).EndInit();
            this.tabStudents.ResumeLayout(false);
            this.grpStudentCheckin.ResumeLayout(false);
            this.grpStudentCheckin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRegistrations)).EndInit();
            this.tabAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAssignedFair;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabJobFairs;
        private System.Windows.Forms.TabPage tabCompanies;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.DataGridView dgvJobFairs;
        private System.Windows.Forms.Button btnViewFairDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn FairId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FairName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridView dgvCompanyRegistrations;
        private System.Windows.Forms.Button btnAssignBooth;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobFair;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoothNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationStatus;
        private System.Windows.Forms.DataGridView dgvStudentRegistrations;
        private System.Windows.Forms.Button btnSendReminders;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FASTId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentJobFair;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckinStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendeeStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendeeFastId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoothCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInTime;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGenerateAttendanceList;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.GroupBox grpBoothCheckin;
        private System.Windows.Forms.Button btnBoothCheckin;
        private System.Windows.Forms.TextBox txtBoothFastId;
        private System.Windows.Forms.Label lblBoothFastId;
        private System.Windows.Forms.Label lblSelectCompany;
        private System.Windows.Forms.GroupBox grpStudentCheckin;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.TextBox txtFastId;
        private System.Windows.Forms.Label lblFastId;
        private System.Windows.Forms.Panel panel1;
    }
} 