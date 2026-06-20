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
    public partial class BookingF6 : Form
    {
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\CinemaData.mdf;
              Integrated Security=True";

        private string bookingId = "";
        private string showtimeId = "";
        private string movieId = "";

        public BookingF6()
        {
            InitializeComponent();
            //this.Load += BookingF6_Load;
        }

        private void BookingF6_Load(object sender, EventArgs e)
        {
            LoadLatestBookingDetails();
        }

        private void LoadLatestBookingDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string queryBooking = @"
                    SELECT TOP 1 BookingID, TotalAmount_RM, CustomerID, ShowtimeID
                    FROM BOOKING
                    ORDER BY BookingDate DESC, BookingID DESC";

                string customerId = "";
                decimal totalAmount = 0;

                using (SqlCommand cmd = new SqlCommand(queryBooking, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bookingId = reader["BookingID"].ToString();
                        customerId = reader["CustomerID"].ToString();
                        showtimeId = reader["ShowtimeID"].ToString();
                        totalAmount = Convert.ToDecimal(reader["TotalAmount_RM"]);
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
                            movieId = reader["MovieID"].ToString();
                            textBoxMovie.Text = reader["Title"].ToString();

                            DateTime showDate = Convert.ToDateTime(reader["ShowDate"]);
                            textBoxShowtime.Text = showDate.ToString("dd-MMM-yyyy") + " " + reader["ShowTime"].ToString();

                            textBoxCinemaHall.Text = reader["HallName"].ToString();
                        }
                    }
                }

               //ini pun dato yang kita guna
                string querySeats = @"
                    SELECT SeatID, TicketPrice_RM
                    FROM TICKET
                    WHERE BookingID = @BookingID";

                List<string> seatList = new List<string>();
                decimal ticketPrice = 0;

                using (SqlCommand cmd = new SqlCommand(querySeats, conn))
                {
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            seatList.Add(reader["SeatID"].ToString());
                            ticketPrice = Convert.ToDecimal(reader["TicketPrice_RM"]);
                        }
                    }
                }

                textBoxSeatNumber.Text = string.Join(", ", seatList);
                textBoxTicketPrice.Text = ticketPrice.ToString("0.00");
                textBoxTotalAmount.Text = totalAmount.ToString("0.00");
                //gini dato dato-dat0 duk kat sini untuk customer name dan email
                string queryCustomer = @"
                    SELECT CustomerName, Email
                    FROM CUSTOMER
                    WHERE CustomerID = @CustomerID";

                using (SqlCommand cmd = new SqlCommand(queryCustomer, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxCustomerName.Text = reader["CustomerName"].ToString();
                            textBoxEmail.Text = reader["Email"].ToString();
                        }
                    }
                }
            }
        }

        //yang ni ini nak gi payment nak bayo kalau tak bayo kene tangka
        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking confirmed! Proceeding to payment.",
             "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            PaymentF7 payment = new PaymentF7();
            payment.Show();
            this.Close();
        }
        // button ni digunakan untk kembali ke tempat waktu kita berjumpa
        private void backBtn_Click_1(object sender, EventArgs e)
        {
            SeatSelectionF5 seatSelection = new SeatSelectionF5(showtimeId, movieId);
            seatSelection.Show();
            this.Close();
        }

        private void textBoxCustomerName_TextChanged(object sender, EventArgs e) { }
        private void textBoxEmail_TextChanged(object sender, EventArgs e) { }
        private void textBoxMovie_TextChanged(object sender, EventArgs e) { }
        private void textBoxShowtime_TextChanged(object sender, EventArgs e) { }
        private void textBoxCinemaHall_TextChanged(object sender, EventArgs e) { }
        private void textBoxSeatNumber_TextChanged(object sender, EventArgs e) { }
        private void textBoxTicketPrice_TextChanged(object sender, EventArgs e) { }
        private void textBoxTotalAmount_TextChanged(object sender, EventArgs e) { }

        private void labelbooking_Click(object sender, EventArgs e)
        {

        }

        private void BookingF6_Load_1(object sender, EventArgs e)
        {

        }
    }
}