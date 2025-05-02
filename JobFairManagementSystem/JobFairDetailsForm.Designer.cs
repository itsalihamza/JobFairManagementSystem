namespace JobFairManagementSystem
{
    partial class JobFairDetailsForm
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
            lblVenueValue = new Label();
            lblVenue = new Label();
            lblTimeValue = new Label();
            lblTime = new Label();
            lblDateValue = new Label();
            lblDate = new Label();
            lblFairNameValue = new Label();
            lblFairName = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblCompanies = new Label();
            dgvCompanies = new DataGridView();
            CompanyName = new DataGridViewTextBoxColumn();
            Positions = new DataGridViewTextBoxColumn();
            BoothNumber = new DataGridViewTextBoxColumn();
            btnRegister = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompanies).BeginInit();
            SuspendLayout();
            
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(240, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "JOB FAIR DETAILS";
            
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblVenueValue);
            panel1.Controls.Add(lblVenue);
            panel1.Controls.Add(lblTimeValue);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(lblDateValue);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblFairNameValue);
            panel1.Controls.Add(lblFairName);
            panel1.Location = new Point(50, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 150);
            panel1.TabIndex = 1;
            
            // lblFairName
            // 
            lblFairName.AutoSize = true;
            lblFairName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFairName.Location = new Point(20, 20);
            lblFairName.Name = "lblFairName";
            lblFairName.Size = new Size(85, 20);
            lblFairName.TabIndex = 0;
            lblFairName.Text = "Fair Name:";
            
            // lblFairNameValue
            // 
            lblFairNameValue.AutoSize = true;
            lblFairNameValue.Location = new Point(150, 20);
            lblFairNameValue.Name = "lblFairNameValue";
            lblFairNameValue.Size = new Size(150, 20);
            lblFairNameValue.TabIndex = 1;
            lblFairNameValue.Text = "Spring 2023 Job Fair";
            
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.Location = new Point(20, 50);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(47, 20);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date:";
            
            // lblDateValue
            // 
            lblDateValue.AutoSize = true;
            lblDateValue.Location = new Point(150, 50);
            lblDateValue.Name = "lblDateValue";
            lblDateValue.Size = new Size(96, 20);
            lblDateValue.TabIndex = 3;
            lblDateValue.Text = "April 15, 2023";
            
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.Location = new Point(20, 80);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(47, 20);
            lblTime.TabIndex = 4;
            lblTime.Text = "Time:";
            
            // lblTimeValue
            // 
            lblTimeValue.AutoSize = true;
            lblTimeValue.Location = new Point(150, 80);
            lblTimeValue.Name = "lblTimeValue";
            lblTimeValue.Size = new Size(125, 20);
            lblTimeValue.TabIndex = 5;
            lblTimeValue.Text = "10:00 AM - 4:00 PM";
            
            // lblVenue
            // 
            lblVenue.AutoSize = true;
            lblVenue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVenue.Location = new Point(20, 110);
            lblVenue.Name = "lblVenue";
            lblVenue.Size = new Size(57, 20);
            lblVenue.TabIndex = 6;
            lblVenue.Text = "Venue:";
            
            // lblVenueValue
            // 
            lblVenueValue.AutoSize = true;
            lblVenueValue.Location = new Point(150, 110);
            lblVenueValue.Name = "lblVenueValue";
            lblVenueValue.Size = new Size(175, 20);
            lblVenueValue.TabIndex = 7;
            lblVenueValue.Text = "FAST-NUCES Auditorium";
            
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(50, 240);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(95, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ControlLightLight;
            txtDescription.Location = new Point(50, 270);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(650, 100);
            txtDescription.TabIndex = 3;
            
            // lblCompanies
            // 
            lblCompanies.AutoSize = true;
            lblCompanies.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompanies.Location = new Point(50, 390);
            lblCompanies.Name = "lblCompanies";
            lblCompanies.Size = new Size(172, 20);
            lblCompanies.TabIndex = 4;
            lblCompanies.Text = "Participating Companies:";
            
            // dgvCompanies
            // 
            dgvCompanies.AllowUserToAddRows = false;
            dgvCompanies.AllowUserToDeleteRows = false;
            dgvCompanies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompanies.Columns.AddRange(new DataGridViewColumn[] { CompanyName, Positions, BoothNumber });
            dgvCompanies.Location = new Point(50, 420);
            dgvCompanies.Name = "dgvCompanies";
            dgvCompanies.ReadOnly = true;
            dgvCompanies.RowHeadersWidth = 51;
            dgvCompanies.RowTemplate.Height = 29;
            dgvCompanies.Size = new Size(650, 180);
            dgvCompanies.TabIndex = 5;
            
            // CompanyName
            // 
            CompanyName.HeaderText = "Company";
            CompanyName.MinimumWidth = 6;
            CompanyName.Name = "CompanyName";
            CompanyName.ReadOnly = true;
            CompanyName.Width = 150;
            
            // Positions
            // 
            Positions.HeaderText = "Available Positions";
            Positions.MinimumWidth = 6;
            Positions.Name = "Positions";
            Positions.ReadOnly = true;
            Positions.Width = 300;
            
            // BoothNumber
            // 
            BoothNumber.HeaderText = "Booth #";
            BoothNumber.MinimumWidth = 6;
            BoothNumber.Name = "BoothNumber";
            BoothNumber.ReadOnly = true;
            BoothNumber.Width = 80;
            
            // btnRegister
            // 
            btnRegister.BackColor = Color.ForestGreen;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(470, 620);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(110, 40);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            
            // btnClose
            // 
            btnClose.Location = new Point(590, 620);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 40);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            
            // JobFairDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(750, 680);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(dgvCompanies);
            Controls.Add(lblCompanies);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "JobFairDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Job Fair Details";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompanies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Label lblVenueValue;
        private Label lblVenue;
        private Label lblTimeValue;
        private Label lblTime;
        private Label lblDateValue;
        private Label lblDate;
        private Label lblFairNameValue;
        private Label lblFairName;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblCompanies;
        private DataGridView dgvCompanies;
        private DataGridViewTextBoxColumn CompanyName;
        private DataGridViewTextBoxColumn Positions;
        private DataGridViewTextBoxColumn BoothNumber;
        private Button btnRegister;
        private Button btnClose;
    }
} 