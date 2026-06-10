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
    public partial class SignupF1 : Form
    {
        public SignupF1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20; // Nilai radius mesti SAMA dengan nilai di Form_Load tadi
            int borderThickness = 3; // Ketebalan garisan border (dalam piksel)
            Color borderColor = Color.White; // Anda boleh tukar warna border di sini (cth: Gray, White, Gold)

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath())
            {
                gp.AddArc(0, 0, radius, radius, 180, 90);
                gp.AddArc(panel1.Width - radius, 0, radius, radius, 270, 90);
                gp.AddArc(panel1.Width - radius, panel1.Height - radius, radius, radius, 0, 90);
                gp.AddArc(0, panel1.Height - radius, radius, radius, 90, 90);
                gp.CloseFigure();

                using (Pen pen = new Pen(borderColor, borderThickness))
                {
                    e.Graphics.DrawPath(pen, gp);
                }
            }

        }
        private void BucuPanel(Panel pnl, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, pnl.Height - radius, radius, radius, 90, 90);
            pnl.Region = new Region(gp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BucuPanel(panel1, 20);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
