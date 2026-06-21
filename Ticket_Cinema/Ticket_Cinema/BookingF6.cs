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

        public BookingF6()
        {
            InitializeComponent();
            this.Load += BookingF6_Load;
        }

        private void BookingF6_Load(object sender, EventArgs e)
        {
            LoadBookingDetails();
        }

        private void BookingF6_Load_1(object sender, EventArgs e)
        {
            BgBrightness();
        }

        private void LoadBookingDetails()
        {
            //data ni ditarik dari variable array yang telah di setkan (tetapi dia tak berganggu dengan database)
            if (string.IsNullOrEmpty(BookingSession.BookingId))
            {
                MessageBox.Show("No booking found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxMovie.Text = BookingSession.MovieTitle;
            textBoxShowtime.Text = BookingSession.ShowtimeText;
            textBoxCinemaHall.Text = BookingSession.HallName;
            textBoxSeatNumber.Text = BookingSession.SeatNumbers;
            textBoxTicketPrice.Text = BookingSession.TicketPrice.ToString("0.00");
            textBoxTotalAmount.Text = BookingSession.TotalAmount.ToString("0.00");

            //databse untuk customerid name/email
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string queryCustomer = @"
                    SELECT CustomerName, Email
                    FROM CUSTOMER
                    WHERE CustomerID = @CustomerID";

                using (SqlCommand cmd = new SqlCommand(queryCustomer, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", BookingSession.CustomerId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxCustomerName.Text = reader["CustomerName"].ToString();
                            textBoxEmail.Text = reader["Email"].ToString();

                           //letakkan kan data ini ke dalam variable
                            BookingSession.CustomerName = textBoxCustomerName.Text;
                            BookingSession.Email = textBoxEmail.Text;
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            SeatSelectionF5 seatSelection = new SeatSelectionF5(BookingSession.ShowtimeId, BookingSession.MovieId);
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

        private void labelbooking_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            SeatSelectionF5 seatSelection = new SeatSelectionF5(showtimeId, movieId);
            seatSelection.Show();
            this.Close();
        }

        private void bttnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking confirmed! Proceeding to payment.",
             "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            PaymentF7 payment = new PaymentF7();
            payment.Show();
            this.Close();
        }
        private void BgBrightness()
        {
            if (this.BackgroundImage != null)
            {
                Image gambarAsal = this.BackgroundImage;
                Bitmap bggelap = new Bitmap(gambarAsal.Width, gambarAsal.Height);

                bggelap.SetResolution(gambarAsal.HorizontalResolution, gambarAsal.VerticalResolution);
                using (Graphics g = Graphics.FromImage(bggelap))
                {
                    g.DrawImage(this.BackgroundImage, 0, 0);
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(160, 0, 0, 0)))
                    {
                        g.FillRectangle(brush, 0, 0, bggelap.Width, bggelap.Height);
                    }
                }
                this.BackgroundImage = bggelap;
            }

        }
    }
}