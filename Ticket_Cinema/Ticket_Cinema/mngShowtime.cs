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
    public partial class mngShowtime : Form
    {
        public mngShowtime()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminPg adminPg = new AdminPg();
            adminPg.Show();
            this.Hide();
        }

        private void mngShowtime_Load(object sender, EventArgs e)
        {
            // Menampilkan data saat form pertama kali dimuat
            this.showtimeTableAdapter.Fill(this.cinemaDataDataSet5.Showtime);
        }

        private void showtimeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mengambil data dari baris yang diklik dan menampilkannya ke TextBox / DateTimePicker
            // Pastikan indeks Cells[] sesuai dengan urutan kolom di database/DataGridView Anda
            txtShowtimeID.Text = showtimeDataGridView.CurrentRow.Cells[0].Value.ToString();
            showDate.Value = Convert.ToDateTime(showtimeDataGridView.CurrentRow.Cells[1].Value);
            showTime.Value = Convert.ToDateTime(showtimeDataGridView.CurrentRow.Cells[2].Value);

            // Tambahan untuk MovieID dan HallID (Sesuaikan indeks 3 dan 4 jika posisinya berbeda)
            txtMovieID.Text = showtimeDataGridView.CurrentRow.Cells[3].Value.ToString();
            txtHallID.Text = showtimeDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Mengosongkan semua inputan
            txtShowtimeID.Clear();
            txtMovieID.Clear(); // Tambahan
            txtHallID.Clear();  // Tambahan
            showDate.Value = DateTime.Now;
            showTime.Value = DateTime.Now;
        }

        private void uptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Memperbarui nilai pada baris yang sedang aktif
                showtimeDataGridView.CurrentRow.Cells[1].Value = showDate.Value.Date;
                showtimeDataGridView.CurrentRow.Cells[2].Value = showTime.Value;

                // Tambahan update untuk MovieID dan HallID
                showtimeDataGridView.CurrentRow.Cells[3].Value = txtMovieID.Text;
                showtimeDataGridView.CurrentRow.Cells[4].Value = txtHallID.Text;

                showtimeBindingSource.EndEdit();
                showtimeTableAdapter.Update(cinemaDataDataSet5.Showtime);

                MessageBox.Show("Showtime updated successfully!");

                this.showtimeTableAdapter.Fill(this.cinemaDataDataSet5.Showtime);
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
                DataRow newRow = cinemaDataDataSet5.Showtime.NewRow();

                newRow["ShowtimeID"] = txtShowtimeID.Text;
                newRow["ShowDate"] = showDate.Value.Date;
                newRow["ShowTime"] = showTime.Value;

                // Tambahan insert untuk MovieID dan HallID (Sesuaikan nama kolom dengan database Anda)
                newRow["MovieID"] = txtMovieID.Text;
                newRow["HallID"] = txtHallID.Text;

                cinemaDataDataSet5.Showtime.Rows.Add(newRow);

                showtimeTableAdapter.Update(cinemaDataDataSet5.Showtime);

                MessageBox.Show("Showtime added successfully!");

                this.showtimeTableAdapter.Fill(this.cinemaDataDataSet5.Showtime);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     
        // Event text_changed bisa dibiarkan kosong jika tidak ada logika validasi khusus saat mengetik
        private void txtMovieID_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtHallID_TextChanged(object sender, EventArgs e)
        {
        }
    }
}