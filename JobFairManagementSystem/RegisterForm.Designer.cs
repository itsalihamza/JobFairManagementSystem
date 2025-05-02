namespace JobFairManagementSystem
{
    partial class RegisterForm
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
            lblName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblRole = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            cmbRole = new ComboBox();
            btnRegister = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            pnlContent = new Panel();
            lblInstruction = new Label();
            pnlSideBar = new Panel();
            lblSteps = new Label();
            lblRegisterText = new Label();
            picRegister = new PictureBox();
            pnlContent.SuspendLayout();
            pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRegister).BeginInit();
            SuspendLayout();
            
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(20, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(207, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "REGISTER";
            
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(lblInstruction);
            pnlContent.Controls.Add(btnCancel);
            pnlContent.Controls.Add(btnRegister);
            pnlContent.Controls.Add(cmbRole);
            pnlContent.Controls.Add(txtConfirmPassword);
            pnlContent.Controls.Add(txtPassword);
            pnlContent.Controls.Add(txtEmail);
            pnlContent.Controls.Add(txtName);
            pnlContent.Controls.Add(lblRole);
            pnlContent.Controls.Add(lblConfirmPassword);
            pnlContent.Controls.Add(lblPassword);
            pnlContent.Controls.Add(lblEmail);
            pnlContent.Controls.Add(lblName);
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Dock = DockStyle.Right;
            pnlContent.Location = new Point(330, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(550, 600);
            pnlContent.TabIndex = 0;
            
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(20, 120);
            lblName.Name = "lblName";
            lblName.Size = new Size(93, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Full Name:";
            
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(20, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(20, 260);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmPassword.Location = new Point(20, 330);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(156, 23);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Confirm Password:";
            
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.Location = new Point(20, 400);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(47, 23);
            lblRole.TabIndex = 5;
            lblRole.Text = "Role:";
            
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(20, 150);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter your full name";
            txtName.Size = new Size(450, 30);
            txtName.TabIndex = 0;
            
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(20, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email address";
            txtEmail.Size = new Size(450, 30);
            txtEmail.TabIndex = 1;
            
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(20, 290);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(450, 30);
            txtPassword.TabIndex = 2;
            
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPassword.Location = new Point(20, 360);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.PlaceholderText = "Confirm your password";
            txtConfirmPassword.Size = new Size(450, 30);
            txtConfirmPassword.TabIndex = 3;
            
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Student", "Recruiter", "TPO", "Coordinator" });
            cmbRole.Location = new Point(20, 430);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(450, 31);
            cmbRole.TabIndex = 4;
            
            // btnRegister
            // 
            btnRegister.BackColor = Color.ForestGreen;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(20, 490);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(210, 40);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderColor = Color.DarkGray;
            btnCancel.FlatAppearance.BorderSize = 1;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.DimGray;
            btnCancel.Location = new Point(260, 490);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(210, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            
            // lblInstruction
            // 
            lblInstruction.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblInstruction.ForeColor = Color.DimGray;
            lblInstruction.Location = new Point(20, 80);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(450, 30);
            lblInstruction.TabIndex = 7;
            lblInstruction.Text = "Please fill in the form below to create your account.";
            
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(76, 175, 80);
            pnlSideBar.Controls.Add(lblSteps);
            pnlSideBar.Controls.Add(lblRegisterText);
            pnlSideBar.Controls.Add(picRegister);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(330, 600);
            pnlSideBar.TabIndex = 1;
            
            // picRegister
            // 
            picRegister.Location = new Point(85, 80);
            picRegister.Name = "picRegister";
            picRegister.Size = new Size(150, 150);
            picRegister.SizeMode = PictureBoxSizeMode.Zoom;
            picRegister.TabIndex = 0;
            picRegister.TabStop = false;
            
            // lblRegisterText
            // 
            lblRegisterText.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegisterText.ForeColor = Color.White;
            lblRegisterText.Location = new Point(30, 250);
            lblRegisterText.Name = "lblRegisterText";
            lblRegisterText.Size = new Size(270, 35);
            lblRegisterText.TabIndex = 1;
            lblRegisterText.Text = "JOIN CAREER CONNECT";
            lblRegisterText.TextAlign = ContentAlignment.MiddleCenter;
            
            // lblSteps
            // 
            lblSteps.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSteps.ForeColor = Color.White;
            lblSteps.Location = new Point(30, 300);
            lblSteps.Name = "lblSteps";
            lblSteps.Size = new Size(270, 200);
            lblSteps.TabIndex = 2;
            lblSteps.Text = "1. Create your account\r\n\r\n2. Complete your profile\r\n\r\n3. Start browsing job fairs and opportunities\r\n\r\n4. Network with recruiters and companies";
            
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(880, 600);
            Controls.Add(pnlSideBar);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Register";
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picRegister).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblRole;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private ComboBox cmbRole;
        private Button btnRegister;
        private Button btnCancel;
        private Label lblTitle;
        private Panel pnlContent;
        private Label lblInstruction;
        private Panel pnlSideBar;
        private Label lblSteps;
        private Label lblRegisterText;
        private PictureBox picRegister;
    }
} 