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
            
            if (string.IsNullOrEmpty(BookingSession.BookingId))
            {
                MessageBox.Show("No booking found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblMovie.Text = BookingSession.MovieTitle;
            lblShowtime.Text = BookingSession.ShowtimeText;
            lblHall.Text = BookingSession.HallName;
            lblSeat.Text = BookingSession.SeatNumbers;
            lblTicketPrice.Text = "RM " + BookingSession.TotalAmount.ToString("0.00");

            // ni gambo movie keluar
            Image img = null;
            switch (BookingSession.MovieId)
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

            //ni utuk update databse ticket id
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string queryTickets = @"
                    SELECT TicketID
                    FROM TICKET
                    WHERE BookingID = @BookingID";

                List<string> ticketIds = new List<string>();

                using (SqlCommand cmd = new SqlCommand(queryTickets, conn))
                {
                    cmd.Parameters.AddWithValue("@BookingID", BookingSession.BookingId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ticketIds.Add(reader["TicketID"].ToString());
                        }
                    }
                }

                lblTicketID.Text = string.Join(", ", ticketIds);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TicketF9_Load_1(object sender, EventArgs e)
        {

        }

        private void picQR_Click(object sender, EventArgs e)
        {

        }
    }
}