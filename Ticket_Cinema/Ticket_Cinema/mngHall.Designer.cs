namespace Ticket_Cinema
{
    partial class mngHall
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
            this.hallDataGridView = new System.Windows.Forms.DataGridView();
            this.hallIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacitySeatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataDataSet4 = new Ticket_Cinema.CinemaDataDataSet4();
            this.BackBtn = new Ticket_Cinema.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHallID = new System.Windows.Forms.TextBox();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.txtHallName = new System.Windows.Forms.TextBox();
            this.addBtn = new Ticket_Cinema.RoundedButton();
            this.ClearBtn = new Ticket_Cinema.RoundedButton();
            this.uptBtn = new Ticket_Cinema.RoundedButton();
            this.hallTableAdapter = new Ticket_Cinema.CinemaDataDataSet4TableAdapters.HallTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hallDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
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
            this.label2.TabIndex = 4;
            this.label2.Text = "MANAGE HALL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hallDataGridView
            // 
            this.hallDataGridView.AutoGenerateColumns = false;
            this.hallDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hallDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hallIDDataGridViewTextBoxColumn,
            this.hallNameDataGridViewTextBoxColumn,
            this.capacitySeatDataGridViewTextBoxColumn});
            this.hallDataGridView.DataSource = this.hallBindingSource;
            this.hallDataGridView.Location = new System.Drawing.Point(59, 169);
            this.hallDataGridView.Margin = new System.Windows.Forms.Padding(50, 50, 3, 50);
            this.hallDataGridView.Name = "hallDataGridView";
            this.hallDataGridView.RowHeadersWidth = 51;
            this.hallDataGridView.RowTemplate.Height = 24;
            this.hallDataGridView.Size = new System.Drawing.Size(555, 445);
            this.hallDataGridView.TabIndex = 5;
            this.hallDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hallDataGridView_CellContentClick);
            // 
            // hallIDDataGridViewTextBoxColumn
            // 
            this.hallIDDataGridViewTextBoxColumn.DataPropertyName = "HallID";
            this.hallIDDataGridViewTextBoxColumn.HeaderText = "HallID";
            this.hallIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hallIDDataGridViewTextBoxColumn.Name = "hallIDDataGridViewTextBoxColumn";
            this.hallIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // hallNameDataGridViewTextBoxColumn
            // 
            this.hallNameDataGridViewTextBoxColumn.DataPropertyName = "HallName";
            this.hallNameDataGridViewTextBoxColumn.HeaderText = "HallName";
            this.hallNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hallNameDataGridViewTextBoxColumn.Name = "hallNameDataGridViewTextBoxColumn";
            this.hallNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacitySeatDataGridViewTextBoxColumn
            // 
            this.capacitySeatDataGridViewTextBoxColumn.DataPropertyName = "Capacity_Seat";
            this.capacitySeatDataGridViewTextBoxColumn.HeaderText = "Capacity_Seat";
            this.capacitySeatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacitySeatDataGridViewTextBoxColumn.Name = "capacitySeatDataGridViewTextBoxColumn";
            this.capacitySeatDataGridViewTextBoxColumn.Width = 125;
            // 
            // hallBindingSource
            // 
            this.hallBindingSource.DataMember = "Hall";
            this.hallBindingSource.DataSource = this.cinemaDataDataSet4;
            // 
            // cinemaDataDataSet4
            // 
            this.cinemaDataDataSet4.DataSetName = "CinemaDataDataSet4";
            this.cinemaDataDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.BackBtn.TabIndex = 25;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(627, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 30, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Hall ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(627, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 30, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hall Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(627, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 30, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Capacity Seat:";
            // 
            // txtHallID
            // 
            this.txtHallID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHallID.Location = new System.Drawing.Point(792, 183);
            this.txtHallID.Name = "txtHallID";
            this.txtHallID.Size = new System.Drawing.Size(94, 28);
            this.txtHallID.TabIndex = 29;
            // 
            // numCapacity
            // 
            this.numCapacity.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCapacity.Location = new System.Drawing.Point(792, 291);
            this.numCapacity.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(94, 28);
            this.numCapacity.TabIndex = 30;
            // 
            // txtHallName
            // 
            this.txtHallName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHallName.Location = new System.Drawing.Point(792, 237);
            this.txtHallName.Name = "txtHallName";
            this.txtHallName.Size = new System.Drawing.Size(184, 28);
            this.txtHallName.TabIndex = 31;
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
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClearBtn.Location = new System.Drawing.Point(1032, 335);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(50, 10, 60, 0);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(160, 49);
            this.ClearBtn.TabIndex = 34;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
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
            this.uptBtn.TabIndex = 35;
            this.uptBtn.Text = "Update";
            this.uptBtn.UseVisualStyleBackColor = false;
            this.uptBtn.Click += new System.EventHandler(this.uptBtn_Click);
            // 
            // hallTableAdapter
            // 
            this.hallTableAdapter.ClearBeforeFill = true;
            // 
            // mngHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.uptBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.txtHallName);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.txtHallID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.hallDataGridView);
            this.Controls.Add(this.label2);
            this.Name = "mngHall";
            this.Text = "mngHall";
            this.Load += new System.EventHandler(this.mngHall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hallDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView hallDataGridView;
        private RoundedButton BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHallID;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.TextBox txtHallName;
        private RoundedButton addBtn;
        private RoundedButton ClearBtn;
        private RoundedButton uptBtn;
        private CinemaDataDataSet4 cinemaDataDataSet4;
        private System.Windows.Forms.BindingSource hallBindingSource;
        private CinemaDataDataSet4TableAdapters.HallTableAdapter hallTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacitySeatDataGridViewTextBoxColumn;
    }
}