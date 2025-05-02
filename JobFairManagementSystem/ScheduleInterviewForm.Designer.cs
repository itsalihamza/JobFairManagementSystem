namespace JobFairManagementSystem
{
    partial class ScheduleInterviewForm
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
            lblJobTitleValue = new Label();
            lblJobTitle = new Label();
            lblStudentNameValue = new Label();
            lblStudentName = new Label();
            lblInterviewDate = new Label();
            dtpInterviewDate = new DateTimePicker();
            lblInterviewTime = new Label();
            dtpInterviewTime = new DateTimePicker();
            lblInterviewType = new Label();
            cmbInterviewType = new ComboBox();
            lblDuration = new Label();
            cmbDuration = new ComboBox();
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            btnSchedule = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(165, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(290, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SCHEDULE INTERVIEW";
            
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblJobTitleValue);
            panel1.Controls.Add(lblJobTitle);
            panel1.Controls.Add(lblStudentNameValue);
            panel1.Controls.Add(lblStudentName);
            panel1.Location = new Point(30, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 90);
            panel1.TabIndex = 1;
            
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudentName.Location = new Point(20, 20);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(113, 20);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Student Name:";
            
            // lblStudentNameValue
            // 
            lblStudentNameValue.AutoSize = true;
            lblStudentNameValue.Location = new Point(150, 20);
            lblStudentNameValue.Name = "lblStudentNameValue";
            lblStudentNameValue.Size = new Size(76, 20);
            lblStudentNameValue.TabIndex = 1;
            lblStudentNameValue.Text = "John Doe";
            
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblJobTitle.Location = new Point(20, 50);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(73, 20);
            lblJobTitle.TabIndex = 2;
            lblJobTitle.Text = "Job Title:";
            
            // lblJobTitleValue
            // 
            lblJobTitleValue.AutoSize = true;
            lblJobTitleValue.Location = new Point(150, 50);
            lblJobTitleValue.Name = "lblJobTitleValue";
            lblJobTitleValue.Size = new Size(133, 20);
            lblJobTitleValue.TabIndex = 3;
            lblJobTitleValue.Text = "Software Engineer";
            
            // lblInterviewDate
            // 
            lblInterviewDate.AutoSize = true;
            lblInterviewDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInterviewDate.Location = new Point(30, 180);
            lblInterviewDate.Name = "lblInterviewDate";
            lblInterviewDate.Size = new Size(45, 20);
            lblInterviewDate.TabIndex = 2;
            lblInterviewDate.Text = "Date:";
            
            // dtpInterviewDate
            // 
            dtpInterviewDate.Format = DateTimePickerFormat.Short;
            dtpInterviewDate.Location = new Point(170, 180);
            dtpInterviewDate.Name = "dtpInterviewDate";
            dtpInterviewDate.Size = new Size(150, 27);
            dtpInterviewDate.TabIndex = 0;
            
            // lblInterviewTime
            // 
            lblInterviewTime.AutoSize = true;
            lblInterviewTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInterviewTime.Location = new Point(340, 180);
            lblInterviewTime.Name = "lblInterviewTime";
            lblInterviewTime.Size = new Size(47, 20);
            lblInterviewTime.TabIndex = 4;
            lblInterviewTime.Text = "Time:";
            
            // dtpInterviewTime
            // 
            dtpInterviewTime.Format = DateTimePickerFormat.Time;
            dtpInterviewTime.Location = new Point(420, 180);
            dtpInterviewTime.Name = "dtpInterviewTime";
            dtpInterviewTime.ShowUpDown = true;
            dtpInterviewTime.Size = new Size(150, 27);
            dtpInterviewTime.TabIndex = 1;
            
            // lblInterviewType
            // 
            lblInterviewType.AutoSize = true;
            lblInterviewType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInterviewType.Location = new Point(30, 230);
            lblInterviewType.Name = "lblInterviewType";
            lblInterviewType.Size = new Size(118, 20);
            lblInterviewType.TabIndex = 6;
            lblInterviewType.Text = "Interview Type:";
            
            // cmbInterviewType
            // 
            cmbInterviewType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInterviewType.FormattingEnabled = true;
            cmbInterviewType.Items.AddRange(new object[] { "Online", "In-person", "Phone" });
            cmbInterviewType.Location = new Point(170, 230);
            cmbInterviewType.Name = "cmbInterviewType";
            cmbInterviewType.Size = new Size(150, 28);
            cmbInterviewType.TabIndex = 2;
            cmbInterviewType.SelectedIndexChanged += cmbInterviewType_SelectedIndexChanged;
            
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDuration.Location = new Point(340, 230);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(76, 20);
            lblDuration.TabIndex = 8;
            lblDuration.Text = "Duration:";
            
            // cmbDuration
            // 
            cmbDuration.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDuration.FormattingEnabled = true;
            cmbDuration.Items.AddRange(new object[] { "15 minutes", "30 minutes", "45 minutes", "1 hour", "1.5 hours", "2 hours" });
            cmbDuration.Location = new Point(420, 230);
            cmbDuration.Name = "cmbDuration";
            cmbDuration.Size = new Size(150, 28);
            cmbDuration.TabIndex = 3;
            
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLocation.Location = new Point(30, 280);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(104, 20);
            lblLocation.TabIndex = 10;
            lblLocation.Text = "Meeting Link:";
            
            // txtLocation
            // 
            txtLocation.Location = new Point(170, 280);
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "Enter video conference link";
            txtLocation.Size = new Size(400, 27);
            txtLocation.TabIndex = 4;
            txtLocation.Text = "https://";
            
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotes.Location = new Point(30, 330);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(54, 20);
            lblNotes.TabIndex = 12;
            lblNotes.Text = "Notes:";
            
            // txtNotes
            // 
            txtNotes.Location = new Point(170, 330);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderText = "Enter any additional notes or instructions for the interview...";
            txtNotes.Size = new Size(400, 100);
            txtNotes.TabIndex = 5;
            
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.RoyalBlue;
            btnSchedule.ForeColor = Color.White;
            btnSchedule.Location = new Point(345, 450);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(120, 40);
            btnSchedule.TabIndex = 6;
            btnSchedule.Text = "Schedule";
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            
            // btnCancel
            // 
            btnCancel.Location = new Point(480, 450);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            
            // ScheduleInterviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(600, 520);
            Controls.Add(btnCancel);
            Controls.Add(btnSchedule);
            Controls.Add(txtNotes);
            Controls.Add(lblNotes);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(cmbDuration);
            Controls.Add(lblDuration);
            Controls.Add(cmbInterviewType);
            Controls.Add(lblInterviewType);
            Controls.Add(dtpInterviewTime);
            Controls.Add(lblInterviewTime);
            Controls.Add(dtpInterviewDate);
            Controls.Add(lblInterviewDate);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "ScheduleInterviewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Schedule Interview";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Label lblJobTitleValue;
        private Label lblJobTitle;
        private Label lblStudentNameValue;
        private Label lblStudentName;
        private Label lblInterviewDate;
        private DateTimePicker dtpInterviewDate;
        private Label lblInterviewTime;
        private DateTimePicker dtpInterviewTime;
        private Label lblInterviewType;
        private ComboBox cmbInterviewType;
        private Label lblDuration;
        private ComboBox cmbDuration;
        private Label lblLocation;
        private TextBox txtLocation;
        private Label lblNotes;
        private TextBox txtNotes;
        private Button btnSchedule;
        private Button btnCancel;
    }
} 