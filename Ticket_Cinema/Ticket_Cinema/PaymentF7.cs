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
    public partial class PaymentF7 : Form
    {
        //ambik dato dato
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\CinemaData.mdf;
              Integrated Security=True";

        private string bookingId = "";
        private decimal totalAmount = 0;

        public PaymentF7()
        {
            InitializeComponent();
            this.Load += PaymentF7_Load;
        }

        private void PaymentF7_Load(object sender, EventArgs e)
        {
            LoadBookingSummary();
        }

        private void LoadBookingSummary()
            //gini untuk ambik daterrr daterr jugakkk
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT TOP 1 BookingID, TotalAmount_RM
                    FROM BOOKING
                    ORDER BY BookingDate DESC, BookingID DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //kat sini untuk tunjuk daterrrr daterrr ke tumpat yang sepatutnye
                        bookingId = reader["BookingID"].ToString();
                        totalAmount = Convert.ToDecimal(reader["TotalAmount_RM"]);

                        label6.Text = bookingId;

                        label8.Text = totalAmount.ToString("0.00");
                    }
                    else
                    {
                        MessageBox.Show("No booking found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bttnPay_Click(object sender, EventArgs e)
        {
            string cardholderName = cardNameTB.Text.Trim();
            string cardNumber = cardNumberTB.Text.Trim();
            string expMonth = textBox3.Text.Trim();
            string expYear = textBox4.Text.Trim();
            string cvc = textBox5.Text.Trim();

            if (string.IsNullOrEmpty(cardholderName))
            {
                MessageBox.Show("Please enter the cardholder name.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cardNumber.Length != 16 || !long.TryParse(cardNumber, out _))
            {
                MessageBox.Show("Card number must be 16 digits.", "Invalid Card", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(expMonth, out int month) || month < 1 || month > 12)
            {
                MessageBox.Show("Enter a valid expiration month (01-12).", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (expYear.Length != 2 || !int.TryParse(expYear, out _))
            {
                MessageBox.Show("Enter a valid 2-digit expiration year.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cvc.Length != 3 || !int.TryParse(cvc, out _))
            {
                MessageBox.Show("Security code must be 3 digits.", "Invalid CVC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Payment successful! Generating your ticket...",
                "Payment Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            PaymentSuccessF8 success = new PaymentSuccessF8();
            success.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingF6 booking = new BookingF6();
            booking.Show();
            this.Close();
        }

        private void cardNameTB_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void cardNumberTB_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click_2(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }

        private void PaymentF7_Load_1(object sender, EventArgs e)
        {
            BgBrightness();
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
                        g.FillRectangle(brush, 0, 0, bggelap.Width,bggelap.Height);
                    }
                }
                this.BackgroundImage = bggelap;
            }
            

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}

