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
    public partial class SeatSelectionF5 : Form
    {
        public SeatSelectionF5()
        {
            InitializeComponent();
        }

        private void SeatSelection_Load(object sender, EventArgs e)
        {

        }

       

        private void labelduration_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelmoviename_Click(object sender, EventArgs e)
        {

        }

        private void labelMovie_Click(object sender, EventArgs e)
        {

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
            ShowtimeF4 showtime = new ShowtimeF4();
            showtime.Show();
            this.Hide();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            BookingF6 booking = new BookingF6();
            booking.Show();
            this.Hide();
        }
    }
}
