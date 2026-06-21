namespace Ticket_Cinema
{
    partial class mngSeat
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
            this.txtSeatID = new System.Windows.Forms.TextBox();
            this.uptBtn = new Ticket_Cinema.RoundedButton();
            this.ClearBtn = new Ticket_Cinema.RoundedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new Ticket_Cinema.RoundedButton();
            this.seatDataGridView = new System.Windows.Forms.DataGridView();
            this.seatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataDataSet3 = new Ticket_Cinema.CinemaDataDataSet3();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblHall = new Ticket_Cinema.RoundedButton();
            this.seatTableAdapter = new Ticket_Cinema.CinemaDataDataSet3TableAdapters.SeatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.seatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSeatID
            // 
            this.txtSeatID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeatID.Location = new System.Drawing.Point(789, 300);
            this.txtSeatID.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.txtSeatID.Name = "txtSeatID";
            this.txtSeatID.Size = new System.Drawing.Size(110, 28);
            this.txtSeatID.TabIndex = 58;
            // 
            // uptBtn
            // 
            this.uptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(171)))));
            this.uptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uptBtn.FlatAppearance.BorderSize = 0;
            this.uptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uptBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uptBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.uptBtn.Location = new System.Drawing.Point(1043, 292);
            this.uptBtn.Margin = new System.Windows.Forms.Padding(50, 10, 60, 0);
            this.uptBtn.Name = "uptBtn";
            this.uptBtn.Size = new System.Drawing.Size(160, 49);
            this.uptBtn.TabIndex = 57;
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
            this.ClearBtn.Location = new System.Drawing.Point(1043, 358);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(50, 10, 60, 0);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(160, 49);
            this.ClearBtn.TabIndex = 56;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 30, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 30, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Seat ID:";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.BackBtn.Location = new System.Drawing.Point(1032, 575);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(50, 50, 60, 30);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(160, 49);
            this.BackBtn.TabIndex = 51;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // seatDataGridView
            // 
            this.seatDataGridView.AutoGenerateColumns = false;
            this.seatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seatIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.seatDataGridView.DataSource = this.seatBindingSource;
            this.seatDataGridView.Location = new System.Drawing.Point(59, 231);
            this.seatDataGridView.Margin = new System.Windows.Forms.Padding(50, 50, 3, 50);
            this.seatDataGridView.Name = "seatDataGridView";
            this.seatDataGridView.RowHeadersWidth = 51;
            this.seatDataGridView.RowTemplate.Height = 24;
            this.seatDataGridView.Size = new System.Drawing.Size(555, 204);
            this.seatDataGridView.TabIndex = 50;
            this.seatDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seatDataGridView_CellContentClick);
            // 
            // seatIDDataGridViewTextBoxColumn
            // 
            this.seatIDDataGridViewTextBoxColumn.DataPropertyName = "SeatID";
            this.seatIDDataGridViewTextBoxColumn.HeaderText = "SeatID";
            this.seatIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatIDDataGridViewTextBoxColumn.Name = "seatIDDataGridViewTextBoxColumn";
            this.seatIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // seatBindingSource
            // 
            this.seatBindingSource.DataMember = "Seat";
            this.seatBindingSource.DataSource = this.cinemaDataDataSet3;
            // 
            // cinemaDataDataSet3
            // 
            this.cinemaDataDataSet3.DataSetName = "CinemaDataDataSet3";
            this.cinemaDataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label2.TabIndex = 49;
            this.label2.Text = "MANAGE SEAT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(789, 358);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(110, 28);
            this.txtStatus.TabIndex = 59;
            // 
            // lblHall
            // 
            this.lblHall.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblHall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHall.FlatAppearance.BorderSize = 0;
            this.lblHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHall.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblHall.Location = new System.Drawing.Point(503, 148);
            this.lblHall.Margin = new System.Windows.Forms.Padding(50, 50, 60, 30);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(273, 49);
            this.lblHall.TabIndex = 60;
            this.lblHall.Text = "Hall A";
            this.lblHall.UseVisualStyleBackColor = false;
            // 
            // seatTableAdapter
            // 
            this.seatTableAdapter.ClearBeforeFill = true;
            // 
            // mngSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.lblHall);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtSeatID);
            this.Controls.Add(this.uptBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.seatDataGridView);
            this.Controls.Add(this.label2);
            this.Name = "mngSeat";
            this.Text = "mngSeat";
            this.Load += new System.EventHandler(this.mngSeat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSeatID;
        private RoundedButton uptBtn;
        private RoundedButton ClearBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private RoundedButton BackBtn;
        private System.Windows.Forms.DataGridView seatDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private RoundedButton lblHall;
        private CinemaDataDataSet3 cinemaDataDataSet3;
        private System.Windows.Forms.BindingSource seatBindingSource;
        private CinemaDataDataSet3TableAdapters.SeatTableAdapter seatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}