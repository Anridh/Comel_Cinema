using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Cinema
{
    public partial class AdminPg : Form
    {
        public AdminPg()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            
        }


        private void AdminPg_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            ViewBooking vbook = new ViewBooking();
            vbook.Show();
            this.Hide();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            mngHall hall = new mngHall();
            hall.Show();
            this.Hide();
        }
    }

    public class  RoundedButton:Button
    {
        // Tetapan warna menggunakan kod Hex pilihan anda
        private Color normalBorderColor = ColorTranslator.FromHtml("#f9f9f9");
        private Color hoverBorderColor = ColorTranslator.FromHtml("#e94560");
        private Color normalTextColor = ColorTranslator.FromHtml("#f9f9f9");
        private Color hoverTextColor = ColorTranslator.FromHtml("#e94560");

        private bool isHovering = false;

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0; // Buang border asal

            // Set background butang supaya lutsinar atau sama dengan background form
            this.BackColor = Color.Transparent;
            this.Cursor = Cursors.Hand; // Tukar cursor jadi bentuk tangan
        }

        // Melukis bentuk butang dan border
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Lengkung bucu

            // Melukis 4 bucu melengkung
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius - 1, Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, Height - radius - 1, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path); // Terapkan bentuk kepada butang

            // Lukis warna border
            Pen pen = new Pen(isHovering ? hoverBorderColor : normalBorderColor, 4);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Supaya garisan licin
            e.Graphics.DrawPath(pen, path);

            // Tukar warna tulisan
            this.ForeColor = isHovering ? hoverTextColor : normalTextColor;
        }

        // Kesan apabila mouse masuk (Hover)
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovering = true;
            this.Invalidate(); // Refresh warna
        }

        // Kesan apabila mouse keluar
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovering = false;
            this.Invalidate(); // Kembalikan warna asal
        }
    }
}
