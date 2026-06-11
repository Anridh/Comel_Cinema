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

namespace Ticket_Cinema
{
    public partial class SignupF1 : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CinemaData.mdf;Integrated Security=True";
        public SignupF1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20; // Nilai radius mesti SAMA dengan nilai di Form_Load tadi
            int borderThickness = 3; // Ketebalan garisan border (dalam piksel)
            Color borderColor = Color.White; // Anda boleh tukar warna border di sini (cth: Gray, White, Gold)

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath())
            {
                gp.AddArc(0, 0, radius, radius, 180, 90);
                gp.AddArc(panel1.Width - radius, 0, radius, radius, 270, 90);
                gp.AddArc(panel1.Width - radius, panel1.Height - radius, radius, radius, 0, 90);
                gp.AddArc(0, panel1.Height - radius, radius, radius, 90, 90);
                gp.CloseFigure();

                using (Pen pen = new Pen(borderColor, borderThickness))
                {
                    e.Graphics.DrawPath(pen, gp);
                }
            }

        }
        private void BucuPanel(Panel pnl, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, pnl.Height - radius, radius, radius, 90, 90);
            pnl.Region = new Region(gp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BucuPanel(panel1, 20);
        }

      

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (passR.Text != PassRCon.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(passR.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Insert user credentials into the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Customer (Email, Password) VALUES (@Email, @Password)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Using parameters prevents SQL Injection attacks
                    cmd.Parameters.AddWithValue("@Email", emailTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", passR.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery(); // Executes the insert statement

                        MessageBox.Show("Account created successfully! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optional: Navigate to login form here
                    }
                    catch (SqlException ex)
                    {
                        // Handles if an email is already registered (since we marked Email as UNIQUE)
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("This email is already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Database error: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void loginLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginF2 login = new LoginF2();
            login.Show();
            this.Hide();
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(passCheckBox.Checked)
            { passR.UseSystemPasswordChar = false; PassRCon.UseSystemPasswordChar = false; }
            else { passR.UseSystemPasswordChar = true; PassRCon.UseSystemPasswordChar = true; }
        }

        private void PassRCon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
