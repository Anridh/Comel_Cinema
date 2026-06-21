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
    public partial class ViewReport : Form
    {
        public ViewReport()
        {
            InitializeComponent();
        }

        private void bookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void bookingBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cinemaDataDataSet);

        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
            this.seatTableAdapter.Fill(this.cinemaDataDataSet3.Seat);
            this.hallTableAdapter.Fill(this.cinemaDataDataSet4.Hall);
            this.bookingTableAdapter.Fill(this.cinemaDataDataSet.Booking);

            // Total Booking
            lblTotalBooking.Text =
                cinemaDataDataSet.Booking.Rows.Count.ToString();

            // Total Sales
            decimal totalSales = 0;

            foreach (DataRow row in cinemaDataDataSet.Booking.Rows)
            {
                totalSales += Convert.ToDecimal(row["TotalAmount_RM"]);
            }

            lblTotalSales.Text = "RM " + totalSales.ToString("N2");

            // Hall Capacity Chart
            chartBookingHall.Series["Series1"].Points.Clear();

            foreach (DataRow row in cinemaDataDataSet4.Hall.Rows)
            {
                chartBookingHall.Series["Series1"].Points.AddXY(
                    row["HallName"].ToString(),
                    Convert.ToInt32(row["Capacity_Seat"])
                );
            }

            chartBookingHall.Series["Series1"].Points[0].Color = Color.MidnightBlue;
            chartBookingHall.Series["Series1"].Points[1].Color = Color.SteelBlue;
            chartBookingHall.Series["Series1"].Points[2].Color = Color.Goldenrod;

            chartBookingHall.Series["Series1"].IsValueShownAsLabel = true;
            chartBookingHall.Series["Series1"].IsVisibleInLegend = false;

            // Seat Status Chart
            int available = 0;
            int booked = 0;
            int maintenance = 0;

            foreach (DataRow row in cinemaDataDataSet3.Seat.Rows)
            {
                string status = row["Status"].ToString();

                if (status == "Available")
                    available++;
                else if (status == "Booked")
                    booked++;
                else if (status == "Maintenance")
                    maintenance++;
            }

            chartSeatStatus.Series["Series1"].Points.Clear();

            chartSeatStatus.Series["Series1"].Points.AddXY("Available", available);
            chartSeatStatus.Series["Series1"].Points.AddXY("Booked", booked);
            chartSeatStatus.Series["Series1"].Points.AddXY("Maintenance", maintenance);

            chartSeatStatus.Series["Series1"].IsValueShownAsLabel = true;
            chartSeatStatus.Series["Series1"].Label = "#VALX\n#VAL";
            chartSeatStatus.Series["Series1"]["PieLabelStyle"] = "Outside";
            chartSeatStatus.Series["Series1"]["DoughnutRadius"] = "99";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminPg adminPg = new AdminPg();
            adminPg.Show();
            this.Hide();
        }
    }
}
