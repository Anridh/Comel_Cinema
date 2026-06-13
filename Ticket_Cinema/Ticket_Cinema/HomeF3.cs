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
    public partial class HomeForm : Form
    {
        public class Movie
        {
            public string MovieID { get; set; }   // Add this

            public Image Poster { get; set; }
            public string Title { get; set; }
            public string Genre { get; set; }
            public string Duration { get; set; }
            public string Lang { get; set; }
            public string Rating { get; set; }
        }

        List<Movie> movies = new List<Movie>();
        int startIndex = 0;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            LoadMovies();
            ShowMovies();
        }
        private void LoadMovies()
        {
            movies.Clear();

            string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
          AttachDbFilename=|DataDirectory|\CinemaData.mdf;
          Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM MOVIE";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string movieId = reader["MovieID"].ToString();

                    Image img = null;

                    switch (movieId)
                    {
                        case "M001":
                            img = Properties.Resources.pic1;
                            break;

                        case "M002":
                            img = Properties.Resources.pic2;
                            break;

                        case "M003":
                            img = Properties.Resources.pic3;
                            break;

                        case "M004":
                            img = Properties.Resources.pic4;
                            break;

                        case "M005":
                            img = Properties.Resources.pic5;
                            break;

                        case "M006":
                            img = Properties.Resources.pic6;
                            break;
                    }
                    movies.Add(new Movie
                    {
                        MovieID = reader["MovieID"].ToString(),
                        Title = reader["Title"].ToString(),
                        Genre = reader["Genre"].ToString(),
                        Duration = reader["Duration_Minute"].ToString(),
                        Lang = reader["Language"].ToString(),
                        Rating = reader["Rating"].ToString(),

                        Poster = img// Poster will be handled later
                    });
                }
            }
        }   

        private void ShowMovies()
        {
            pictureBox1.Image = movies[startIndex].Poster;
            lblTitle1.Text = movies[startIndex].Title;
            lblGenre1.Text = movies[startIndex].Genre;
            lblDuration1.Text = movies[startIndex].Duration;
            lblLang1.Text = movies[startIndex].Lang;
            lblRating1.Text = movies[startIndex].Rating;

            pictureBox2.Image = movies[startIndex + 1].Poster;
            lblTitle2.Text = movies[startIndex + 1].Title;
            lblGenre2.Text = movies[startIndex + 1].Genre;
            lblDuration2.Text = movies[startIndex + 1].Duration;
            lblLang2.Text = movies[startIndex + 1].Lang;
            lblRating2.Text = movies[startIndex + 1].Rating;

            pictureBox3.Image = movies[startIndex + 2].Poster;
            lblTitle3.Text = movies[startIndex + 2].Title;
            lblGenre3.Text = movies[startIndex + 2].Genre;
            lblDuration3.Text = movies[startIndex + 2].Duration;
            lblLang3.Text = movies[startIndex + 2].Lang;
            lblRating3.Text = movies[startIndex + 2].Rating;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            startIndex++;

            if (startIndex > movies.Count - 3)
            {
                startIndex = 0;
            }

            ShowMovies();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            startIndex--;

            if (startIndex < 0)
            {
                startIndex = movies.Count - 3;
            }

            ShowMovies();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            BookingF6 booking = new BookingF6();
            booking.Show();
            this.Hide();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginF2 login = new LoginF2();
                login.Show();
                this.Hide();
            }
        }

        private void btnBook1_Click(object sender, EventArgs e)
        {
            string movieId = movies[startIndex].MovieID;

            ShowtimeF4 showtime = new ShowtimeF4(movieId);
            showtime.Show();
            this.Hide();    
        }

        private void btnBook2_Click(object sender, EventArgs e)
        {
            string movieId = movies[startIndex + 1].MovieID;

            ShowtimeF4 showtime = new ShowtimeF4(movieId);
            showtime.Show();
            this.Hide();
        }

        private void btnBook3_Click(object sender, EventArgs e)
        {
            string movieId = movies[startIndex + 2].MovieID;
            ShowtimeF4 showtime = new ShowtimeF4(movieId);
            showtime.Show();
            this.Hide();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}