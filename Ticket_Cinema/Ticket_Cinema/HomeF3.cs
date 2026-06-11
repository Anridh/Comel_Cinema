using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            public Image Poster { get; set; }
            public string Title { get; set; }
            public string Genre { get; set; }
            public string Duration { get; set; }
            public string Lang { get; set; }
            public string Rating { get; set; }
        }

        Movie[] movies;
        int startIndex = 0;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            movies = new Movie[]
            {
                new Movie
                {
                    Poster = Properties.Resources.pic1,
                    Title = "COLONY",
                    Genre = "Genre: Action",
                    Duration = "Duration: 122 Minutes",
                    Lang = "Language: Korea/English",
                    Rating = "Rating: MA 15+/16"
                },

                new Movie
                {
                    Poster = Properties.Resources.pic2,
                    Title = "AVATAR",
                    Genre = "Genre: Fantasy",
                    Duration = "Duration: 197 Minutes",
                    Lang = "Language: English",
                    Rating = "Rating: P13"
                },

                new Movie
                {
                    Poster = Properties.Resources.pic3,
                    Title = "MINECRAFT",
                    Genre = "Genre: Action/Adventure",
                    Duration = "Duration: 101 Minutes",
                    Lang = "Language: English",
                    Rating = "Rating: E10+"
                },

                new Movie
                {
                    Poster = Properties.Resources.pic4,
                    Title = "THE FURIOUS",
                    Genre = "Genre: Action",
                    Duration = "Duration: 106 Minutes",
                    Lang = "Language: Malay",
                    Rating = "Rating: P13"
                },

                new Movie
                {
                    Poster = Properties.Resources.pic5,
                    Title = "5 BOMOH",
                    Genre = "Genre: Comedy",
                    Duration = "Duration: 97 Minutes",
                    Lang = "Language: Malay",
                    Rating = "Rating: P13"
                },

                new Movie
                {
                    Poster = Properties.Resources.pic6,
                    Title = "POLONG",
                    Genre = "Genre: Horror",
                    Duration = "Duration: 120 Minutes",
                    Lang = "Language: Malay",
                    Rating = "Rating: P16"
                }
            };

            ShowMovies();
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

            if (startIndex > movies.Length - 3)
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
                startIndex = movies.Length - 3;
            }

            ShowMovies();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            HomeForm movie = new HomeForm();
            movie.Show();
            this.Hide();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            BookingF6 booking = new BookingF6();
            booking.Show();
            this.Hide();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            PaymentF7 payment = new PaymentF7();
            payment.Show();
            this.Hide();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            TicketF9 ticket = new TicketF9();
            ticket.Show();
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
            ShowtimeF4 showtime = new ShowtimeF4();
            showtime.Show();
            this.Hide();
        }

        private void btnBook2_Click(object sender, EventArgs e)
        {
            ShowtimeF4 showtime = new ShowtimeF4();
            showtime.Show();
            this.Hide();
        }

        private void btnBook3_Click(object sender, EventArgs e)
        {
            ShowtimeF4 showtime = new ShowtimeF4();
            showtime.Show();
            this.Hide();
        }
    }
}