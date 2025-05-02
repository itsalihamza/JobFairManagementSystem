namespace JobFairManagementSystem
{
    partial class LandingPage
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
            pnlHeader = new Panel();
            lblTagline = new Label();
            lblAppName = new Label();
            pnlContent = new Panel();
            pnlCarousel = new Panel();
            pnlIndicators = new FlowLayoutPanel();
            lblFeatureDescription = new Label();
            lblFeatureTitle = new Label();
            picFeature = new PictureBox();
            pnlActions = new Panel();
            btnRegister = new Button();
            btnLogin = new Button();
            lblWelcome = new Label();
            pnlFooter = new Panel();
            lnkContactUs = new LinkLabel();
            lnkAboutUs = new LinkLabel();
            lnkUpcomingFairs = new LinkLabel();
            lblCopyright = new Label();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlCarousel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFeature).BeginInit();
            pnlActions.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(25, 118, 210);
            pnlHeader.Controls.Add(lblTagline);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 100);
            pnlHeader.TabIndex = 0;
            
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(30, 25);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(350, 50);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "CAREER CONNECT";
            
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            lblTagline.ForeColor = Color.White;
            lblTagline.Location = new Point(390, 45);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(299, 23);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Connecting Students with Opportunities";
            
            // pnlContent
            // 
            pnlContent.Controls.Add(pnlCarousel);
            pnlContent.Controls.Add(pnlActions);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 100);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1000, 500);
            pnlContent.TabIndex = 1;
            
            // pnlCarousel
            // 
            pnlCarousel.BackColor = Color.White;
            pnlCarousel.Controls.Add(pnlIndicators);
            pnlCarousel.Controls.Add(lblFeatureDescription);
            pnlCarousel.Controls.Add(lblFeatureTitle);
            pnlCarousel.Controls.Add(picFeature);
            pnlCarousel.Dock = DockStyle.Fill;
            pnlCarousel.Location = new Point(0, 0);
            pnlCarousel.Name = "pnlCarousel";
            pnlCarousel.Size = new Size(1000, 400);
            pnlCarousel.TabIndex = 1;
            
            // picFeature
            // 
            picFeature.Anchor = AnchorStyles.None;
            picFeature.Location = new Point(200, 20);
            picFeature.Name = "picFeature";
            picFeature.Size = new Size(600, 300);
            picFeature.SizeMode = PictureBoxSizeMode.StretchImage;
            picFeature.TabIndex = 0;
            picFeature.TabStop = false;
            
            // lblFeatureTitle
            // 
            lblFeatureTitle.Anchor = AnchorStyles.None;
            lblFeatureTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFeatureTitle.Location = new Point(200, 330);
            lblFeatureTitle.Name = "lblFeatureTitle";
            lblFeatureTitle.Size = new Size(600, 40);
            lblFeatureTitle.TabIndex = 1;
            lblFeatureTitle.Text = "Feature Title";
            lblFeatureTitle.TextAlign = ContentAlignment.MiddleCenter;
            
            // lblFeatureDescription
            // 
            lblFeatureDescription.Anchor = AnchorStyles.None;
            lblFeatureDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFeatureDescription.ForeColor = Color.DimGray;
            lblFeatureDescription.Location = new Point(200, 370);
            lblFeatureDescription.Name = "lblFeatureDescription";
            lblFeatureDescription.Size = new Size(600, 50);
            lblFeatureDescription.TabIndex = 2;
            lblFeatureDescription.Text = "Feature description text";
            lblFeatureDescription.TextAlign = ContentAlignment.TopCenter;
            
            // pnlIndicators
            // 
            pnlIndicators.Anchor = AnchorStyles.None;
            pnlIndicators.AutoSize = true;
            pnlIndicators.FlowDirection = FlowDirection.LeftToRight;
            pnlIndicators.Location = new Point(450, 430);
            pnlIndicators.Name = "pnlIndicators";
            pnlIndicators.Size = new Size(100, 30);
            pnlIndicators.TabIndex = 3;
            
            // pnlActions
            // 
            pnlActions.BackColor = Color.FromArgb(245, 245, 245);
            pnlActions.Controls.Add(btnRegister);
            pnlActions.Controls.Add(btnLogin);
            pnlActions.Controls.Add(lblWelcome);
            pnlActions.Dock = DockStyle.Bottom;
            pnlActions.Location = new Point(0, 400);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(1000, 100);
            pnlActions.TabIndex = 0;
            
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(30, 35);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(407, 28);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to the Job Fair Management System";
            
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Right;
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(700, 30);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 40);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Right;
            btnRegister.BackColor = Color.ForestGreen;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(840, 30);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 40);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(50, 50, 50);
            pnlFooter.Controls.Add(lnkContactUs);
            pnlFooter.Controls.Add(lnkAboutUs);
            pnlFooter.Controls.Add(lnkUpcomingFairs);
            pnlFooter.Controls.Add(lblCopyright);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 600);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1000, 50);
            pnlFooter.TabIndex = 2;
            
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCopyright.ForeColor = Color.Silver;
            lblCopyright.Location = new Point(30, 15);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(295, 20);
            lblCopyright.TabIndex = 0;
            lblCopyright.Text = "© 2023 CareerConnect - All Rights Reserved";
            
            // lnkUpcomingFairs
            // 
            lnkUpcomingFairs.ActiveLinkColor = Color.White;
            lnkUpcomingFairs.Anchor = AnchorStyles.Right;
            lnkUpcomingFairs.AutoSize = true;
            lnkUpcomingFairs.LinkColor = Color.LightBlue;
            lnkUpcomingFairs.Location = new Point(650, 15);
            lnkUpcomingFairs.Name = "lnkUpcomingFairs";
            lnkUpcomingFairs.Size = new Size(107, 20);
            lnkUpcomingFairs.TabIndex = 1;
            lnkUpcomingFairs.TabStop = true;
            lnkUpcomingFairs.Text = "Upcoming Fairs";
            lnkUpcomingFairs.LinkClicked += lnkUpcomingFairs_LinkClicked;
            
            // lnkAboutUs
            // 
            lnkAboutUs.ActiveLinkColor = Color.White;
            lnkAboutUs.Anchor = AnchorStyles.Right;
            lnkAboutUs.AutoSize = true;
            lnkAboutUs.LinkColor = Color.LightBlue;
            lnkAboutUs.Location = new Point(780, 15);
            lnkAboutUs.Name = "lnkAboutUs";
            lnkAboutUs.Size = new Size(71, 20);
            lnkAboutUs.TabIndex = 2;
            lnkAboutUs.TabStop = true;
            lnkAboutUs.Text = "About Us";
            lnkAboutUs.LinkClicked += lnkAboutUs_LinkClicked;
            
            // lnkContactUs
            // 
            lnkContactUs.ActiveLinkColor = Color.White;
            lnkContactUs.Anchor = AnchorStyles.Right;
            lnkContactUs.AutoSize = true;
            lnkContactUs.LinkColor = Color.LightBlue;
            lnkContactUs.Location = new Point(880, 15);
            lnkContactUs.Name = "lnkContactUs";
            lnkContactUs.Size = new Size(80, 20);
            lnkContactUs.TabIndex = 3;
            lnkContactUs.TabStop = true;
            lnkContactUs.Text = "Contact Us";
            lnkContactUs.LinkClicked += lnkContactUs_LinkClicked;
            
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(pnlContent);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Name = "LandingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerConnect - Job Fair Management System";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlCarousel.ResumeLayout(false);
            pnlCarousel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFeature).EndInit();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTagline;
        private Label lblAppName;
        private Panel pnlContent;
        private Panel pnlCarousel;
        private FlowLayoutPanel pnlIndicators;
        private Label lblFeatureDescription;
        private Label lblFeatureTitle;
        private PictureBox picFeature;
        private Panel pnlActions;
        private Button btnRegister;
        private Button btnLogin;
        private Label lblWelcome;
        private Panel pnlFooter;
        private LinkLabel lnkContactUs;
        private LinkLabel lnkAboutUs;
        private LinkLabel lnkUpcomingFairs;
        private Label lblCopyright;
    }
} 