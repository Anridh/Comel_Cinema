namespace Ticket_Cinema
{
    partial class ShowtimeF4
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
            this.labelMovie = new System.Windows.Forms.Label();
            this.labelmoviename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelrating = new System.Windows.Forms.Label();
            this.labellanguage = new System.Windows.Forms.Label();
            this.labelgenre = new System.Windows.Forms.Label();
            this.labelduration = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMovie
            // 
            this.labelMovie.AutoSize = true;
            this.labelMovie.BackColor = System.Drawing.Color.Transparent;
            this.labelMovie.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMovie.Location = new System.Drawing.Point(332, 36);
            this.labelMovie.Name = "labelMovie";
            this.labelMovie.Size = new System.Drawing.Size(141, 52);
            this.labelMovie.TabIndex = 1;
            this.labelMovie.Text = "Movie";
            // 
            // labelmoviename
            // 
            this.labelmoviename.AutoSize = true;
            this.labelmoviename.BackColor = System.Drawing.Color.Transparent;
            this.labelmoviename.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmoviename.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelmoviename.Location = new System.Drawing.Point(335, 88);
            this.labelmoviename.Name = "labelmoviename";
            this.labelmoviename.Size = new System.Drawing.Size(247, 35);
            this.labelmoviename.TabIndex = 2;
            this.labelmoviename.Text = "labelmoviename";
            this.labelmoviename.Click += new System.EventHandler(this.labelmoviename_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(336, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Duration :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(336, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Genre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(336, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Language :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(336, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rating :";
            // 
            // labelrating
            // 
            this.labelrating.AutoSize = true;
            this.labelrating.BackColor = System.Drawing.Color.Transparent;
            this.labelrating.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrating.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelrating.Location = new System.Drawing.Point(457, 250);
            this.labelrating.Name = "labelrating";
            this.labelrating.Size = new System.Drawing.Size(84, 22);
            this.labelrating.TabIndex = 10;
            this.labelrating.Text = "labelrating";
            this.labelrating.Click += new System.EventHandler(this.labelrating_Click);
            // 
            // labellanguage
            // 
            this.labellanguage.AutoSize = true;
            this.labellanguage.BackColor = System.Drawing.Color.Transparent;
            this.labellanguage.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellanguage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labellanguage.Location = new System.Drawing.Point(457, 219);
            this.labellanguage.Name = "labellanguage";
            this.labellanguage.Size = new System.Drawing.Size(107, 22);
            this.labellanguage.TabIndex = 9;
            this.labellanguage.Text = "labellanguage";
            this.labellanguage.Click += new System.EventHandler(this.labellanguage_Click);
            // 
            // labelgenre
            // 
            this.labelgenre.AutoSize = true;
            this.labelgenre.BackColor = System.Drawing.Color.Transparent;
            this.labelgenre.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgenre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelgenre.Location = new System.Drawing.Point(457, 188);
            this.labelgenre.Name = "labelgenre";
            this.labelgenre.Size = new System.Drawing.Size(83, 22);
            this.labelgenre.TabIndex = 8;
            this.labelgenre.Text = "labelgenre";
            // 
            // labelduration
            // 
            this.labelduration.AutoSize = true;
            this.labelduration.BackColor = System.Drawing.Color.Transparent;
            this.labelduration.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelduration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelduration.Location = new System.Drawing.Point(457, 157);
            this.labelduration.Name = "labelduration";
            this.labelduration.Size = new System.Drawing.Size(102, 22);
            this.labelduration.TabIndex = 7;
            this.labelduration.Text = "labelduration";
            this.labelduration.Click += new System.EventHandler(this.labelduration_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 121);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(71, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 290);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(565, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Minute";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.button1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(71, 564);
            this.button1.Margin = new System.Windows.Forms.Padding(100, 2, 29, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowtimeF4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Ticket_Cinema.Properties.Resources.homeBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelrating);
            this.Controls.Add(this.labellanguage);
            this.Controls.Add(this.labelgenre);
            this.Controls.Add(this.labelduration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelmoviename);
            this.Controls.Add(this.labelMovie);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShowtimeF4";
            this.Text = "Showtime";
            this.Load += new System.EventHandler(this.ShowtimeF4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMovie;
        private System.Windows.Forms.Label labelmoviename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelrating;
        private System.Windows.Forms.Label labellanguage;
        private System.Windows.Forms.Label labelgenre;
        private System.Windows.Forms.Label labelduration;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}