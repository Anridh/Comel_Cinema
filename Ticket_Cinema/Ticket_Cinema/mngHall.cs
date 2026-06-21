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
    public partial class mngHall : Form
    {
        public mngHall()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminPg adminPg = new AdminPg();
            adminPg.Show();
            this.Close();
        }

        private void mngHall_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cinemaDataDataSet4.Hall' table. You can move, or remove it, as needed.
            this.hallTableAdapter.Fill(this.cinemaDataDataSet4.Hall);

        }

        private void hallDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHallID.Text = hallDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtHallName.Text = hallDataGridView.CurrentRow.Cells[1].Value.ToString();
            numCapacity.Value = Convert.ToDecimal(hallDataGridView.CurrentRow.Cells[2].Value);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtHallID.Clear();
            txtHallName.Clear();
            numCapacity.Value = 0;
        }

        private void uptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                hallDataGridView.CurrentRow.Cells[1].Value = txtHallName.Text;
                hallDataGridView.CurrentRow.Cells[2].Value = numCapacity.Value;

                hallBindingSource.EndEdit();
                hallTableAdapter.Update(cinemaDataDataSet4.Hall);

                MessageBox.Show("Hall updated successfully!");

                this.hallTableAdapter.Fill(this.cinemaDataDataSet4.Hall);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = cinemaDataDataSet4.Hall.NewRow();

                newRow["HallID"] = txtHallID.Text;
                newRow["HallName"] = txtHallName.Text;
                newRow["Capacity_Seat"] = numCapacity.Value;

                cinemaDataDataSet4.Hall.Rows.Add(newRow);

                hallTableAdapter.Update(cinemaDataDataSet4.Hall);

                MessageBox.Show("Hall added successfully!");

                this.hallTableAdapter.Fill(this.cinemaDataDataSet4.Hall);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                hallBindingSource.RemoveCurrent();

                hallBindingSource.EndEdit();
                hallTableAdapter.Update(cinemaDataDataSet4.Hall);

                MessageBox.Show("Hall deleted successfully!");

                this.hallTableAdapter.Fill(this.cinemaDataDataSet4.Hall);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
