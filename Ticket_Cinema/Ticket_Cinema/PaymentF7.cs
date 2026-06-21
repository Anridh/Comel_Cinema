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
    public partial class PaymentF7 : Form
    {
        public PaymentF7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bttnPay_Click(object sender, EventArgs e)
        {
            PaymentSuccessF8 paymentSuccessF8 = new PaymentSuccessF8();
            paymentSuccessF8.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cardNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PaymentF7_Load(object sender, EventArgs e)
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
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(140, 0, 0, 0)))
                    {
                        g.FillRectangle(brush, 0, 0, bggelap.Width, bggelap.Height);
                    }
                }
                this.BackgroundImage = bggelap;
             
            }
        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookingF6 bookingF6 = new BookingF6();
            bookingF6.Show();
            this.Hide();
        }
    }
}
