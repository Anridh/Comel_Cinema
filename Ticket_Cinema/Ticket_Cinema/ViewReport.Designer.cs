namespace Ticket_Cinema
{
    partial class ViewReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartBookingHall = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSeatStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BackBtn = new Ticket_Cinema.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalBooking = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cinemaDataDataSet = new Ticket_Cinema.CinemaDataDataSet();
            this.bookingTableAdapter = new Ticket_Cinema.CinemaDataDataSetTableAdapters.BookingTableAdapter();
            this.tableAdapterManager = new Ticket_Cinema.CinemaDataDataSetTableAdapters.TableAdapterManager();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataDataSet4 = new Ticket_Cinema.CinemaDataDataSet4();
            this.hallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hallTableAdapter = new Ticket_Cinema.CinemaDataDataSet4TableAdapters.HallTableAdapter();
            this.tableAdapterManager1 = new Ticket_Cinema.CinemaDataDataSet4TableAdapters.TableAdapterManager();
            this.cinemaDataDataSet3 = new Ticket_Cinema.CinemaDataDataSet3();
            this.seatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seatTableAdapter = new Ticket_Cinema.CinemaDataDataSet3TableAdapters.SeatTableAdapter();
            this.tableAdapterManager2 = new Ticket_Cinema.CinemaDataDataSet3TableAdapters.TableAdapterManager();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookingHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSeatStatus)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1330, 119);
            this.label2.TabIndex = 6;
            this.label2.Text = "VIEW REPORT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalSales);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(324, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 108);
            this.panel2.TabIndex = 8;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(18, 52);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(62, 38);
            this.lblTotalSales.TabIndex = 1;
            this.lblTotalSales.Text = "RM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "TOTAL SALES";
            // 
            // chartBookingHall
            // 
            chartArea1.AxisX.Title = "HALL NAME";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "CAPACITY SEAT";
            chartArea1.Name = "ChartArea1";
            this.chartBookingHall.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBookingHall.Legends.Add(legend1);
            this.chartBookingHall.Location = new System.Drawing.Point(58, 286);
            this.chartBookingHall.Name = "chartBookingHall";
            this.chartBookingHall.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBookingHall.Series.Add(series1);
            this.chartBookingHall.Size = new System.Drawing.Size(462, 375);
            this.chartBookingHall.TabIndex = 9;
            this.chartBookingHall.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Hall Capacity Report";
            this.chartBookingHall.Titles.Add(title1);
            // 
            // chartSeatStatus
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSeatStatus.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartSeatStatus.Legends.Add(legend2);
            this.chartSeatStatus.Location = new System.Drawing.Point(593, 155);
            this.chartSeatStatus.Name = "chartSeatStatus";
            this.chartSeatStatus.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.CustomProperties = "PieLabelStyle=Outside";
            series2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSeatStatus.Series.Add(series2);
            this.chartSeatStatus.Size = new System.Drawing.Size(607, 448);
            this.chartSeatStatus.TabIndex = 10;
            this.chartSeatStatus.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Seat Status Distribution";
            this.chartSeatStatus.Titles.Add(title2);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.BackBtn.Location = new System.Drawing.Point(970, 627);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(50, 50, 60, 30);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(160, 49);
            this.BackBtn.TabIndex = 37;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL BOOKING";
            // 
            // lblTotalBooking
            // 
            this.lblTotalBooking.AutoSize = true;
            this.lblTotalBooking.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBooking.Location = new System.Drawing.Point(88, 52);
            this.lblTotalBooking.Name = "lblTotalBooking";
            this.lblTotalBooking.Size = new System.Drawing.Size(28, 38);
            this.lblTotalBooking.TabIndex = 1;
            this.lblTotalBooking.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTotalBooking);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(58, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 108);
            this.panel1.TabIndex = 7;
            // 
            // cinemaDataDataSet
            // 
            this.cinemaDataDataSet.DataSetName = "CinemaDataDataSet";
            this.cinemaDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = this.bookingTableAdapter;
            this.tableAdapterManager.UpdateOrder = Ticket_Cinema.CinemaDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.cinemaDataDataSet;
            // 
            // cinemaDataDataSet4
            // 
            this.cinemaDataDataSet4.DataSetName = "CinemaDataDataSet4";
            this.cinemaDataDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hallBindingSource
            // 
            this.hallBindingSource.DataMember = "Hall";
            this.hallBindingSource.DataSource = this.cinemaDataDataSet4;
            // 
            // hallTableAdapter
            // 
            this.hallTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.HallTableAdapter = this.hallTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Ticket_Cinema.CinemaDataDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cinemaDataDataSet3
            // 
            this.cinemaDataDataSet3.DataSetName = "CinemaDataDataSet3";
            this.cinemaDataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seatBindingSource
            // 
            this.seatBindingSource.DataMember = "Seat";
            this.seatBindingSource.DataSource = this.cinemaDataDataSet3;
            // 
            // seatTableAdapter
            // 
            this.seatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.SeatTableAdapter = this.seatTableAdapter;
            this.tableAdapterManager2.UpdateOrder = Ticket_Cinema.CinemaDataDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1330, 681);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.chartSeatStatus);
            this.Controls.Add(this.chartBookingHall);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "ViewReport";
            this.Text = "ViewReport";
            this.Load += new System.EventHandler(this.ViewReport_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookingHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSeatStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBookingHall;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSeatStatus;
        private RoundedButton BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalBooking;
        private System.Windows.Forms.Panel panel1;
        private CinemaDataDataSet cinemaDataDataSet;
        private CinemaDataDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private CinemaDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private CinemaDataDataSet4 cinemaDataDataSet4;
        private System.Windows.Forms.BindingSource hallBindingSource;
        private CinemaDataDataSet4TableAdapters.HallTableAdapter hallTableAdapter;
        private CinemaDataDataSet4TableAdapters.TableAdapterManager tableAdapterManager1;
        private CinemaDataDataSet3 cinemaDataDataSet3;
        private System.Windows.Forms.BindingSource seatBindingSource;
        private CinemaDataDataSet3TableAdapters.SeatTableAdapter seatTableAdapter;
        private CinemaDataDataSet3TableAdapters.TableAdapterManager tableAdapterManager2;
    }
}