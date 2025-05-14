using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobFairManagementSystem
{
    public partial class Form1 : Form
    {
        // Connection string for SQL Server
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";
        
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
            
            // Authenticate user against database
            int? userId = AuthenticateUser(email, password, role);
            
            // Reset cursor
            Cursor = Cursors.Default;

            if (userId.HasValue)
            {
                // User authenticated successfully
                switch (role)
                {
                    case "Student":
                        OpenStudentDashboard(userId.Value);
                        break;
                    case "Recruiter":
                        OpenRecruiterDashboard(userId.Value);
                        break;
                    case "TPO":
                        OpenAdminDashboard(userId.Value);
                        break;
                    case "Coordinator":
                        OpenCoordinatorDashboard(userId.Value);
                        break;
                    default:
                        MessageBox.Show("Invalid role selected.", "Login Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid email, password, or role. Please try again.", 
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private int? AuthenticateUser(string email, string password, string role)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // SQL query to check if user exists with provided credentials and role
                    string query = @"
                        SELECT UserID 
                        FROM Users 
                        WHERE Email = @Email 
                          AND Password = @Password 
                          AND Role = @Role";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Role", role);
                        
                        object result = command.ExecuteScalar();
                        
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, 
                    "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
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

        private void OpenStudentDashboard(int userId)
        {
            this.Hide();
            StudentDashboard studentDashboard = new StudentDashboard(userId);
            studentDashboard.FormClosed += (s, args) => this.Show();
            studentDashboard.Show();
        }

        private void OpenRecruiterDashboard(int userId)
        {
            this.Hide();
            RecruiterDashboard recruiterDashboard = new RecruiterDashboard(userId);
            recruiterDashboard.FormClosed += (s, args) => this.Show();
            recruiterDashboard.Show();
        }

        private void OpenAdminDashboard(int userId)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard(userId);
            adminDashboard.FormClosed += (s, args) => this.Show();
            adminDashboard.Show();
        }

        private void OpenCoordinatorDashboard(int userId)
        {
            this.Hide();
            CoordinatorDashboard coordinatorDashboard = new CoordinatorDashboard(userId);
            coordinatorDashboard.FormClosed += (s, args) => this.Show();
            coordinatorDashboard.Show();
        }
    }
}