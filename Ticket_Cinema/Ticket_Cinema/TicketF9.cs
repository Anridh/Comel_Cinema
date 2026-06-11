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
    public partial class TicketF9 : Form
    {
        public TicketF9()
        {
            InitializeComponent();
        }

        private void lblHall_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewbBtn_Click(object sender, EventArgs e)
        {
            BookingListF10 bookingListForm = new BookingListF10();
            bookingListForm.Show();
            this.Hide();
        }
    }
}
