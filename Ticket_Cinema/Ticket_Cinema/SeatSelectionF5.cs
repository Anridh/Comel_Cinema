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
            LoadBookedSeatsFromDatabase();
            LoadBookedSeatsFromDatabase();
            AttachSeatClickEvents();
            UpdateSummary();
        }
        private void AttachSeatClickEvents()
        {
            // Loop through all controls on the form
            foreach (Control control in this.Controls)
            {
                // Check if the control is a Button and its name matches a seat pattern (e.g., A1, F8)
                if (control is Button btn && btn.Name.Length == 2)
                {
                    // Only attach to interactive seats, ignore "Back" or "Next" buttons
                    if (btn.Name != "Back" && btn.Name != "Next")
                    {
                        btn.Click += SeatButton_Click;
                    }
                }
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button clickedSeat = (Button)sender;
            string seatName = clickedSeat.Text;

            // 1. Jika kerusi warna merah (Booked), jangan buat apa-apa
            if (clickedSeat.BackColor == Color.Red)
            {
                MessageBox.Show("This seat has already been booked!", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Tukar warna (Toggle Selection)
            // Jika asal kelabu (Control), tukar jadi Kuning. Jika dah Kuning, tukar balik jadi Kelabu.
            if (clickedSeat.BackColor == Color.Yellow)
            {
                clickedSeat.BackColor = SystemColors.Control; // Tukar balik ke warna asal asal button
                selectedSeats.Remove(seatName);
            }
            else
            {
                clickedSeat.BackColor = Color.Yellow; // Tukar jadi kuning tanda dipilih
                selectedSeats.Add(seatName);
            }

            // 3. Kemas kini total harga dan list kerusi dekat bawah
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

                // 🟢 Ditukar mengikut skema jadual TICKET & BOOKING anda (Pilihan 2)
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
                            string bookedSeat = reader["SeatID"].ToString();

                            // Cari button mengikut nama SeatID dari DB (cth: "B3")
                            Control[] foundControls = this.Controls.Find(bookedSeat, true);
                            if (foundControls.Length > 0 && foundControls[0] is Button seatBtn)
                            {
                                seatBtn.BackColor = Color.Red;
                                seatBtn.Enabled = false;
                            }
                        }
                    }
                }
            }
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

     

