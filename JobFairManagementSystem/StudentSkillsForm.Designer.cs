namespace JobFairManagementSystem
{
    partial class StudentSkillsForm
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
            tabSkillsCerts = new TabControl();
            tabSkills = new TabPage();
            btnRemoveSkill = new Button();
            btnAddSkill = new Button();
            lstSkills = new ListBox();
            txtSkill = new TextBox();
            lblSkill = new Label();
            tabCertifications = new TabPage();
            btnRemoveCert = new Button();
            btnAddCert = new Button();
            lstCertifications = new ListBox();
            dtpCertDate = new DateTimePicker();
            lblCertDate = new Label();
            txtCertIssuer = new TextBox();
            lblCertIssuer = new Label();
            txtCertTitle = new TextBox();
            lblCertTitle = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            tabSkillsCerts.SuspendLayout();
            tabSkills.SuspendLayout();
            tabCertifications.SuspendLayout();
            SuspendLayout();
            
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(260, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(328, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SKILLS & CERTIFICATIONS";
            
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(tabSkillsCerts);
            panel1.Location = new Point(50, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 500);
            panel1.TabIndex = 1;
            
            // tabSkillsCerts
            // 
            tabSkillsCerts.Controls.Add(tabSkills);
            tabSkillsCerts.Controls.Add(tabCertifications);
            tabSkillsCerts.Location = new Point(20, 20);
            tabSkillsCerts.Name = "tabSkillsCerts";
            tabSkillsCerts.SelectedIndex = 0;
            tabSkillsCerts.Size = new Size(660, 400);
            tabSkillsCerts.TabIndex = 0;
            
            // tabSkills
            // 
            tabSkills.BackColor = SystemColors.Control;
            tabSkills.Controls.Add(btnRemoveSkill);
            tabSkills.Controls.Add(btnAddSkill);
            tabSkills.Controls.Add(lstSkills);
            tabSkills.Controls.Add(txtSkill);
            tabSkills.Controls.Add(lblSkill);
            tabSkills.Location = new Point(4, 29);
            tabSkills.Name = "tabSkills";
            tabSkills.Padding = new Padding(3);
            tabSkills.Size = new Size(652, 367);
            tabSkills.TabIndex = 0;
            tabSkills.Text = "Skills";
            
            // lblSkill
            // 
            lblSkill.AutoSize = true;
            lblSkill.Location = new Point(20, 20);
            lblSkill.Name = "lblSkill";
            lblSkill.Size = new Size(38, 20);
            lblSkill.TabIndex = 0;
            lblSkill.Text = "Skill:";
            
            // txtSkill
            // 
            txtSkill.Location = new Point(20, 50);
            txtSkill.Name = "txtSkill";
            txtSkill.Size = new Size(450, 27);
            txtSkill.TabIndex = 0;
            txtSkill.PlaceholderText = "Enter a skill (e.g., Java Programming, Web Development)";
            
            // lstSkills
            // 
            lstSkills.FormattingEnabled = true;
            lstSkills.ItemHeight = 20;
            lstSkills.Location = new Point(20, 100);
            lstSkills.Name = "lstSkills";
            lstSkills.Size = new Size(450, 244);
            lstSkills.TabIndex = 2;
            
            // btnAddSkill
            // 
            btnAddSkill.BackColor = Color.ForestGreen;
            btnAddSkill.ForeColor = Color.White;
            btnAddSkill.Location = new Point(490, 50);
            btnAddSkill.Name = "btnAddSkill";
            btnAddSkill.Size = new Size(100, 30);
            btnAddSkill.TabIndex = 1;
            btnAddSkill.Text = "Add";
            btnAddSkill.UseVisualStyleBackColor = false;
            btnAddSkill.Click += btnAddSkill_Click;
            
            // btnRemoveSkill
            // 
            btnRemoveSkill.BackColor = Color.Firebrick;
            btnRemoveSkill.ForeColor = Color.White;
            btnRemoveSkill.Location = new Point(490, 100);
            btnRemoveSkill.Name = "btnRemoveSkill";
            btnRemoveSkill.Size = new Size(100, 30);
            btnRemoveSkill.TabIndex = 3;
            btnRemoveSkill.Text = "Remove";
            btnRemoveSkill.UseVisualStyleBackColor = false;
            btnRemoveSkill.Click += btnRemoveSkill_Click;
            
            // tabCertifications
            // 
            tabCertifications.BackColor = SystemColors.Control;
            tabCertifications.Controls.Add(btnRemoveCert);
            tabCertifications.Controls.Add(btnAddCert);
            tabCertifications.Controls.Add(lstCertifications);
            tabCertifications.Controls.Add(dtpCertDate);
            tabCertifications.Controls.Add(lblCertDate);
            tabCertifications.Controls.Add(txtCertIssuer);
            tabCertifications.Controls.Add(lblCertIssuer);
            tabCertifications.Controls.Add(txtCertTitle);
            tabCertifications.Controls.Add(lblCertTitle);
            tabCertifications.Location = new Point(4, 29);
            tabCertifications.Name = "tabCertifications";
            tabCertifications.Padding = new Padding(3);
            tabCertifications.Size = new Size(652, 367);
            tabCertifications.TabIndex = 1;
            tabCertifications.Text = "Certifications";
            
            // lblCertTitle
            // 
            lblCertTitle.AutoSize = true;
            lblCertTitle.Location = new Point(20, 20);
            lblCertTitle.Name = "lblCertTitle";
            lblCertTitle.Size = new Size(41, 20);
            lblCertTitle.TabIndex = 0;
            lblCertTitle.Text = "Title:";
            
            // txtCertTitle
            // 
            txtCertTitle.Location = new Point(100, 20);
            txtCertTitle.Name = "txtCertTitle";
            txtCertTitle.Size = new Size(370, 27);
            txtCertTitle.TabIndex = 0;
            txtCertTitle.PlaceholderText = "Enter certification title";
            
            // lblCertIssuer
            // 
            lblCertIssuer.AutoSize = true;
            lblCertIssuer.Location = new Point(20, 60);
            lblCertIssuer.Name = "lblCertIssuer";
            lblCertIssuer.Size = new Size(51, 20);
            lblCertIssuer.TabIndex = 2;
            lblCertIssuer.Text = "Issuer:";
            
            // txtCertIssuer
            // 
            txtCertIssuer.Location = new Point(100, 60);
            txtCertIssuer.Name = "txtCertIssuer";
            txtCertIssuer.Size = new Size(370, 27);
            txtCertIssuer.TabIndex = 1;
            txtCertIssuer.PlaceholderText = "Organization that issued the certification";
            
            // lblCertDate
            // 
            lblCertDate.AutoSize = true;
            lblCertDate.Location = new Point(20, 100);
            lblCertDate.Name = "lblCertDate";
            lblCertDate.Size = new Size(78, 20);
            lblCertDate.TabIndex = 4;
            lblCertDate.Text = "Issue Date:";
            
            // dtpCertDate
            // 
            dtpCertDate.Format = DateTimePickerFormat.Short;
            dtpCertDate.Location = new Point(100, 100);
            dtpCertDate.Name = "dtpCertDate";
            dtpCertDate.Size = new Size(200, 27);
            dtpCertDate.TabIndex = 2;
            
            // lstCertifications
            // 
            lstCertifications.FormattingEnabled = true;
            lstCertifications.ItemHeight = 20;
            lstCertifications.Location = new Point(20, 150);
            lstCertifications.Name = "lstCertifications";
            lstCertifications.Size = new Size(520, 184);
            lstCertifications.TabIndex = 5;
            
            // btnAddCert
            // 
            btnAddCert.BackColor = Color.ForestGreen;
            btnAddCert.ForeColor = Color.White;
            btnAddCert.Location = new Point(490, 20);
            btnAddCert.Name = "btnAddCert";
            btnAddCert.Size = new Size(100, 30);
            btnAddCert.TabIndex = 3;
            btnAddCert.Text = "Add";
            btnAddCert.UseVisualStyleBackColor = false;
            btnAddCert.Click += btnAddCert_Click;
            
            // btnRemoveCert
            // 
            btnRemoveCert.BackColor = Color.Firebrick;
            btnRemoveCert.ForeColor = Color.White;
            btnRemoveCert.Location = new Point(490, 60);
            btnRemoveCert.Name = "btnRemoveCert";
            btnRemoveCert.Size = new Size(100, 30);
            btnRemoveCert.TabIndex = 4;
            btnRemoveCert.Text = "Remove";
            btnRemoveCert.UseVisualStyleBackColor = false;
            
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(470, 440);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(580, 440);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            
            // StudentSkillsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 650);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "StudentSkillsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Skills & Certifications";
            panel1.ResumeLayout(false);
            tabSkillsCerts.ResumeLayout(false);
            tabSkills.ResumeLayout(false);
            tabSkills.PerformLayout();
            tabCertifications.ResumeLayout(false);
            tabCertifications.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private TabControl tabSkillsCerts;
        private TabPage tabSkills;
        private Button btnRemoveSkill;
        private Button btnAddSkill;
        private ListBox lstSkills;
        private TextBox txtSkill;
        private Label lblSkill;
        private TabPage tabCertifications;
        private Button btnRemoveCert;
        private Button btnAddCert;
        private ListBox lstCertifications;
        private DateTimePicker dtpCertDate;
        private Label lblCertDate;
        private TextBox txtCertIssuer;
        private Label lblCertIssuer;
        private TextBox txtCertTitle;
        private Label lblCertTitle;
        private Button btnCancel;
        private Button btnSave;
    }
} 