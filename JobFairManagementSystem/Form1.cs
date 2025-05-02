namespace JobFairManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "CareerConnect - Login";
            cmbRole.SelectedIndex = 0; // Default to Student role
            
            // Set up a default logo (could be replaced with a real logo)
            try {
                // Create a simple colored square as placeholder logo
                Bitmap logoBitmap = new Bitmap(150, 150);
                using (Graphics g = Graphics.FromImage(logoBitmap))
                {
                    g.Clear(Color.White);
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, 118, 210)), 15, 15, 120, 120);
                    g.DrawString("CC", new Font("Arial", 50, FontStyle.Bold), 
                        new SolidBrush(Color.White), 30, 35);
                }
                picLogo.Image = logoBitmap;
            }
            catch {
                // If there's an error, just continue without a logo
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem.ToString();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Login Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show a loading cursor
            Cursor = Cursors.WaitCursor;
            
            // Simulate a short delay for login authentication
            System.Threading.Thread.Sleep(800);

            // Reset cursor
            Cursor = Cursors.Default;

            // Here we would normally verify credentials against the database
            // For now, we'll just simulate a successful login and open the appropriate form

            switch (role)
            {
                case "Student":
                    OpenStudentDashboard();
                    break;
                case "Recruiter":
                    OpenRecruiterDashboard();
                    break;
                case "TPO":
                    OpenAdminDashboard();
                    break;
                case "Coordinator":
                    OpenCoordinatorDashboard();
                    break;
                default:
                    MessageBox.Show("Invalid role selected.", "Login Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open registration form
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
        
        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = txtEmail.Text.Trim();
            
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address first.", "Password Reset",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            
            // In a real application, this would trigger a password reset email
            MessageBox.Show($"A password reset link has been sent to {email}.\nPlease check your email to reset your password.", 
                "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenStudentDashboard()
        {
            this.Hide();
            StudentDashboard studentDashboard = new StudentDashboard();
            studentDashboard.FormClosed += (s, args) => this.Show();
            studentDashboard.Show();
        }

        private void OpenRecruiterDashboard()
        {
            this.Hide();
            RecruiterDashboard recruiterDashboard = new RecruiterDashboard();
            recruiterDashboard.FormClosed += (s, args) => this.Show();
            recruiterDashboard.Show();
        }

        private void OpenAdminDashboard()
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.FormClosed += (s, args) => this.Show();
            adminDashboard.Show();
        }

        private void OpenCoordinatorDashboard()
        {
            this.Hide();
            CoordinatorDashboard coordinatorDashboard = new CoordinatorDashboard();
            coordinatorDashboard.FormClosed += (s, args) => this.Show();
            coordinatorDashboard.Show();
        }
    }
}