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
    public partial class RegisterForm : Form
    {
        // Connection string for SQL Server
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";
        
        public RegisterForm()
        {
            InitializeComponent();
            this.Text = "CareerConnect - Register";
            cmbRole.SelectedIndex = 0; // Default to Student role

            // Create a placeholder registration icon
            try
            {
                // Create a simple colored circle with a person silhouette
                Bitmap iconBitmap = new Bitmap(150, 150);
                using (Graphics g = Graphics.FromImage(iconBitmap))
                {
                    g.Clear(Color.White);
                    g.FillEllipse(new SolidBrush(Color.FromArgb(76, 175, 80)), 15, 15, 120, 120);
                    
                    // Draw a simplified person silhouette
                    using (Pen whitePen = new Pen(Color.White, 5))
                    {
                        // Head
                        g.FillEllipse(Brushes.White, 60, 35, 30, 30);
                        
                        // Body
                        g.DrawLine(whitePen, 75, 65, 75, 100);
                        
                        // Arms
                        g.DrawLine(whitePen, 50, 80, 100, 80);
                        
                        // Legs
                        g.DrawLine(whitePen, 75, 100, 60, 120);
                        g.DrawLine(whitePen, 75, 100, 90, 120);
                    }
                }
                picRegister.Image = iconBitmap;
            }
            catch
            {
                // If there's an error, just continue without an icon
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                ShowError("Please enter your full name.");
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                ShowError("Please enter a valid email address.");
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 6)
            {
                ShowError("Password must be at least 6 characters long.");
                txtPassword.Focus();
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                ShowError("Passwords do not match.");
                txtConfirmPassword.Focus();
                return;
            }

            if (cmbRole.SelectedIndex == -1)
            {
                ShowError("Please select a role.");
                cmbRole.Focus();
                return;
            }

            // Show loading cursor
            Cursor = Cursors.WaitCursor;
            
            // Register user in the database
            bool registered = RegisterUser();
            
            // Reset cursor
            Cursor = Cursors.Default;

            if (registered)
            {
                MessageBox.Show($"Account created successfully!\nWelcome to CareerConnect, {txtName.Text}.\nYour account will be reviewed by an administrator.", 
                    "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        
        private bool RegisterUser()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Check if email already exists
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        int existingCount = (int)checkCommand.ExecuteScalar();
                        
                        if (existingCount > 0)
                        {
                            ShowError("This email address is already registered. Please use a different email.");
                            return false;
                        }
                    }
                    
                    // Insert new user
                    string insertQuery = @"
                        INSERT INTO Users (FullName, Email, Password, Role, IsApproved)
                        VALUES (@FullName, @Email, @Password, @Role, 0);
                        SELECT SCOPE_IDENTITY();";
                    
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@FullName", txtName.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@Password", txtPassword.Text);
                        insertCommand.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString());
                        
                        // Execute and get the new UserID
                        decimal userId = (decimal)insertCommand.ExecuteScalar();
                        
                        // If the user is a student, we'll need to create a record in the Students table too
                        if (cmbRole.SelectedItem.ToString() == "Student")
                        {
                            // For now, we'll generate a placeholder FAST_ID
                            string year = DateTime.Now.Year.ToString().Substring(2);
                            string fastId = $"{year}I-{userId:0000}";
                            
                            string studentQuery = @"
                                INSERT INTO Students (StudentID, UserID, FAST_ID, DegreeProgram, CurrentSemester, GPA)
                                VALUES (@StudentID, @UserID, @FAST_ID, 'CS', 1, 0.0)";
                            
                            using (SqlCommand studentCommand = new SqlCommand(studentQuery, connection))
                            {
                                studentCommand.Parameters.AddWithValue("@StudentID", (int)userId);
                                studentCommand.Parameters.AddWithValue("@UserID", (int)userId);
                                studentCommand.Parameters.AddWithValue("@FAST_ID", fastId);
                                
                                studentCommand.ExecuteNonQuery();
                            }
                        }
                        else if (cmbRole.SelectedItem.ToString() == "Recruiter")
                        {
                            // For recruiters, we'd need to assign a company, but we'll leave this for another form
                            string recruiterQuery = @"
                                INSERT INTO Recruiters (RecruiterID, UserID, CompanyID)
                                VALUES (@RecruiterID, @UserID, 1)"; // Default to first company for now
                            
                            using (SqlCommand recruiterCommand = new SqlCommand(recruiterQuery, connection))
                            {
                                recruiterCommand.Parameters.AddWithValue("@RecruiterID", (int)userId);
                                recruiterCommand.Parameters.AddWithValue("@UserID", (int)userId);
                                
                                recruiterCommand.ExecuteNonQuery();
                            }
                        }
                        else if (cmbRole.SelectedItem.ToString() == "Coordinator")
                        {
                            // Create coordinator record
                            string coordinatorQuery = @"
                                INSERT INTO BoothCoordinators (CoordinatorID, UserID, AssignedFairID)
                                VALUES (@CoordinatorID, @UserID, 1)"; // Default to first job fair for now
                            
                            using (SqlCommand coordinatorCommand = new SqlCommand(coordinatorQuery, connection))
                            {
                                coordinatorCommand.Parameters.AddWithValue("@CoordinatorID", (int)userId);
                                coordinatorCommand.Parameters.AddWithValue("@UserID", (int)userId);
                                
                                coordinatorCommand.ExecuteNonQuery();
                            }
                        }
                        
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Registration failed: " + ex.Message);
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
} 