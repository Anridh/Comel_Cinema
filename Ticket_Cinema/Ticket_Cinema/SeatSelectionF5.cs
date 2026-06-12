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
    public partial class SeatSelectionF5 : Form
    {
        private string showtimeId;
        private string movieId;
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\CinemaData.mdf;
              Integrated Security=True";
        public SeatSelectionF5(string selectedShowtimeId, string selectedMovieId    )
        {
            InitializeComponent();
            showtimeId = selectedShowtimeId;
            movieId = selectedMovieId;  
        }

        private void SeatSelection_Load(object sender, EventArgs e)
        {

        }

       

        private void labelduration_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelmoviename_Click(object sender, EventArgs e)
        {

        }

        private void labelMovie_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonA3_Click(object sender, EventArgs e)
        {

        }

        private void buttonB2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            string movieId = GetMovieId();

            ShowtimeF4 showtime = new ShowtimeF4(movieId);
            showtime.Show();
            this.Hide();
        }
        private string GetMovieId()
        {
            string movieId = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MovieID FROM Showtime WHERE ShowtimeID = @ShowtimeID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    movieId = result.ToString();
                }
            }

            return movieId;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            BookingF6 booking = new BookingF6();
            booking.Show();
            this.Hide();
        }
    }
}
