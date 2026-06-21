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
    public partial class ViewBooking : Form
    {
        public ViewBooking()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminPg adminPg = new AdminPg();
            adminPg.Show();
            this.Close();
        }

        private void ViewBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cinemaDataDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.cinemaDataDataSet.Booking);

            int totalBooking = bookingDataGridView.Rows.Count - 1;
            double totalSales = 0;

            foreach (DataGridViewRow row in bookingDataGridView.Rows)
            {
                if (row.Cells["totalAmountRMDataGridViewTextBoxColumn"].Value != null)
                {
                    totalSales += Convert.ToDouble(row.Cells["totalAmountRMDataGridViewTextBoxColumn"].Value);
                }
            }

            lbltotalbooking.Text = totalBooking.ToString();
            lblsales.Text = "RM " + totalSales.ToString("N2");

        }

        private void lbltotalbooking_Click(object sender, EventArgs e)
        {

        }
    }
}
