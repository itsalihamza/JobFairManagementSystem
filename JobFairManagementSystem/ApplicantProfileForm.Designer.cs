namespace JobFairManagementSystem
{
    partial class ApplicantProfileForm
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
            lblGPAValue = new Label();
            lblGPA = new Label();
            lblSemesterValue = new Label();
            lblSemester = new Label();
            lblDegreeValue = new Label();
            lblDegree = new Label();
            lblFastIdValue = new Label();
            lblFastId = new Label();
            lblNameValue = new Label();
            lblName = new Label();
            tabControl1 = new TabControl();
            tabSkills = new TabPage();
            lstSkills = new ListBox();
            tabCertifications = new TabPage();
            lstCertifications = new ListBox();
            tabEducation = new TabPage();
            txtEducation = new TextBox();
            tabExperience = new TabPage();
            txtExperience = new TextBox();
            btnClose = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabSkills.SuspendLayout();
            tabCertifications.SuspendLayout();
            tabEducation.SuspendLayout();
            tabExperience.SuspendLayout();
            SuspendLayout();
            
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(210, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(259, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "APPLICANT PROFILE";
            
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblGPAValue);
            panel1.Controls.Add(lblGPA);
            panel1.Controls.Add(lblSemesterValue);
            panel1.Controls.Add(lblSemester);
            panel1.Controls.Add(lblDegreeValue);
            panel1.Controls.Add(lblDegree);
            panel1.Controls.Add(lblFastIdValue);
            panel1.Controls.Add(lblFastId);
            panel1.Controls.Add(lblNameValue);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(30, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 150);
            panel1.TabIndex = 1;
            
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(20, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            
            // lblNameValue
            // 
            lblNameValue.AutoSize = true;
            lblNameValue.Location = new Point(160, 20);
            lblNameValue.Name = "lblNameValue";
            lblNameValue.Size = new Size(76, 20);
            lblNameValue.TabIndex = 1;
            lblNameValue.Text = "John Doe";
            
            // lblFastId
            // 
            lblFastId.AutoSize = true;
            lblFastId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFastId.Location = new Point(20, 50);
            lblFastId.Name = "lblFastId";
            lblFastId.Size = new Size(66, 20);
            lblFastId.TabIndex = 2;
            lblFastId.Text = "FAST ID:";
            
            // lblFastIdValue
            // 
            lblFastIdValue.AutoSize = true;
            lblFastIdValue.Location = new Point(160, 50);
            lblFastIdValue.Name = "lblFastIdValue";
            lblFastIdValue.Size = new Size(68, 20);
            lblFastIdValue.TabIndex = 3;
            lblFastIdValue.Text = "22K-1234";
            
            // lblDegree
            // 
            lblDegree.AutoSize = true;
            lblDegree.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDegree.Location = new Point(20, 80);
            lblDegree.Name = "lblDegree";
            lblDegree.Size = new Size(63, 20);
            lblDegree.TabIndex = 4;
            lblDegree.Text = "Degree:";
            
            // lblDegreeValue
            // 
            lblDegreeValue.AutoSize = true;
            lblDegreeValue.Location = new Point(160, 80);
            lblDegreeValue.Name = "lblDegreeValue";
            lblDegreeValue.Size = new Size(27, 20);
            lblDegreeValue.TabIndex = 5;
            lblDegreeValue.Text = "CS";
            
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSemester.Location = new Point(20, 110);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(80, 20);
            lblSemester.TabIndex = 6;
            lblSemester.Text = "Semester:";
            
            // lblSemesterValue
            // 
            lblSemesterValue.AutoSize = true;
            lblSemesterValue.Location = new Point(160, 110);
            lblSemesterValue.Name = "lblSemesterValue";
            lblSemesterValue.Size = new Size(17, 20);
            lblSemesterValue.TabIndex = 7;
            lblSemesterValue.Text = "5";
            
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGPA.Location = new Point(350, 20);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(42, 20);
            lblGPA.TabIndex = 8;
            lblGPA.Text = "GPA:";
            
            // lblGPAValue
            // 
            lblGPAValue.AutoSize = true;
            lblGPAValue.Location = new Point(450, 20);
            lblGPAValue.Name = "lblGPAValue";
            lblGPAValue.Size = new Size(29, 20);
            lblGPAValue.TabIndex = 9;
            lblGPAValue.Text = "3.8";
            
            // tabControl1
            // 
            tabControl1.Controls.Add(tabSkills);
            tabControl1.Controls.Add(tabCertifications);
            tabControl1.Controls.Add(tabEducation);
            tabControl1.Controls.Add(tabExperience);
            tabControl1.Location = new Point(30, 240);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(640, 300);
            tabControl1.TabIndex = 2;
            
            // tabSkills
            // 
            tabSkills.Controls.Add(lstSkills);
            tabSkills.Location = new Point(4, 29);
            tabSkills.Name = "tabSkills";
            tabSkills.Padding = new Padding(3);
            tabSkills.Size = new Size(632, 267);
            tabSkills.TabIndex = 0;
            tabSkills.Text = "Skills";
            tabSkills.UseVisualStyleBackColor = true;
            
            // lstSkills
            // 
            lstSkills.FormattingEnabled = true;
            lstSkills.ItemHeight = 20;
            lstSkills.Location = new Point(20, 20);
            lstSkills.Name = "lstSkills";
            lstSkills.Size = new Size(592, 224);
            lstSkills.TabIndex = 0;
            
            // tabCertifications
            // 
            tabCertifications.Controls.Add(lstCertifications);
            tabCertifications.Location = new Point(4, 29);
            tabCertifications.Name = "tabCertifications";
            tabCertifications.Padding = new Padding(3);
            tabCertifications.Size = new Size(632, 267);
            tabCertifications.TabIndex = 1;
            tabCertifications.Text = "Certifications";
            tabCertifications.UseVisualStyleBackColor = true;
            
            // lstCertifications
            // 
            lstCertifications.FormattingEnabled = true;
            lstCertifications.ItemHeight = 20;
            lstCertifications.Location = new Point(20, 20);
            lstCertifications.Name = "lstCertifications";
            lstCertifications.Size = new Size(592, 224);
            lstCertifications.TabIndex = 0;
            
            // tabEducation
            // 
            tabEducation.Controls.Add(txtEducation);
            tabEducation.Location = new Point(4, 29);
            tabEducation.Name = "tabEducation";
            tabEducation.Size = new Size(632, 267);
            tabEducation.TabIndex = 2;
            tabEducation.Text = "Education";
            tabEducation.UseVisualStyleBackColor = true;
            
            // txtEducation
            // 
            txtEducation.BackColor = SystemColors.Window;
            txtEducation.Location = new Point(20, 20);
            txtEducation.Multiline = true;
            txtEducation.Name = "txtEducation";
            txtEducation.ReadOnly = true;
            txtEducation.Size = new Size(592, 224);
            txtEducation.TabIndex = 0;
            
            // tabExperience
            // 
            tabExperience.Controls.Add(txtExperience);
            tabExperience.Location = new Point(4, 29);
            tabExperience.Name = "tabExperience";
            tabExperience.Size = new Size(632, 267);
            tabExperience.TabIndex = 3;
            tabExperience.Text = "Experience";
            tabExperience.UseVisualStyleBackColor = true;
            
            // txtExperience
            // 
            txtExperience.BackColor = SystemColors.Window;
            txtExperience.Location = new Point(20, 20);
            txtExperience.Multiline = true;
            txtExperience.Name = "txtExperience";
            txtExperience.ReadOnly = true;
            txtExperience.Size = new Size(592, 224);
            txtExperience.TabIndex = 0;
            
            // btnClose
            // 
            btnClose.Location = new Point(570, 560);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            
            // ApplicantProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(700, 620);
            Controls.Add(btnClose);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "ApplicantProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Applicant Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabSkills.ResumeLayout(false);
            tabCertifications.ResumeLayout(false);
            tabEducation.ResumeLayout(false);
            tabEducation.PerformLayout();
            tabExperience.ResumeLayout(false);
            tabExperience.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Label lblGPAValue;
        private Label lblGPA;
        private Label lblSemesterValue;
        private Label lblSemester;
        private Label lblDegreeValue;
        private Label lblDegree;
        private Label lblFastIdValue;
        private Label lblFastId;
        private Label lblNameValue;
        private Label lblName;
        private TabControl tabControl1;
        private TabPage tabSkills;
        private ListBox lstSkills;
        private TabPage tabCertifications;
        private ListBox lstCertifications;
        private TabPage tabEducation;
        private TextBox txtEducation;
        private TabPage tabExperience;
        private TextBox txtExperience;
        private Button btnClose;
    }
} 