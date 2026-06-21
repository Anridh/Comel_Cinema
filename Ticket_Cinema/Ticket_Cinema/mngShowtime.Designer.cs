namespace Ticket_Cinema
{
    partial class mngShowtime
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
            this.label2 = new System.Windows.Forms.Label();
            this.showtimeDataGridView = new System.Windows.Forms.DataGridView();
            this.showtimeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showtimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataDataSet5 = new Ticket_Cinema.CinemaDataDataSet5();
            this.uptBtn = new Ticket_Cinema.RoundedButton();
            this.ClearBtn = new Ticket_Cinema.RoundedButton();
            this.addBtn = new Ticket_Cinema.RoundedButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new Ticket_Cinema.RoundedButton();
            this.txtShowtimeID = new System.Windows.Forms.TextBox();
            this.showDate = new System.Windows.Forms.DateTimePicker();
            this.showTime = new System.Windows.Forms.DateTimePicker();
            this.showtimeTableAdapter = new Ticket_Cinema.CinemaDataDataSet5TableAdapters.ShowtimeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.showtimeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showtimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataDataSet5)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(1261, 119);
            this.label2.TabIndex = 5;
            this.label2.Text = "MANAGE SHOWTIME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showtimeDataGridView
            // 
            this.showtimeDataGridView.AutoGenerateColumns = false;
            this.showtimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showtimeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.showtimeIDDataGridViewTextBoxColumn,
            this.showDateDataGridViewTextBoxColumn,
            this.showTimeDataGridViewTextBoxColumn,
            this.movieIDDataGridViewTextBoxColumn,
            this.hallIDDataGridViewTextBoxColumn});
            this.showtimeDataGridView.DataSource = this.showtimeBindingSource;
            this.showtimeDataGridView.Location = new System.Drawing.Point(59, 169);
            this.showtimeDataGridView.Margin = new System.Windows.Forms.Padding(50, 50, 3, 50);
            this.showtimeDataGridView.Name = "showtimeDataGridView";
            this.showtimeDataGridView.RowHeadersWidth = 51;
            this.showtimeDataGridView.RowTemplate.Height = 24;
            this.showtimeDataGridView.Size = new System.Drawing.Size(555, 445);
            this.showtimeDataGridView.TabIndex = 6;
            this.showtimeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showtimeDataGridView_CellContentClick);
            // 
            // showtimeIDDataGridViewTextBoxColumn
            // 
            this.showtimeIDDataGridViewTextBoxColumn.DataPropertyName = "ShowtimeID";
            this.showtimeIDDataGridViewTextBoxColumn.HeaderText = "ShowtimeID";
            this.showtimeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.showtimeIDDataGridViewTextBoxColumn.Name = "showtimeIDDataGridViewTextBoxColumn";
            this.showtimeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // showDateDataGridViewTextBoxColumn
            // 
            this.showDateDataGridViewTextBoxColumn.DataPropertyName = "ShowDate";
            this.showDateDataGridViewTextBoxColumn.HeaderText = "ShowDate";
            this.showDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.showDateDataGridViewTextBoxColumn.Name = "showDateDataGridViewTextBoxColumn";
            this.showDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // showTimeDataGridViewTextBoxColumn
            // 
            this.showTimeDataGridViewTextBoxColumn.DataPropertyName = "ShowTime";
            this.showTimeDataGridViewTextBoxColumn.HeaderText = "ShowTime";
            this.showTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.showTimeDataGridViewTextBoxColumn.Name = "showTimeDataGridViewTextBoxColumn";
            this.showTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            this.movieIDDataGridViewTextBoxColumn.DataPropertyName = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.HeaderText = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            this.movieIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // hallIDDataGridViewTextBoxColumn
            // 
            this.hallIDDataGridViewTextBoxColumn.DataPropertyName = "HallID";
            this.hallIDDataGridViewTextBoxColumn.HeaderText = "HallID";
            this.hallIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hallIDDataGridViewTextBoxColumn.Name = "hallIDDataGridViewTextBoxColumn";
            this.hallIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // showtimeBindingSource
            // 
            this.showtimeBindingSource.DataMember = "Showtime";
            this.showtimeBindingSource.DataSource = this.cinemaDataDataSet5;
            // 
            // cinemaDataDataSet5
            // 
            this.cinemaDataDataSet5.DataSetName = "CinemaDataDataSet5";
            this.cinemaDataDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uptBtn
            // 
            this.uptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(171)))));
            this.uptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uptBtn.FlatAppearance.BorderSize = 0;
            this.uptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uptBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uptBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.uptBtn.Location = new System.Drawing.Point(1033, 228);
            this.uptBtn.Margin = new System.Windows.Forms.Padding(50, 10, 60, 0);
            this.uptBtn.Name = "uptBtn";
            this.uptBtn.Size = new System.Drawing.Size(160, 49);
            this.uptBtn.TabIndex = 46;
            this.uptBtn.Text = "Update";
            this.uptBtn.UseVisualStyleBackColor = false;
            this.uptBtn.Click += new System.EventHandler(this.uptBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClearBtn.Location = new System.Drawing.Point(1032, 287);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(50, 10, 60, 0);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(160, 49);
            this.ClearBtn.TabIndex = 45;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.addBtn.Location = new System.Drawing.Point(1032, 169);
            this.addBtn.Margin = new System.Windows.Forms.Padding(50, 10, 60, 0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(160, 49);
            this.addBtn.TabIndex = 43;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(627, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 30, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Show Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(627, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 30, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Show Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(627, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 30, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Showtime ID:";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.BackBtn.Location = new System.Drawing.Point(1032, 585);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(50, 50, 60, 30);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(160, 49);
            this.BackBtn.TabIndex = 36;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // txtShowtimeID
            // 
            this.txtShowtimeID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowtimeID.Location = new System.Drawing.Point(779, 183);
            this.txtShowtimeID.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.txtShowtimeID.Name = "txtShowtimeID";
            this.txtShowtimeID.Size = new System.Drawing.Size(110, 28);
            this.txtShowtimeID.TabIndex = 47;
            // 
            // showDate
            // 
            this.showDate.AllowDrop = true;
            this.showDate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.showDate.Location = new System.Drawing.Point(779, 238);
            this.showDate.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.showDate.MinDate = new System.DateTime(2026, 6, 15, 0, 0, 0, 0);
            this.showDate.Name = "showDate";
            this.showDate.Size = new System.Drawing.Size(146, 28);
            this.showDate.TabIndex = 48;
            // 
            // showTime
            // 
            this.showTime.Checked = false;
            this.showTime.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.showTime.Location = new System.Drawing.Point(779, 287);
            this.showTime.Name = "showTime";
            this.showTime.ShowUpDown = true;
            this.showTime.Size = new System.Drawing.Size(146, 28);
            this.showTime.TabIndex = 49;
            this.showTime.Value = new System.DateTime(2030, 2, 28, 0, 0, 0, 0);
            // 
            // showtimeTableAdapter
            // 
            this.showtimeTableAdapter.ClearBeforeFill = true;
            // 
            // mngShowtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.showTime);
            this.Controls.Add(this.showDate);
            this.Controls.Add(this.txtShowtimeID);
            this.Controls.Add(this.uptBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.showtimeDataGridView);
            this.Controls.Add(this.label2);
            this.Name = "mngShowtime";
            this.Text = "mngShowtime";
            this.Load += new System.EventHandler(this.mngShowtime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showtimeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showtimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView showtimeDataGridView;
        private RoundedButton uptBtn;
        private RoundedButton ClearBtn;
        private RoundedButton addBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private RoundedButton BackBtn;
        private System.Windows.Forms.TextBox txtShowtimeID;
        private System.Windows.Forms.DateTimePicker showDate;
        private System.Windows.Forms.DateTimePicker showTime;
        private CinemaDataDataSet5 cinemaDataDataSet5;
        private System.Windows.Forms.BindingSource showtimeBindingSource;
        private CinemaDataDataSet5TableAdapters.ShowtimeTableAdapter showtimeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn showtimeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn showDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn showTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallIDDataGridViewTextBoxColumn;
    }
}