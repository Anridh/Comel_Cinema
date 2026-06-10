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
    public partial class BookingListF10 : Form
    {
        public BookingListF10()
        {
            InitializeComponent();
        }

        private void BookingList_Load(object sender, EventArgs e)
        {
            dgvBookingList.Rows.Add(
                "BKG20260525001",
                "Avengers Endgame",
                "25 May 2026 08:00 PM",
                "Hall 1",
                "A2",
                "RM 20.00",
                "Completed",
                "View"
            );

            dgvBookingList.Rows.Add(
                "BKG20260520002",
                "The Dark Knight",
                "20 May 2026 04:00 PM",
                "Hall 2",
                "C5",
                "RM 20.00",
                "Completed",
                "View"
            );

            foreach (DataGridViewRow row in dgvBookingList.Rows)
            {
                if (row.Cells["Status"].Value != null &&
                    row.Cells["Status"].Value.ToString() == "Completed")
                {
                    row.Cells["Status"].Style.ForeColor = Color.Green;
                    row.Cells["Status"].Style.Font =
                        new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }
    }
}
