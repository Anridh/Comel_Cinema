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
           //ni pun ambik dari variable
            if (string.IsNullOrEmpty(BookingSession.BookingId))
            {
                MessageBox.Show("No booking found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // booking id
            lblBookID.Text = BookingSession.BookingId;

            // total amount yang dh bayo
            label6.Text = BookingSession.TotalAmount.ToString("0.00");

            //guna tarikh harini
            lblPDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");

            lblPMethod.Text = "Credit / Debit Card";
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

