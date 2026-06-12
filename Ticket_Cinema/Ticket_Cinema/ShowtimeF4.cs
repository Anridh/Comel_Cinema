using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ticket_Cinema.HomeForm;

namespace Ticket_Cinema
{
    public partial class ShowtimeF4 : Form
    {
        private string movieId;
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\CinemaData.mdf;
              Integrated Security=True";
        

        public ShowtimeF4(string selectedMovieId)
        {
            InitializeComponent();
            movieId = selectedMovieId;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            
        }
        private void ShowtimeF4_Load(object sender, EventArgs e)
        {
          
            // Pastikan movieId tidak kosong sebelum cari data
            if (!string.IsNullOrEmpty(movieId))
            {
                LoadShowtimes();
                LoadMovieDetails();
                
            }
        }
        private void LoadShowtimes()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
SELECT
    s.ShowtimeID,
    s.ShowDate,
    s.ShowTime,
    h.HallName,
    h.Capacity_Seat
FROM Showtime s
INNER JOIN Hall h
    ON s.HallID = h.HallID
WHERE s.MovieID = @MovieID";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MovieID", movieId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
              

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No showtimes found.");
                    return;
                }
                dataGridView1.DataSource = dt;
            }

            // Hide ShowtimeID
            dataGridView1.Columns["ShowtimeID"].Visible = false;
            dataGridView1.Columns["ShowDate"].HeaderText = "Show Date";
            dataGridView1.Columns["ShowTime"].HeaderText = "Show Time";
            dataGridView1.Columns["HallName"].HeaderText = "Hall";
            dataGridView1.Columns["Capacity_Seat"].HeaderText = "Capacity";

            if (!dataGridView1.Columns.Contains("Select"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                btn.Name = "Select";
                btn.HeaderText = "Action";
                btn.Text = "Select";
                btn.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(btn);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name != "Select")
                return;

            string showtimeId = dataGridView1.Rows[e.RowIndex]
                .Cells["ShowtimeID"].Value.ToString();

            // 🔴 Prevent double opening
            dataGridView1.Enabled = false;

            SeatSelectionF5 seat = new SeatSelectionF5(showtimeId, movieId);
            seat.FormClosed += (s, args) => dataGridView1.Enabled = true;

            seat.Show();
            this.Hide();
        }
        private void LoadMovieDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Movie WHERE MovieID = @MovieID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MovieID", movieId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    labelmoviename.Text = reader["Title"].ToString();
                    labelgenre.Text = reader["Genre"].ToString();
                    labelduration.Text = reader["Duration_Minute"].ToString();
                    labellanguage.Text = reader["Language"].ToString();
                    labelrating.Text = reader["Rating"].ToString();

                    switch (movieId)
                    {
                        case "M001":
                            pictureBox1.Image = Properties.Resources.pic1;
                            break;

                        case "M002":
                            pictureBox1.Image = Properties.Resources.pic2;
                            break;

                        case "M003":
                            pictureBox1.Image = Properties.Resources.pic3;
                            break;

                        case "M004":
                            pictureBox1.Image = Properties.Resources.pic4;
                            break;

                        case "M005":
                            pictureBox1.Image = Properties.Resources.pic5;
                            break;

                        case "M006":
                            pictureBox1.Image = Properties.Resources.pic6;
                            break;
                    }

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
