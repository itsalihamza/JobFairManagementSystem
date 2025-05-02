namespace JobFairManagementSystem
{
    partial class JobFairRegistrationForm
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
            lblRegistrationFeeValue = new Label();
            lblRegistrationFee = new Label();
            lblTimeValue = new Label();
            lblTime = new Label();
            lblVenueValue = new Label();
            lblVenue = new Label();
            lblDateValue = new Label();
            lblDate = new Label();
            lblFairNameValue = new Label();
            lblFairName = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblJobPositions = new Label();
            grpJobPositions = new GroupBox();
            lblOtherPositions = new Label();
            txtOtherPositions = new TextBox();
            chkNetworkEngineer = new CheckBox();
            chkUIUXDesigner = new CheckBox();
            chkAIEngineer = new CheckBox();
            chkDataScientist = new CheckBox();
            chkWebDeveloper = new CheckBox();
            chkSoftwareEngineer = new CheckBox();
            lblCompanyReps = new Label();
            txtCompanyReps = new TextBox();
            lblSpecialRequirements = new Label();
            txtSpecialRequirements = new TextBox();
            chkAgreeTerms = new CheckBox();
            btnRegister = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            grpJobPositions.SuspendLayout();
            SuspendLayout();
            
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(180, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "JOB FAIR REGISTRATION";
            
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblRegistrationFeeValue);
            panel1.Controls.Add(lblRegistrationFee);
            panel1.Controls.Add(lblTimeValue);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(lblVenueValue);
            panel1.Controls.Add(lblVenue);
            panel1.Controls.Add(lblDateValue);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblFairNameValue);
            panel1.Controls.Add(lblFairName);
            panel1.Location = new Point(30, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 150);
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
            lblFairNameValue.Location = new Point(160, 20);
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
            lblDateValue.Location = new Point(160, 50);
            lblDateValue.Name = "lblDateValue";
            lblDateValue.Size = new Size(96, 20);
            lblDateValue.TabIndex = 3;
            lblDateValue.Text = "April 15, 2023";
            
            // lblVenue
            // 
            lblVenue.AutoSize = true;
            lblVenue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVenue.Location = new Point(20, 80);
            lblVenue.Name = "lblVenue";
            lblVenue.Size = new Size(57, 20);
            lblVenue.TabIndex = 4;
            lblVenue.Text = "Venue:";
            
            // lblVenueValue
            // 
            lblVenueValue.AutoSize = true;
            lblVenueValue.Location = new Point(160, 80);
            lblVenueValue.Name = "lblVenueValue";
            lblVenueValue.Size = new Size(175, 20);
            lblVenueValue.TabIndex = 5;
            lblVenueValue.Text = "FAST-NUCES Auditorium";
            
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.Location = new Point(20, 110);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(47, 20);
            lblTime.TabIndex = 6;
            lblTime.Text = "Time:";
            
            // lblTimeValue
            // 
            lblTimeValue.AutoSize = true;
            lblTimeValue.Location = new Point(160, 110);
            lblTimeValue.Name = "lblTimeValue";
            lblTimeValue.Size = new Size(125, 20);
            lblTimeValue.TabIndex = 7;
            lblTimeValue.Text = "10:00 AM - 4:00 PM";
            
            // lblRegistrationFee
            // 
            lblRegistrationFee.AutoSize = true;
            lblRegistrationFee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrationFee.Location = new Point(350, 20);
            lblRegistrationFee.Name = "lblRegistrationFee";
            lblRegistrationFee.Size = new Size(128, 20);
            lblRegistrationFee.TabIndex = 8;
            lblRegistrationFee.Text = "Registration Fee:";
            
            // lblRegistrationFeeValue
            // 
            lblRegistrationFeeValue.AutoSize = true;
            lblRegistrationFeeValue.Location = new Point(500, 20);
            lblRegistrationFeeValue.Name = "lblRegistrationFeeValue";
            lblRegistrationFeeValue.Size = new Size(44, 20);
            lblRegistrationFeeValue.TabIndex = 9;
            lblRegistrationFeeValue.Text = "$500";
            
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(30, 240);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(95, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ControlLightLight;
            txtDescription.Location = new Point(30, 270);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(640, 80);
            txtDescription.TabIndex = 3;
            
            // lblJobPositions
            // 
            lblJobPositions.AutoSize = true;
            lblJobPositions.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblJobPositions.Location = new Point(30, 380);
            lblJobPositions.Name = "lblJobPositions";
            lblJobPositions.Size = new Size(293, 20);
            lblJobPositions.TabIndex = 4;
            lblJobPositions.Text = "Job Positions You Are Recruiting For:";
            
            // grpJobPositions
            // 
            grpJobPositions.Controls.Add(lblOtherPositions);
            grpJobPositions.Controls.Add(txtOtherPositions);
            grpJobPositions.Controls.Add(chkNetworkEngineer);
            grpJobPositions.Controls.Add(chkUIUXDesigner);
            grpJobPositions.Controls.Add(chkAIEngineer);
            grpJobPositions.Controls.Add(chkDataScientist);
            grpJobPositions.Controls.Add(chkWebDeveloper);
            grpJobPositions.Controls.Add(chkSoftwareEngineer);
            grpJobPositions.Location = new Point(30, 410);
            grpJobPositions.Name = "grpJobPositions";
            grpJobPositions.Size = new Size(640, 150);
            grpJobPositions.TabIndex = 0;
            grpJobPositions.TabStop = false;
            
            // chkSoftwareEngineer
            // 
            chkSoftwareEngineer.AutoSize = true;
            chkSoftwareEngineer.Location = new Point(20, 30);
            chkSoftwareEngineer.Name = "chkSoftwareEngineer";
            chkSoftwareEngineer.Size = new Size(155, 24);
            chkSoftwareEngineer.TabIndex = 0;
            chkSoftwareEngineer.Text = "Software Engineer";
            chkSoftwareEngineer.UseVisualStyleBackColor = true;
            
            // chkWebDeveloper
            // 
            chkWebDeveloper.AutoSize = true;
            chkWebDeveloper.Location = new Point(20, 60);
            chkWebDeveloper.Name = "chkWebDeveloper";
            chkWebDeveloper.Size = new Size(139, 24);
            chkWebDeveloper.TabIndex = 1;
            chkWebDeveloper.Text = "Web Developer";
            chkWebDeveloper.UseVisualStyleBackColor = true;
            
            // chkDataScientist
            // 
            chkDataScientist.AutoSize = true;
            chkDataScientist.Location = new Point(200, 30);
            chkDataScientist.Name = "chkDataScientist";
            chkDataScientist.Size = new Size(124, 24);
            chkDataScientist.TabIndex = 2;
            chkDataScientist.Text = "Data Scientist";
            chkDataScientist.UseVisualStyleBackColor = true;
            
            // chkAIEngineer
            // 
            chkAIEngineer.AutoSize = true;
            chkAIEngineer.Location = new Point(200, 60);
            chkAIEngineer.Name = "chkAIEngineer";
            chkAIEngineer.Size = new Size(108, 24);
            chkAIEngineer.TabIndex = 3;
            chkAIEngineer.Text = "AI Engineer";
            chkAIEngineer.UseVisualStyleBackColor = true;
            
            // chkUIUXDesigner
            // 
            chkUIUXDesigner.AutoSize = true;
            chkUIUXDesigner.Location = new Point(380, 30);
            chkUIUXDesigner.Name = "chkUIUXDesigner";
            chkUIUXDesigner.Size = new Size(136, 24);
            chkUIUXDesigner.TabIndex = 4;
            chkUIUXDesigner.Text = "UI/UX Designer";
            chkUIUXDesigner.UseVisualStyleBackColor = true;
            
            // chkNetworkEngineer
            // 
            chkNetworkEngineer.AutoSize = true;
            chkNetworkEngineer.Location = new Point(380, 60);
            chkNetworkEngineer.Name = "chkNetworkEngineer";
            chkNetworkEngineer.Size = new Size(158, 24);
            chkNetworkEngineer.TabIndex = 5;
            chkNetworkEngineer.Text = "Network Engineer";
            chkNetworkEngineer.UseVisualStyleBackColor = true;
            
            // txtOtherPositions
            // 
            txtOtherPositions.Location = new Point(170, 100);
            txtOtherPositions.Name = "txtOtherPositions";
            txtOtherPositions.Size = new Size(450, 27);
            txtOtherPositions.TabIndex = 6;
            txtOtherPositions.PlaceholderText = "Enter other positions separated by commas";
            
            // lblOtherPositions
            // 
            lblOtherPositions.AutoSize = true;
            lblOtherPositions.Location = new Point(20, 103);
            lblOtherPositions.Name = "lblOtherPositions";
            lblOtherPositions.Size = new Size(112, 20);
            lblOtherPositions.TabIndex = 7;
            lblOtherPositions.Text = "Other Positions:";
            
            // lblCompanyReps
            // 
            lblCompanyReps.AutoSize = true;
            lblCompanyReps.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompanyReps.Location = new Point(30, 580);
            lblCompanyReps.Name = "lblCompanyReps";
            lblCompanyReps.Size = new Size(194, 20);
            lblCompanyReps.TabIndex = 6;
            lblCompanyReps.Text = "Company Representatives:";
            
            // txtCompanyReps
            // 
            txtCompanyReps.Location = new Point(260, 580);
            txtCompanyReps.Name = "txtCompanyReps";
            txtCompanyReps.Size = new Size(410, 27);
            txtCompanyReps.TabIndex = 1;
            txtCompanyReps.PlaceholderText = "Names of representatives attending the fair";
            
            // lblSpecialRequirements
            // 
            lblSpecialRequirements.AutoSize = true;
            lblSpecialRequirements.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSpecialRequirements.Location = new Point(30, 620);
            lblSpecialRequirements.Name = "lblSpecialRequirements";
            lblSpecialRequirements.Size = new Size(171, 20);
            lblSpecialRequirements.TabIndex = 8;
            lblSpecialRequirements.Text = "Special Requirements:";
            
            // txtSpecialRequirements
            // 
            txtSpecialRequirements.Location = new Point(260, 620);
            txtSpecialRequirements.Name = "txtSpecialRequirements";
            txtSpecialRequirements.Size = new Size(410, 27);
            txtSpecialRequirements.TabIndex = 2;
            txtSpecialRequirements.PlaceholderText = "Any special booth or equipment needs";
            
            // chkAgreeTerms
            // 
            chkAgreeTerms.AutoSize = true;
            chkAgreeTerms.Location = new Point(30, 670);
            chkAgreeTerms.Name = "chkAgreeTerms";
            chkAgreeTerms.Size = new Size(534, 24);
            chkAgreeTerms.TabIndex = 3;
            chkAgreeTerms.Text = "I agree to the terms and conditions, including the registration fee payment.";
            chkAgreeTerms.UseVisualStyleBackColor = true;
            
            // btnRegister
            // 
            btnRegister.BackColor = Color.ForestGreen;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(450, 720);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 40);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            
            // btnCancel
            // 
            btnCancel.Location = new Point(580, 720);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            
            // JobFairRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(700, 780);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(chkAgreeTerms);
            Controls.Add(txtSpecialRequirements);
            Controls.Add(lblSpecialRequirements);
            Controls.Add(txtCompanyReps);
            Controls.Add(lblCompanyReps);
            Controls.Add(grpJobPositions);
            Controls.Add(lblJobPositions);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "JobFairRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Job Fair Registration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpJobPositions.ResumeLayout(false);
            grpJobPositions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Label lblRegistrationFeeValue;
        private Label lblRegistrationFee;
        private Label lblTimeValue;
        private Label lblTime;
        private Label lblVenueValue;
        private Label lblVenue;
        private Label lblDateValue;
        private Label lblDate;
        private Label lblFairNameValue;
        private Label lblFairName;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblJobPositions;
        private GroupBox grpJobPositions;
        private Label lblOtherPositions;
        private TextBox txtOtherPositions;
        private CheckBox chkNetworkEngineer;
        private CheckBox chkUIUXDesigner;
        private CheckBox chkAIEngineer;
        private CheckBox chkDataScientist;
        private CheckBox chkWebDeveloper;
        private CheckBox chkSoftwareEngineer;
        private Label lblCompanyReps;
        private TextBox txtCompanyReps;
        private Label lblSpecialRequirements;
        private TextBox txtSpecialRequirements;
        private CheckBox chkAgreeTerms;
        private Button btnRegister;
        private Button btnCancel;
    }
} 