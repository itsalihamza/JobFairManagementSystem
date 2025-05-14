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
    public partial class StudentInfoForm : Form
    {
        private int studentId;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";
        
        public StudentInfoForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            
            // Set up degree program combobox - already set in designer
            // cmbDegreeProgram.Items.AddRange(new string[] { "CS", "SE", "AI", "DS" });
            
            // Load student data
            LoadStudentData();
        }
        
        private void LoadStudentData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            s.FAST_ID,
                            s.DegreeProgram,
                            s.CurrentSemester,
                            s.GPA,
                            u.FullName,
                            u.Email
                        FROM Students s
                        JOIN Users u ON s.UserID = u.UserID
                        WHERE s.StudentID = @StudentID";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFastId.Text = reader["FAST_ID"].ToString();
                                
                                string degreeProgram = reader["DegreeProgram"].ToString();
                                if (!string.IsNullOrEmpty(degreeProgram))
                                {
                                    cmbDegree.SelectedItem = degreeProgram;
                                }
                                
                                int semester = Convert.ToInt32(reader["CurrentSemester"]);
                                if (semester >= 1 && semester <= 8)
                                {
                                    cmbSemester.SelectedIndex = semester - 1;
                                }
                                
                                txtGPA.Text = reader["GPA"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Student profile not found.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input
            if (cmbDegree.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a degree program.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDegree.Focus();
                return;
            }

            if (cmbSemester.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a semester.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSemester.Focus();
                return;
            }

            float gpa;
            if (!float.TryParse(txtGPA.Text, out gpa) || gpa < 0 || gpa > 4.0)
            {
                MessageBox.Show("Please enter a valid GPA between 0.0 and 4.0.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGPA.Focus();
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    string updateStudentQuery = @"
                        UPDATE Students
                        SET DegreeProgram = @DegreeProgram,
                            CurrentSemester = @CurrentSemester,
                            GPA = @GPA
                        WHERE StudentID = @StudentID";
                    
                    using (SqlCommand studentCommand = new SqlCommand(updateStudentQuery, connection))
                    {
                        studentCommand.Parameters.AddWithValue("@DegreeProgram", cmbDegree.SelectedItem.ToString());
                        studentCommand.Parameters.AddWithValue("@CurrentSemester", Convert.ToInt32(cmbSemester.SelectedItem.ToString()));
                        studentCommand.Parameters.AddWithValue("@GPA", gpa);
                        studentCommand.Parameters.AddWithValue("@StudentID", studentId);
                        
                        studentCommand.ExecuteNonQuery();
                        
                        MessageBox.Show("Your profile has been updated successfully!",
                            "Profile Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
} 