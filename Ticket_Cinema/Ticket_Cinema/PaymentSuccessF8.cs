using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ticket_Cinema
{
    public partial class PaymentSuccessF8 : Form
    {
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\CinemaData.mdf;
              Integrated Security=True";

        public PaymentSuccessF8()
        {
            InitializeComponent();
            this.Load += PaymentSuccessF8_Load;
        }

        private void PaymentSuccessF8_Load(object sender, EventArgs e)
        {
            LoadPaymentSummary();
        }

        private void LoadPaymentSummary()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // ambik dat Ba se untuk dapatkan booking id, total amount, dan booking date
                string query = @"
                    SELECT TOP 1 BookingID, BookingDate, TotalAmount_RM
                    FROM BOOKING
                    ORDER BY BookingDate DESC, BookingID DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                       //ni booking id je
                        lblBookID.Text = reader["BookingID"].ToString();
                        //tunjuk total amount yang dh bayo
                        decimal amount = Convert.ToDecimal(reader["TotalAmount_RM"]);
                        label6.Text = amount.ToString("0.00");

                       //label date
                        DateTime paymentDate = Convert.ToDateTime(reader["BookingDate"]);
                        lblPDate.Text = paymentDate.ToString("dd-MMM-yyyy");

                       
                        lblPMethod.Text = "Credit / Debit Card";
                    }
                    else
                    {
                        MessageBox.Show("No booking found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            TicketF9 ticket = new TicketF9();
            ticket.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void lblPMethod_Click(object sender, EventArgs e) { }
        private void lblPDate_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
