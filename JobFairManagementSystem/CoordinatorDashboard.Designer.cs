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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabJobFairs = new System.Windows.Forms.TabPage();
            this.btnViewFairDetails = new System.Windows.Forms.Button();
            this.dgvJobFairs = new System.Windows.Forms.DataGridView();
            this.FairId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FairName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FairDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCompanyRegistrations = new System.Windows.Forms.TabPage();
            this.btnAssignBooth = new System.Windows.Forms.Button();
            this.dgvCompanyRegistrations = new System.Windows.Forms.DataGridView();
            this.RegId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FairNameReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoothNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStudentRegistrations = new System.Windows.Forms.TabPage();
            this.btnGenerateAttendanceList = new System.Windows.Forms.Button();
            this.dgvStudentRegistrations = new System.Windows.Forms.DataGridView();
            this.StudentRegId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FastId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FairNameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentRegStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCommunication = new System.Windows.Forms.TabPage();
            this.btnSendReminders = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabJobFairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobFairs)).BeginInit();
            this.tabCompanyRegistrations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyRegistrations)).BeginInit();
            this.tabStudentRegistrations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRegistrations)).BeginInit();
            this.tabCommunication.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(30, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(272, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Coordinator";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabJobFairs);
            this.tabControl1.Controls.Add(this.tabCompanyRegistrations);
            this.tabControl1.Controls.Add(this.tabStudentRegistrations);
            this.tabControl1.Controls.Add(this.tabCommunication);
            this.tabControl1.Location = new System.Drawing.Point(30, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabJobFairs
            // 
            this.tabJobFairs.Controls.Add(this.btnViewFairDetails);
            this.tabJobFairs.Controls.Add(this.dgvJobFairs);
            this.tabJobFairs.Location = new System.Drawing.Point(4, 29);
            this.tabJobFairs.Name = "tabJobFairs";
            this.tabJobFairs.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobFairs.Size = new System.Drawing.Size(892, 417);
            this.tabJobFairs.TabIndex = 0;
            this.tabJobFairs.Text = "Job Fairs";
            this.tabJobFairs.UseVisualStyleBackColor = true;
            // 
            // btnViewFairDetails
            // 
            this.btnViewFairDetails.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewFairDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewFairDetails.Location = new System.Drawing.Point(720, 340);
            this.btnViewFairDetails.Name = "btnViewFairDetails";
            this.btnViewFairDetails.Size = new System.Drawing.Size(150, 40);
            this.btnViewFairDetails.TabIndex = 1;
            this.btnViewFairDetails.Text = "View Details";
            this.btnViewFairDetails.UseVisualStyleBackColor = false;
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
            // tabCompanyRegistrations
            // 
            this.tabCompanyRegistrations.Controls.Add(this.btnAssignBooth);
            this.tabCompanyRegistrations.Controls.Add(this.dgvCompanyRegistrations);
            this.tabCompanyRegistrations.Location = new System.Drawing.Point(4, 29);
            this.tabCompanyRegistrations.Name = "tabCompanyRegistrations";
            this.tabCompanyRegistrations.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompanyRegistrations.Size = new System.Drawing.Size(892, 417);
            this.tabCompanyRegistrations.TabIndex = 1;
            this.tabCompanyRegistrations.Text = "Company Registrations";
            this.tabCompanyRegistrations.UseVisualStyleBackColor = true;
            // 
            // btnAssignBooth
            // 
            this.btnAssignBooth.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAssignBooth.ForeColor = System.Drawing.Color.White;
            this.btnAssignBooth.Location = new System.Drawing.Point(720, 340);
            this.btnAssignBooth.Name = "btnAssignBooth";
            this.btnAssignBooth.Size = new System.Drawing.Size(150, 40);
            this.btnAssignBooth.TabIndex = 1;
            this.btnAssignBooth.Text = "Assign Booth";
            this.btnAssignBooth.UseVisualStyleBackColor = false;
            // 
            // dgvCompanyRegistrations
            // 
            this.dgvCompanyRegistrations.AllowUserToAddRows = false;
            this.dgvCompanyRegistrations.AllowUserToDeleteRows = false;
            this.dgvCompanyRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanyRegistrations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegId,
            this.CompanyName,
            this.FairNameReg,
            this.BoothNumber,
            this.RegStatus});
            this.dgvCompanyRegistrations.Location = new System.Drawing.Point(20, 20);
            this.dgvCompanyRegistrations.MultiSelect = false;
            this.dgvCompanyRegistrations.Name = "dgvCompanyRegistrations";
            this.dgvCompanyRegistrations.ReadOnly = true;
            this.dgvCompanyRegistrations.RowHeadersWidth = 51;
            this.dgvCompanyRegistrations.RowTemplate.Height = 29;
            this.dgvCompanyRegistrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompanyRegistrations.Size = new System.Drawing.Size(850, 300);
            this.dgvCompanyRegistrations.TabIndex = 0;
            // 
            // RegId
            // 
            this.RegId.HeaderText = "ID";
            this.RegId.MinimumWidth = 6;
            this.RegId.Name = "RegId";
            this.RegId.ReadOnly = true;
            this.RegId.Width = 50;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Company Name";
            this.CompanyName.MinimumWidth = 6;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 200;
            // 
            // FairNameReg
            // 
            this.FairNameReg.HeaderText = "Fair Name";
            this.FairNameReg.MinimumWidth = 6;
            this.FairNameReg.Name = "FairNameReg";
            this.FairNameReg.ReadOnly = true;
            this.FairNameReg.Width = 200;
            // 
            // BoothNumber
            // 
            this.BoothNumber.HeaderText = "Booth Number";
            this.BoothNumber.MinimumWidth = 6;
            this.BoothNumber.Name = "BoothNumber";
            this.BoothNumber.ReadOnly = true;
            this.BoothNumber.Width = 125;
            // 
            // RegStatus
            // 
            this.RegStatus.HeaderText = "Status";
            this.RegStatus.MinimumWidth = 6;
            this.RegStatus.Name = "RegStatus";
            this.RegStatus.ReadOnly = true;
            this.RegStatus.Width = 125;
            // 
            // tabStudentRegistrations
            // 
            this.tabStudentRegistrations.Controls.Add(this.btnGenerateAttendanceList);
            this.tabStudentRegistrations.Controls.Add(this.dgvStudentRegistrations);
            this.tabStudentRegistrations.Location = new System.Drawing.Point(4, 29);
            this.tabStudentRegistrations.Name = "tabStudentRegistrations";
            this.tabStudentRegistrations.Size = new System.Drawing.Size(892, 417);
            this.tabStudentRegistrations.TabIndex = 2;
            this.tabStudentRegistrations.Text = "Student Registrations";
            this.tabStudentRegistrations.UseVisualStyleBackColor = true;
            // 
            // btnGenerateAttendanceList
            // 
            this.btnGenerateAttendanceList.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateAttendanceList.ForeColor = System.Drawing.Color.White;
            this.btnGenerateAttendanceList.Location = new System.Drawing.Point(680, 340);
            this.btnGenerateAttendanceList.Name = "btnGenerateAttendanceList";
            this.btnGenerateAttendanceList.Size = new System.Drawing.Size(190, 40);
            this.btnGenerateAttendanceList.TabIndex = 1;
            this.btnGenerateAttendanceList.Text = "Generate Attendance List";
            this.btnGenerateAttendanceList.UseVisualStyleBackColor = false;
            // 
            // dgvStudentRegistrations
            // 
            this.dgvStudentRegistrations.AllowUserToAddRows = false;
            this.dgvStudentRegistrations.AllowUserToDeleteRows = false;
            this.dgvStudentRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentRegistrations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentRegId,
            this.StudentName,
            this.FastId,
            this.FairNameStudent,
            this.StudentRegStatus});
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
            // StudentRegId
            // 
            this.StudentRegId.HeaderText = "ID";
            this.StudentRegId.MinimumWidth = 6;
            this.StudentRegId.Name = "StudentRegId";
            this.StudentRegId.ReadOnly = true;
            this.StudentRegId.Width = 50;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 170;
            // 
            // FastId
            // 
            this.FastId.HeaderText = "FAST ID";
            this.FastId.MinimumWidth = 6;
            this.FastId.Name = "FastId";
            this.FastId.ReadOnly = true;
            this.FastId.Width = 125;
            // 
            // FairNameStudent
            // 
            this.FairNameStudent.HeaderText = "Fair Name";
            this.FairNameStudent.MinimumWidth = 6;
            this.FairNameStudent.Name = "FairNameStudent";
            this.FairNameStudent.ReadOnly = true;
            this.FairNameStudent.Width = 200;
            // 
            // StudentRegStatus
            // 
            this.StudentRegStatus.HeaderText = "Status";
            this.StudentRegStatus.MinimumWidth = 6;
            this.StudentRegStatus.Name = "StudentRegStatus";
            this.StudentRegStatus.ReadOnly = true;
            this.StudentRegStatus.Width = 125;
            // 
            // tabCommunication
            // 
            this.tabCommunication.Controls.Add(this.btnSendReminders);
            this.tabCommunication.Location = new System.Drawing.Point(4, 29);
            this.tabCommunication.Name = "tabCommunication";
            this.tabCommunication.Size = new System.Drawing.Size(892, 417);
            this.tabCommunication.TabIndex = 3;
            this.tabCommunication.Text = "Communication";
            this.tabCommunication.UseVisualStyleBackColor = true;
            // 
            // btnSendReminders
            // 
            this.btnSendReminders.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSendReminders.ForeColor = System.Drawing.Color.White;
            this.btnSendReminders.Location = new System.Drawing.Point(346, 188);
            this.btnSendReminders.Name = "btnSendReminders";
            this.btnSendReminders.Size = new System.Drawing.Size(200, 50);
            this.btnSendReminders.TabIndex = 0;
            this.btnSendReminders.Text = "Send Reminders";
            this.btnSendReminders.UseVisualStyleBackColor = false;
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
            // CoordinatorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(962, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "CoordinatorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CareerConnect - Coordinator Dashboard";
            this.Load += new System.EventHandler(this.CoordinatorDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabJobFairs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobFairs)).EndInit();
            this.tabCompanyRegistrations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyRegistrations)).EndInit();
            this.tabStudentRegistrations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRegistrations)).EndInit();
            this.tabCommunication.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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