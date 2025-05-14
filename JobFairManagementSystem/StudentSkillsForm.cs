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
    public partial class StudentSkillsForm : Form
    {
        private int studentId;
        private string connectionString = @"Data Source=LAPTOP-K5D96394\SQLEXPRESS;Initial Catalog=CareerConnectDB;Integrated Security=True";
        
        public StudentSkillsForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            
            // Load student skills
            LoadStudentSkills();
            // Load available skills
            LoadAvailableSkills();
        }
        
        private void LoadStudentSkills()
        {
            try
            {
                lstSkills.Items.Clear();
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT s.SkillName
                        FROM StudentSkills ss
                        JOIN Skills s ON ss.SkillID = s.SkillID
                        WHERE ss.StudentID = @StudentID
                        ORDER BY s.SkillName";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lstSkills.Items.Add(reader["SkillName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student skills: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadAvailableSkills()
        {
            try
            {
                // This method would normally load skills not already added to student
                // But we're just working with a single list for now
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available skills: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSkill.Text.Trim()))
            {
                MessageBox.Show("Please enter a skill to add.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedSkill = txtSkill.Text.Trim();
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Get the skill ID
                    string getSkillIdQuery = "SELECT SkillID FROM Skills WHERE SkillName = @SkillName";
                    
                    using (SqlCommand command = new SqlCommand(getSkillIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SkillName", selectedSkill);
                        object skillIdObj = command.ExecuteScalar();
                        
                        if (skillIdObj != null)
                        {
                            int skillId = Convert.ToInt32(skillIdObj);
                            
                            // Add the skill to the student's skills
                            string insertQuery = @"
                                INSERT INTO StudentSkills (StudentID, SkillID)
                                VALUES (@StudentID, @SkillID)";
                            
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@StudentID", studentId);
                                insertCommand.Parameters.AddWithValue("@SkillID", skillId);
                                
                                insertCommand.ExecuteNonQuery();
                                
                                // Refresh the lists
                                LoadStudentSkills();
                                LoadAvailableSkills();
                                txtSkill.Clear();
                            }
                        }
                        else
                        {
                            // Skill doesn't exist, so add it
                            AddNewSkill(selectedSkill);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding skill: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {
            if (lstSkills.SelectedItem == null)
            {
                MessageBox.Show("Please select a skill to remove.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedSkill = lstSkills.SelectedItem.ToString();
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Get the skill ID
                    string getSkillIdQuery = "SELECT SkillID FROM Skills WHERE SkillName = @SkillName";
                    
                    using (SqlCommand command = new SqlCommand(getSkillIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SkillName", selectedSkill);
                        object skillIdObj = command.ExecuteScalar();
                        
                        if (skillIdObj != null)
                        {
                            int skillId = Convert.ToInt32(skillIdObj);
                            
                            // Remove the skill from the student's skills
                            string deleteQuery = @"
                                DELETE FROM StudentSkills 
                                WHERE StudentID = @StudentID 
                                AND SkillID = @SkillID";
                            
                            using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                            {
                                deleteCommand.Parameters.AddWithValue("@StudentID", studentId);
                                deleteCommand.Parameters.AddWithValue("@SkillID", skillId);
                                
                                deleteCommand.ExecuteNonQuery();
                                
                                // Refresh the lists
                                LoadStudentSkills();
                                LoadAvailableSkills();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing skill: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewSkill(string newSkill)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Check if skill already exists
                    string checkQuery = "SELECT COUNT(*) FROM Skills WHERE SkillName = @SkillName";
                    
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@SkillName", newSkill);
                        int count = (int)checkCommand.ExecuteScalar();
                        
                        if (count > 0)
                        {
                            MessageBox.Show("This skill already exists in the system.",
                                "Duplicate Skill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSkill.Clear();
                            return;
                        }
                    }
                    
                    // Add the new skill
                    string insertSkillQuery = @"
                        INSERT INTO Skills (SkillName)
                        VALUES (@SkillName);
                        SELECT SCOPE_IDENTITY();";
                    
                    using (SqlCommand insertCommand = new SqlCommand(insertSkillQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@SkillName", newSkill);
                        
                        decimal skillId = (decimal)insertCommand.ExecuteScalar();
                        
                        // Add the skill to the student's skills
                        string insertStudentSkillQuery = @"
                            INSERT INTO StudentSkills (StudentID, SkillID)
                            VALUES (@StudentID, @SkillID)";
                        
                        using (SqlCommand insertStudentSkillCommand = new SqlCommand(insertStudentSkillQuery, connection))
                        {
                            insertStudentSkillCommand.Parameters.AddWithValue("@StudentID", studentId);
                            insertStudentSkillCommand.Parameters.AddWithValue("@SkillID", (int)skillId);
                            
                            insertStudentSkillCommand.ExecuteNonQuery();
                            
                            // Refresh the lists
                            LoadStudentSkills();
                            LoadAvailableSkills();
                            txtSkill.Clear();
                            
                            MessageBox.Show($"Skill '{newSkill}' has been added successfully!",
                                "Skill Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding new skill: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnAddCert_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrEmpty(txtCertTitle.Text.Trim()))
            {
                MessageBox.Show("Please enter a certification title.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCertTitle.Focus();
                return;
            }
            
            if (string.IsNullOrEmpty(txtCertIssuer.Text.Trim()))
            {
                MessageBox.Show("Please enter the certification issuer.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCertIssuer.Focus();
                return;
            }
            
            // Add the certification to the list
            string certDetails = $"{txtCertTitle.Text.Trim()} - {txtCertIssuer.Text.Trim()} ({dtpCertDate.Value.ToString("MM/yyyy")})";
            lstCertifications.Items.Add(certDetails);
            
            // Clear inputs
            txtCertTitle.Clear();
            txtCertIssuer.Clear();
            dtpCertDate.Value = DateTime.Now;
            txtCertTitle.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
} 