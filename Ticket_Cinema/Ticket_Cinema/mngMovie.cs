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
    public partial class mngMovie : Form
    {
        SqlConnection Con = new SqlConnection(
@"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=|DataDirectory|\CinemaData.mdf;
Integrated Security=True");

        public mngMovie()
        {
            InitializeComponent();
            DisplayMovies();
        }

        private void DisplayMovies()
        {
            try
            {
                Con.Open();

                string query = "SELECT * FROM Movie";

                SqlDataAdapter sda = new SqlDataAdapter(query, Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                dataGridView1.DataSource = dt;

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearData()
        {
            txtMovieID.Text = "";
            txtTitle.Text = "";
            txtGenre.Text = "";
            txtDuration.Text = "";
            txtLanguage.Text = "";
            txtRating.Text = "";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (txtMovieID.Text == "")
            {
                MessageBox.Show("Select a movie first");
                return;
            }

            try
            {
                Con.Open();

                string query =
                "DELETE FROM Movie WHERE MovieID=@MovieID";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@MovieID", txtMovieID.Text);

                cmd.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Movie Deleted Successfully");

                DisplayMovies();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (txtMovieID.Text == "" ||
    txtTitle.Text == "" ||
    txtGenre.Text == "" ||
    txtDuration.Text == "" ||
    txtLanguage.Text == "" ||
    txtRating.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            try
            {
                Con.Open();

                string query =
                "INSERT INTO Movie VALUES(@MovieID,@Title,@Genre,@Duration,@Language,@Rating)";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@MovieID", txtMovieID.Text);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
                cmd.Parameters.AddWithValue("@Duration", txtDuration.Text);
                cmd.Parameters.AddWithValue("@Language", txtLanguage.Text);
                cmd.Parameters.AddWithValue("@Rating", txtRating.Text);

                cmd.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Movie Added Successfully");

                DisplayMovies();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminPg adminPg = new AdminPg();
            adminPg.Show();
            this.Hide();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMovieID.Text = row.Cells["MovieID"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtGenre.Text = row.Cells["Genre"].Value.ToString();
                txtDuration.Text = row.Cells["Duration_Minute"].Value.ToString();
                txtLanguage.Text = row.Cells["Language"].Value.ToString();
                txtRating.Text = row.Cells["Rating"].Value.ToString();
            }
        }

        private void uptBtn_Click(object sender, EventArgs e)
        {
            if (txtMovieID.Text == "")
            {
                MessageBox.Show("Select a movie first");
                return;
            }

            try
            {
                Con.Open();

                string query =
                "UPDATE Movie SET " +
                "Title=@Title, " +
                "Genre=@Genre, " +
                "Duration_Minute=@Duration, " +
                "Language=@Language, " +
                "Rating=@Rating " +
                "WHERE MovieID=@MovieID";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@MovieID", txtMovieID.Text);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
                cmd.Parameters.AddWithValue("@Duration", txtDuration.Text);
                cmd.Parameters.AddWithValue("@Language", txtLanguage.Text);
                cmd.Parameters.AddWithValue("@Rating", txtRating.Text);

                cmd.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Movie Updated Successfully");

                DisplayMovies();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mngMovie_Load(object sender, EventArgs e)
        {

        }
    }
}
