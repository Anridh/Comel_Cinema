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
    public partial class mngSeat : Form
    {
        public mngSeat()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminPg adminPg = new AdminPg();
            adminPg.Show();
            this.Hide();
        }

        private void mngSeat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cinemaDataDataSet3.Seat' table. You can move, or remove it, as needed.
            this.seatTableAdapter.Fill(this.cinemaDataDataSet3.Seat);

        }

        private void seatDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSeatID.Text = seatDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtStatus.Text = seatDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtSeatID.Clear();
            txtStatus.Clear();

            txtSeatID.Focus();
        }

        private void uptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                seatDataGridView.CurrentRow.Cells[1].Value = txtStatus.Text;

                seatBindingSource.EndEdit();
                seatTableAdapter.Update(cinemaDataDataSet3.Seat);

                MessageBox.Show("Seat updated successfully!");

                this.seatTableAdapter.Fill(this.cinemaDataDataSet3.Seat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
