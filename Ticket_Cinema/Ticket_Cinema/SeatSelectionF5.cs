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
using Ticket_Cinema;

namespace Ticket_Cinema
{
    public partial class SeatSelectionF5 : Form
    {
        private string showtimeId;
        private string movieId;
        private const decimal SEAT_PRICE = 15.00m;
        private List<string> selectedSeats = new List<string>();

        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\CinemaData.mdf;
              Integrated Security=True";

        public SeatSelectionF5(string selectedShowtimeId, string selectedMovieId)
        {
            InitializeComponent();
            showtimeId = selectedShowtimeId;
            movieId = selectedMovieId;
        }

        private void SeatSelection_Load(object sender, EventArgs e)
        {
            LoadMovieDetailsAndShowtime();
            LoadBookedSeatsFromDatabase();
            AttachSeatClickEvents();
            UpdateSummary();
        }

        private void LoadMovieDetailsAndShowtime()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 🟢 MovieImage dipadamkan dari query kerana ia tiada dalam database anda
                string query = @"
            SELECT m.MovieID, m.Title, s.ShowDate, s.ShowTime, s.HallID, h.HallName
            FROM Showtime s
            INNER JOIN Movie m ON s.MovieID = m.MovieID
            INNER JOIN HALL h ON s.HallID = h.HallID
            WHERE s.ShowtimeID = @ShowtimeID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 1. Papar Nama Filem
                            labelmoviename.Text = reader["Title"].ToString();

                            // 2. Papar Tarikh
                            if (reader["ShowDate"] != DBNull.Value)
                            {
                                DateTime dateValue = Convert.ToDateTime(reader["ShowDate"]);
                                labelDatemovie.Text = dateValue.ToString("dd-MMM-yyyy");
                            }

                            // 3. Papar Masa & Hall
                            labelTime.Text = reader["ShowTime"].ToString();
                            labelHall.Text = reader["HallName"].ToString();

                            // 4. PAPAR GAMBAR POSTER MOVIE DARI RESOURCES 🎬
                            string currentMovieId = reader["MovieID"].ToString();
                            Image img = null;

                            // Menggunakan logik switch-case yang sama seperti HomeForm anda
                            switch (currentMovieId)
                            {
                                case "M001": img = Properties.Resources.pic1; break;
                                case "M002": img = Properties.Resources.pic2; break;
                                case "M003": img = Properties.Resources.pic3; break;
                                case "M004": img = Properties.Resources.pic4; break;
                                case "M005": img = Properties.Resources.pic5; break;
                                case "M006": img = Properties.Resources.pic6; break;
                            }

                            // Jika gambar dijumpai, paparkan pada pictureBox1
                            if (img != null)
                            {
                                pictureBox1.Image = img;
                                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                    }
                }
            }
        }

        private void AttachSeatClickEvents()
        {
            GetAllSeatButtons(this);
        }

        private void GetAllSeatButtons(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is Button btn && btn.Name.Length == 2 && btn.Name != "Back" && btn.Name != "Next")
                {
                    btn.Click -= SeatButton_Click;
                    btn.Click += SeatButton_Click;
                }

                if (control.HasChildren)
                {
                    GetAllSeatButtons(control);
                }
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button clickedSeat = (Button)sender;
            string seatName = clickedSeat.Text;

            if (clickedSeat.BackColor == Color.Red)
            {
                MessageBox.Show("This seat has already been booked!", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clickedSeat.BackColor == Color.Yellow)
            {
                clickedSeat.BackColor = SystemColors.Control;
                selectedSeats.Remove(seatName);
            }
            else
            {
                clickedSeat.BackColor = Color.Yellow;
                selectedSeats.Add(seatName);
            }

            UpdateSummary();
        }

        private void UpdateSummary()
        {
            txtSelectedSeats.Text = string.Join(", ", selectedSeats);

            decimal totalPrice = selectedSeats.Count * SEAT_PRICE;
            txtTotalPrice.Text = totalPrice.ToString("0.00");
        }

        private void LoadBookedSeatsFromDatabase()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT t.SeatID
                    FROM TICKET t
                    INNER JOIN BOOKING b ON t.BookingID = b.BookingID
                    WHERE b.ShowtimeID = @ShowtimeID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bookedSeat = reader["SeatID"].ToString().Trim();
                            Control seatControl = FindControlRecursive(this, bookedSeat);

                            if (seatControl != null && seatControl is Button seatBtn)
                            {
                                seatBtn.BackColor = Color.Red;
                                seatBtn.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private Control FindControlRecursive(Control container, string name)
        {
            if (container.Name == name) return container;

            foreach (Control subControl in container.Controls)
            {
                Control foundId = FindControlRecursive(subControl, name);
                if (foundId != null) return foundId;
            }
            return null;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            string movieIdForBack = GetMovieId();

            ShowtimeF4 showtime = new ShowtimeF4(movieIdForBack);
            showtime.Show();
            this.Hide();
        }

        private string GetMovieId()
        {
            string result = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MovieID FROM Showtime WHERE ShowtimeID = @ShowtimeID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);
                object queryResult = cmd.ExecuteScalar();

                if (queryResult != null)
                {
                    result = queryResult.ToString();
                }
            }
            return result;
        }

        // ---------------- BOOKING SUBMIT (this is the part that was buggy) ----------------

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Sila pilih sekurang-kurangnya satu kerusi!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string currentCustomerId = string.IsNullOrEmpty(BookingSession.CustomerId)
                ? "C101"
                : BookingSession.CustomerId;

            decimal totalAmount = selectedSeats.Count * SEAT_PRICE;
            string newBookingId;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    newBookingId = GenerateNewBookingId(conn, transaction);

                    string queryBooking = @"INSERT INTO BOOKING (BookingID, BookingDate, TotalAmount_RM, CustomerID, ShowtimeID)
                                            VALUES (@BookingID, @BookingDate, @TotalAmount, @CustomerID, @ShowtimeID)";

                    using (SqlCommand cmdBooking = new SqlCommand(queryBooking, conn, transaction))
                    {
                        cmdBooking.Parameters.AddWithValue("@BookingID", newBookingId);
                        cmdBooking.Parameters.AddWithValue("@BookingDate", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmdBooking.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmdBooking.Parameters.AddWithValue("@CustomerID", currentCustomerId);
                        cmdBooking.Parameters.AddWithValue("@ShowtimeID", showtimeId);
                        cmdBooking.ExecuteNonQuery();
                    }

                    int nextTicketNumber = GetNextTicketNumber(conn, transaction);
                    foreach (string seat in selectedSeats)
                    {
                        string newTicketId = "T99" + nextTicketNumber.ToString("00");

                        string queryTicket = @"INSERT INTO TICKET (TicketID, TicketPrice_RM, BookingID, SeatID)
                                               VALUES (@TicketID, @Price, @BookingID, @SeatID)";

                        using (SqlCommand cmdTicket = new SqlCommand(queryTicket, conn, transaction))
                        {
                            cmdTicket.Parameters.AddWithValue("@TicketID", newTicketId);
                            cmdTicket.Parameters.AddWithValue("@Price", SEAT_PRICE);
                            cmdTicket.Parameters.AddWithValue("@BookingID", newBookingId);
                            cmdTicket.Parameters.AddWithValue("@SeatID", seat);
                            cmdTicket.ExecuteNonQuery();
                        }
                        nextTicketNumber++;
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Could not save booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // ni untuk variable array untuk set kan data sekali. dan bende ini tak menganggu dengan data base
            BookingSession.BookingId = newBookingId; 
            BookingSession.ShowtimeId = showtimeId;
            BookingSession.MovieId = movieId;
            BookingSession.CustomerId = currentCustomerId;
            BookingSession.SeatNumbers = string.Join(", ", selectedSeats);
            BookingSession.TicketPrice = SEAT_PRICE;
            BookingSession.TotalAmount = totalAmount;
            BookingSession.MovieTitle = labelmoviename.Text;
            BookingSession.ShowtimeText = labelDatemovie.Text + " " + labelTime.Text;
            BookingSession.HallName = labelHall.Text;

            MessageBox.Show("Tempahan kerusi berjaya disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BookingF6 booking = new BookingF6();
            booking.Show();
            this.Hide();
        }

        private string GenerateNewBookingId(SqlConnection conn, SqlTransaction transaction)
        {
            string query = "SELECT MAX(BookingID) FROM BOOKING";
            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value) return "B8801";
                string lastId = result.ToString();
                int lastNum = int.Parse(lastId.Substring(3));
                return "B88" + (lastNum + 1).ToString("00");
            }
        }

        private int GetNextTicketNumber(SqlConnection conn, SqlTransaction transaction)
        {
            string query = "SELECT MAX(TicketID) FROM TICKET";
            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value) return 1;
                string lastId = result.ToString();
                int lastNum = int.Parse(lastId.Substring(3));
                return lastNum + 1;
            }
        }

        private void textBoxScreen_TextChanged(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }
    }

    public static class BookingSession
    {
        public static string BookingId = "";
        public static string ShowtimeId = "";
        public static string MovieId = "";
        public static string CustomerId = "";
        public static string CustomerName = "";
        public static string Email = "";
        public static string MovieTitle = "";
        public static string ShowtimeText = "";
        public static string HallName = "";
        public static string SeatNumbers = "";
        public static decimal TicketPrice = 0;
        public static decimal TotalAmount = 0;

        public static void Reset()
        {
            BookingId = "";
            ShowtimeId = "";
            MovieId = "";
            CustomerId = "";
            CustomerName = "";
            Email = "";
            MovieTitle = "";
            ShowtimeText = "";
            HallName = "";
            SeatNumbers = "";
            TicketPrice = 0;
            TotalAmount = 0;
        }
    }
}