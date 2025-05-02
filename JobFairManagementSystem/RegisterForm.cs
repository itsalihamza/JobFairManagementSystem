using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobFairManagementSystem
{
    public partial class RegisterForm : Form
    {
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
            
            // Simulate a short delay for account creation
            System.Threading.Thread.Sleep(1000);
            
            // Reset cursor
            Cursor = Cursors.Default;

            // Here we would normally save the user details to a database
            // For now, just show a success message
            MessageBox.Show($"Account created successfully!\nWelcome to CareerConnect, {txtName.Text}.", 
                "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
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