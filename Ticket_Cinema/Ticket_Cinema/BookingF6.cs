using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Cinema
{
    public partial class BookingF6 : Form
    {
        public BookingF6()
        {
            InitializeComponent();
        }

        private void buttonConfirmBooking_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            SeatSelectionF5 seatSelection = new SeatSelectionF5();
            seatSelection.Show();
            this.Hide();
        }
    }
}
