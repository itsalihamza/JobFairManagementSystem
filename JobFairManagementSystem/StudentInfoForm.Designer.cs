namespace JobFairManagementSystem
{
    partial class StudentInfoForm
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
            btnCancel = new Button();
            btnSave = new Button();
            txtGPA = new TextBox();
            lblGPA = new Label();
            cmbSemester = new ComboBox();
            lblSemester = new Label();
            cmbDegree = new ComboBox();
            lblDegree = new Label();
            txtFastId = new TextBox();
            lblFastId = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(200, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "STUDENT INFORMATION";
            
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtGPA);
            panel1.Controls.Add(lblGPA);
            panel1.Controls.Add(cmbSemester);
            panel1.Controls.Add(lblSemester);
            panel1.Controls.Add(cmbDegree);
            panel1.Controls.Add(lblDegree);
            panel1.Controls.Add(txtFastId);
            panel1.Controls.Add(lblFastId);
            panel1.Location = new Point(150, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 350);
            panel1.TabIndex = 1;
            
            // lblFastId
            // 
            lblFastId.AutoSize = true;
            lblFastId.Location = new Point(50, 40);
            lblFastId.Name = "lblFastId";
            lblFastId.Size = new Size(62, 20);
            lblFastId.TabIndex = 0;
            lblFastId.Text = "FAST ID:";
            
            // txtFastId
            // 
            txtFastId.Location = new Point(200, 40);
            txtFastId.Name = "txtFastId";
            txtFastId.Size = new Size(250, 27);
            txtFastId.TabIndex = 0;
            txtFastId.PlaceholderText = "e.g., 22K-1234";
            
            // lblDegree
            // 
            lblDegree.AutoSize = true;
            lblDegree.Location = new Point(50, 90);
            lblDegree.Name = "lblDegree";
            lblDegree.Size = new Size(124, 20);
            lblDegree.TabIndex = 2;
            lblDegree.Text = "Degree Program:";
            
            // cmbDegree
            // 
            cmbDegree.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDegree.FormattingEnabled = true;
            cmbDegree.Items.AddRange(new object[] { "CS", "SE", "AI", "DS" });
            cmbDegree.Location = new Point(200, 90);
            cmbDegree.Name = "cmbDegree";
            cmbDegree.Size = new Size(250, 28);
            cmbDegree.TabIndex = 1;
            
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Location = new Point(50, 140);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(130, 20);
            lblSemester.TabIndex = 4;
            lblSemester.Text = "Current Semester:";
            
            // cmbSemester
            // 
            cmbSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemester.FormattingEnabled = true;
            cmbSemester.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbSemester.Location = new Point(200, 140);
            cmbSemester.Name = "cmbSemester";
            cmbSemester.Size = new Size(250, 28);
            cmbSemester.TabIndex = 2;
            
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Location = new Point(50, 190);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(40, 20);
            lblGPA.TabIndex = 6;
            lblGPA.Text = "GPA:";
            
            // txtGPA
            // 
            txtGPA.Location = new Point(200, 190);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(250, 27);
            txtGPA.TabIndex = 3;
            txtGPA.PlaceholderText = "Enter GPA (0.0 - 4.0)";
            
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(200, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            
            // btnCancel
            // 
            btnCancel.Location = new Point(330, 250);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            
            // StudentInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 500);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "StudentInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Student Information";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtGPA;
        private Label lblGPA;
        private ComboBox cmbSemester;
        private Label lblSemester;
        private ComboBox cmbDegree;
        private Label lblDegree;
        private TextBox txtFastId;
        private Label lblFastId;
    }
} 