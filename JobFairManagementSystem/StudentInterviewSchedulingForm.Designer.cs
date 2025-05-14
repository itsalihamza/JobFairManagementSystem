namespace JobFairManagementSystem
{
    partial class StudentInterviewSchedulingForm
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
            lblCompanyLabel = new Label();
            lblCompany = new Label();
            lblJobTitleLabel = new Label();
            lblJobTitle = new Label();
            lblInstructions = new Label();
            dgvTimeSlots = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            StartTime = new DataGridViewTextBoxColumn();
            EndTime = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnSchedule = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTimeSlots).BeginInit();
            SuspendLayout();
            
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(169, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Schedule Interview";
            
            // lblCompanyLabel
            // 
            lblCompanyLabel.AutoSize = true;
            lblCompanyLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompanyLabel.Location = new Point(20, 60);
            lblCompanyLabel.Name = "lblCompanyLabel";
            lblCompanyLabel.Size = new Size(80, 20);
            lblCompanyLabel.TabIndex = 1;
            lblCompanyLabel.Text = "Company:";
            
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(110, 60);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(120, 20);
            lblCompany.TabIndex = 2;
            lblCompany.Text = "[Company Name]";
            
            // lblJobTitleLabel
            // 
            lblJobTitleLabel.AutoSize = true;
            lblJobTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblJobTitleLabel.Location = new Point(20, 90);
            lblJobTitleLabel.Name = "lblJobTitleLabel";
            lblJobTitleLabel.Size = new Size(73, 20);
            lblJobTitleLabel.TabIndex = 3;
            lblJobTitleLabel.Text = "Job Title:";
            
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Location = new Point(110, 90);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(85, 20);
            lblJobTitle.TabIndex = 4;
            lblJobTitle.Text = "[Job Title]";
            
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(20, 130);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(340, 20);
            lblInstructions.TabIndex = 5;
            lblInstructions.Text = "Select an available time slot for your interview:";
            
            // dgvTimeSlots
            // 
            dgvTimeSlots.AllowUserToAddRows = false;
            dgvTimeSlots.AllowUserToDeleteRows = false;
            dgvTimeSlots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTimeSlots.Columns.AddRange(new DataGridViewColumn[] { Date, StartTime, EndTime, Status });
            dgvTimeSlots.Location = new Point(20, 160);
            dgvTimeSlots.MultiSelect = false;
            dgvTimeSlots.Name = "dgvTimeSlots";
            dgvTimeSlots.ReadOnly = true;
            dgvTimeSlots.RowHeadersWidth = 51;
            dgvTimeSlots.RowTemplate.Height = 29;
            dgvTimeSlots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTimeSlots.Size = new Size(560, 280);
            dgvTimeSlots.TabIndex = 6;
            
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 120;
            
            // StartTime
            // 
            StartTime.HeaderText = "Start Time";
            StartTime.MinimumWidth = 6;
            StartTime.Name = "StartTime";
            StartTime.ReadOnly = true;
            StartTime.Width = 120;
            
            // EndTime
            // 
            EndTime.HeaderText = "End Time";
            EndTime.MinimumWidth = 6;
            EndTime.Name = "EndTime";
            EndTime.ReadOnly = true;
            EndTime.Width = 120;
            
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 120;
            
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.ForestGreen;
            btnSchedule.ForeColor = Color.White;
            btnSchedule.Location = new Point(455, 455);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(125, 35);
            btnSchedule.TabIndex = 7;
            btnSchedule.Text = "Schedule";
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            
            // btnCancel
            // 
            btnCancel.Location = new Point(325, 455);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 35);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            
            // StudentInterviewSchedulingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 510);
            Controls.Add(btnCancel);
            Controls.Add(btnSchedule);
            Controls.Add(dgvTimeSlots);
            Controls.Add(lblInstructions);
            Controls.Add(lblJobTitle);
            Controls.Add(lblJobTitleLabel);
            Controls.Add(lblCompany);
            Controls.Add(lblCompanyLabel);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentInterviewSchedulingForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Schedule Interview";
            ((System.ComponentModel.ISupportInitialize)dgvTimeSlots).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCompanyLabel;
        private Label lblCompany;
        private Label lblJobTitleLabel;
        private Label lblJobTitle;
        private Label lblInstructions;
        private DataGridView dgvTimeSlots;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn EndTime;
        private DataGridViewTextBoxColumn Status;
        private Button btnSchedule;
        private Button btnCancel;
    }
} 