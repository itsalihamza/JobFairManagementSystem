namespace JobFairManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lnkRegister = new LinkLabel();
            lblTitle = new Label();
            cmbRole = new ComboBox();
            lblRole = new Label();
            panel1 = new Panel();
            lnkForgotPassword = new LinkLabel();
            lblWelcomeText = new Label();
            pnlSideBar = new Panel();
            lblCompanyTagline = new Label();
            lblCompanyName = new Label();
            picLogo = new PictureBox();
            panel1.SuspendLayout();
            pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(20, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(260, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CAREER CONNECT";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.None;
            panel1.Controls.Add(lnkForgotPassword);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(lnkRegister);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblWelcomeText);
            panel1.Location = new Point(320, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 550);
            panel1.TabIndex = 1;
            
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(20, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(20, 220);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 23);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(20, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email address";
            txtEmail.Size = new Size(350, 30);
            txtEmail.TabIndex = 0;
            
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(20, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(350, 30);
            txtPassword.TabIndex = 1;
            
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.Location = new Point(20, 290);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(47, 23);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role:";
            
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Student", "Recruiter", "TPO", "Coordinator" });
            cmbRole.Location = new Point(20, 320);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(350, 31);
            cmbRole.TabIndex = 2;
            
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(20, 380);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(350, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lnkRegister.Location = new Point(119, 450);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(183, 23);
            lnkRegister.TabIndex = 4;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Register a new account";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            
            // lnkForgotPassword
            // 
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lnkForgotPassword.Location = new Point(250, 290);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(124, 20);
            lnkForgotPassword.TabIndex = 5;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Password?";
            lnkForgotPassword.LinkClicked += lnkForgotPassword_LinkClicked;
            
            // lblWelcomeText
            // 
            lblWelcomeText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcomeText.ForeColor = Color.DimGray;
            lblWelcomeText.Location = new Point(20, 80);
            lblWelcomeText.Name = "lblWelcomeText";
            lblWelcomeText.Size = new Size(350, 50);
            lblWelcomeText.TabIndex = 6;
            lblWelcomeText.Text = "Welcome to CareerConnect. Please login to access your account.";
            
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(25, 118, 210);
            pnlSideBar.Controls.Add(lblCompanyTagline);
            pnlSideBar.Controls.Add(lblCompanyName);
            pnlSideBar.Controls.Add(picLogo);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(320, 550);
            pnlSideBar.TabIndex = 2;
            
            // picLogo
            // 
            picLogo.Location = new Point(85, 100);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(150, 150);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            
            // lblCompanyName
            // 
            lblCompanyName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompanyName.ForeColor = Color.White;
            lblCompanyName.Location = new Point(25, 280);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(270, 40);
            lblCompanyName.TabIndex = 1;
            lblCompanyName.Text = "CAREER CONNECT";
            lblCompanyName.TextAlign = ContentAlignment.MiddleCenter;
            
            // lblCompanyTagline
            // 
            lblCompanyTagline.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompanyTagline.ForeColor = Color.White;
            lblCompanyTagline.Location = new Point(25, 330);
            lblCompanyTagline.Name = "lblCompanyTagline";
            lblCompanyTagline.Size = new Size(270, 100);
            lblCompanyTagline.TabIndex = 2;
            lblCompanyTagline.Text = "Connecting Students with Job Opportunities";
            lblCompanyTagline.TextAlign = ContentAlignment.TopCenter;
            
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 550);
            Controls.Add(pnlSideBar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel lnkRegister;
        private Label lblTitle;
        private ComboBox cmbRole;
        private Label lblRole;
        private Panel panel1;
        private LinkLabel lnkForgotPassword;
        private Label lblWelcomeText;
        private Panel pnlSideBar;
        private Label lblCompanyTagline;
        private Label lblCompanyName;
        private PictureBox picLogo;
    }
}