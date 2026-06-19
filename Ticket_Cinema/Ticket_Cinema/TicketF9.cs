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
    public partial class TicketF9 : Form
    {
       
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\CinemaData.mdf;
              Integrated Security=True";

        public TicketF9()
        {
            InitializeComponent();
            this.Load += TicketF9_Load;
        }

        private void TicketF9_Load(object sender, EventArgs e)
        {
            LoadTicketDetails();
        }

        private void LoadTicketDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string queryBooking = @"
                    SELECT TOP 1 BookingID, ShowtimeID
                    FROM BOOKING
                    ORDER BY BookingDate DESC, BookingID DESC";

                string bookingId = "";
                string showtimeId = "";

                using (SqlCommand cmd = new SqlCommand(queryBooking, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bookingId = reader["BookingID"].ToString();
                        showtimeId = reader["ShowtimeID"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No booking found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                
                string queryShowtime = @"
                    SELECT m.MovieID, m.Title, s.ShowDate, s.ShowTime, h.HallName
                    FROM Showtime s
                    INNER JOIN Movie m ON s.MovieID = m.MovieID
                    INNER JOIN HALL h ON s.HallID = h.HallID
                    WHERE s.ShowtimeID = @ShowtimeID";

                using (SqlCommand cmd = new SqlCommand(queryShowtime, conn))
                {
                    cmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            lblMovie.Text = reader["Title"].ToString();

                            DateTime showDate = Convert.ToDateTime(reader["ShowDate"]);
                            lblShowtime.Text = showDate.ToString("dd-MMM-yyyy") + " " + reader["ShowTime"].ToString();

                            lblHall.Text = reader["HallName"].ToString();

                          //ni gambo movie keluar
                            string currentMovieId = reader["MovieID"].ToString();
                            Image img = null;

                            switch (currentMovieId)
                            {
                                case "M001": img = Properties.Resources.pic1; break;
                                case "M002": img = Properties.Resources.pic2; break;
                                case "M003": img = Properties.Resources.pic3; break;
                                case "M004": img = Properties.Resources.pic4; break;
                                case "M005": img = Properties.Resources.pic5; break;
                                case "M006": img = Properties.Resources.pic6; break;
                            }

                            if (img != null)
                            {
                                
                                picMovie.Image = img;
                                picMovie.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                    }
                }

               
                string queryTickets = @"
                    SELECT TicketID, SeatID, TicketPrice_RM
                    FROM TICKET
                    WHERE BookingID = @BookingID";

                List<string> ticketIds = new List<string>();
                List<string> seatList = new List<string>();
                decimal totalPrice = 0;

                using (SqlCommand cmd = new SqlCommand(queryTickets, conn))
                {
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ticketIds.Add(reader["TicketID"].ToString());
                            seatList.Add(reader["SeatID"].ToString());
                            totalPrice += Convert.ToDecimal(reader["TicketPrice_RM"]);
                        }
                    }
                }

                lblTicketID.Text = string.Join(", ", ticketIds);
                lblSeat.Text = string.Join(", ", seatList);
                lblTicketPrice.Text = "RM " + totalPrice.ToString("0.00");
            }
        }

        private void lblHall_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void lblMovie_Click(object sender, EventArgs e) { }
        private void lblShowtime_Click(object sender, EventArgs e) { }
        private void lblSeat_Click(object sender, EventArgs e) { }
        private void lblTicketID_Click(object sender, EventArgs e) { }
        private void lblTicketPrice_Click(object sender, EventArgs e) { }
        private void picMovie_Click(object sender, EventArgs e) { }
    }
}