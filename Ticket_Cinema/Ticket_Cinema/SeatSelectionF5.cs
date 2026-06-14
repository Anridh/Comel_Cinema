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
        private const decimal SEAT_PRICE = 15.00m;
        private List<string> selectedSeats = new List<string>();

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
                // Jika butang kerusi sepanjang 2 huruf (cth: A1, B4) dan bukan butang navigasi
                if (control is Button btn && btn.Name.Length == 2 && btn.Name != "Back" && btn.Name != "Next")
                {
                    btn.Click -= SeatButton_Click; // Elakkan pertindihan event
                    btn.Click += SeatButton_Click;
                }

                // Jika butang tersimpan di dalam panel/container lain, gali ke dalam
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
            // Join names into a comma-separated string: "C3, C4"
            // 🟢 Nota: Pastikan (Name) property Textbox anda di designer ditukar kepada nama di bawah
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

                            // Menggunakan fungsi rekursif untuk mencari kawalan di seluruh pelan form
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
        // Fungsi khas mencari komponen secara mendalam ke dalam form anak
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
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Sila pilih sekurang-kurangnya satu kerusi!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Generasikan ID contoh (Anda boleh ubah mengikut logik penjanaan ID anda sendiri)
            string newBookingId = "B88" + DateTime.Now.ToString("ssmm");
            string currentCustomerId = "C101";
            decimal totalAmount = selectedSeats.Count * SEAT_PRICE;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // ---- 1. INSERT MASUK TABLE BOOKING ----
                string queryBooking = @"INSERT INTO BOOKING (BookingID, BookingDate, TotalAmount_RM, CustomerID, ShowtimeID) 
                                        VALUES (@BookingID, @BookingDate, @TotalAmount, @CustomerID, @ShowtimeID)";

                using (SqlCommand cmdBooking = new SqlCommand(queryBooking, conn))
                {
                    cmdBooking.Parameters.AddWithValue("@BookingID", newBookingId);
                    cmdBooking.Parameters.AddWithValue("@BookingDate", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmdBooking.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    cmdBooking.Parameters.AddWithValue("@CustomerID", currentCustomerId);
                    cmdBooking.Parameters.AddWithValue("@ShowtimeID", showtimeId);

                    cmdBooking.ExecuteNonQuery();
                }

                // ---- 2. INSERT MASUK TABLE TICKET (Looping ikot jumlah kerusi) ----
                int ticketCounter = 1;
                foreach (string seat in selectedSeats)
                {
                    string newTicketId = "T99" + DateTime.Now.ToString("ff") + ticketCounter;

                    string queryTicket = @"INSERT INTO TICKET (TicketID, TicketPrice_RM, BookingID, SeatID) 
                                           VALUES (@TicketID, @Price, @BookingID, @SeatID)";

                    using (SqlCommand cmdTicket = new SqlCommand(queryTicket, conn))
                    {
                        cmdTicket.Parameters.AddWithValue("@TicketID", newTicketId);
                        cmdTicket.Parameters.AddWithValue("@Price", SEAT_PRICE);
                        cmdTicket.Parameters.AddWithValue("@BookingID", newBookingId);
                        cmdTicket.Parameters.AddWithValue("@SeatID", seat);

                        cmdTicket.ExecuteNonQuery();
                    }
                    ticketCounter++;
                }
            }

            MessageBox.Show("Tempahan kerusi berjaya disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Buka form BookingF6
            BookingF6 booking = new BookingF6();
            booking.Show();
            this.Hide();
        }

        // Kosongkan / Padam kaedah kosong yang tidak digunakan untuk mengemas kod anda
       
        
        
    }
}

     

