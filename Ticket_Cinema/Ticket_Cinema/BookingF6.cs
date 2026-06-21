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
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadBookingDetails();
            try { BgBrightness(); } catch { }
        }

        private void LoadBookingDetails()
        {
            textBoxMovie.Text = BookingSession.MovieTitle;
            textBoxShowtime.Text = BookingSession.ShowtimeText;
            textBoxCinemaHall.Text = BookingSession.HallName;
            textBoxSeatNumber.Text = BookingSession.SeatNumbers;
            textBoxTicketPrice.Text = "RM " + BookingSession.TicketPrice.ToString("0.00");
            textBoxTotalAmount.Text = "RM " + BookingSession.TotalAmount.ToString("0.00");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string queryCustomer = @"SELECT CustomerName, Email FROM CUSTOMER WHERE CustomerID = @CustomerID";
                using (SqlCommand cmd = new SqlCommand(queryCustomer, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", BookingSession.CustomerId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxCustomerName.Text = reader["CustomerName"].ToString();
                            textBoxEmail.Text = reader["Email"].ToString();
                            BookingSession.CustomerName = textBoxCustomerName.Text;
                            BookingSession.Email = textBoxEmail.Text;
                        }
                    }
                }
            }
        }

        private void bttnPay_Click(object sender, EventArgs e)
        {
            PaymentF7 payment = new PaymentF7();
            payment.Show();
            this.Close();
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            SeatSelectionF5 seatSelection = new SeatSelectionF5(BookingSession.ShowtimeId, BookingSession.MovieId);
            seatSelection.Show();
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
                        g.FillRectangle(brush, 0, 0, bggelap.Width, bggelap.Height);
                }
                this.BackgroundImage = bggelap;
            }
        }

        private void BookingF6_Load(object sender, EventArgs e) { }
        private void BookingF6_Load_1(object sender, EventArgs e) { }
        private void btnClose_Click(object sender, EventArgs e) { }
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
            SeatSelectionF5 seatSelection = new SeatSelectionF5(BookingSession.ShowtimeId, BookingSession.MovieId);
            seatSelection.Show();
            this.Close();
        }
    }
}