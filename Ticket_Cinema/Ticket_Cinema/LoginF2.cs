using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Added for database connection

namespace Ticket_Cinema
{
    public partial class LoginF2 : Form
    {
        // Define your connection string pointing to CinemaData.mdf
        // AttachDbFilename uses |DataDirectory| to automatically find the file in your project folders
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CinemaData.mdf;Integrated Security=True;";

        public LoginF2()
        {
            InitializeComponent();
        }

        private void LoginF2_Load(object sender, EventArgs e)
        {

        }

        private void signUpLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupF1 signup = new SignupF1();
            signup.Show();
            this.Hide();
        }

        // 1. CUSTOMER LOGIN BUTTON
        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Simple validation to ensure fields aren't empty
            if (string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(passTxtBox.Text))
            {
                MessageBox.Show("Please enter both Name and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // FIX 1: Added the missing query string variable here
            string query = "SELECT COUNT(*) FROM [dbo].[User] WHERE UserName = @Name AND UserPassword = @Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Use parameters to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@Name", emailTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", passTxtBox.Text.Trim());

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful! Welcome Customer.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // FIX 2: Changed HomeF3 back to HomeForm (matching your project's previous form name)
                            HomeF3 home = new HomeF3();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Customer Name or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 2. ADMIN LOGIN BUTTON 
        // Double-click your Admin button in the designer to link it to this event if it isn't already
        private void adminBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(passTxtBox.Text))
            {
                MessageBox.Show("Please enter Admin credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Querying your separate 'Admin' table
            string query = "SELECT COUNT(*) FROM [Admin] WHERE AdminName = @Name AND AdminPassword = @Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", emailTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", passTxtBox.Text.Trim());

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Admin Authentication Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Open the Admin panel dashboard form (e.g., mngMovie form from your Solution Explorer)
                            mngMovie adminDashboard = new mngMovie();
                            adminDashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Admin Name or Password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void passCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (passCheckBox.Checked)
            {
                passTxtBox.UseSystemPasswordChar = false;
            }
            else
            {
                passTxtBox.UseSystemPasswordChar = true;
            }
        }

        private void passTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}