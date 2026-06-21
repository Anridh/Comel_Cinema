using System;

namespace Ticket_Cinema
{
    partial class BookingF6
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
            this.labelbooking = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.textBoxTicketPrice = new System.Windows.Forms.TextBox();
            this.textBoxSeatNumber = new System.Windows.Forms.TextBox();
            this.textBoxCinemaHall = new System.Windows.Forms.TextBox();
            this.textBoxShowtime = new System.Windows.Forms.TextBox();
            this.textBoxMovie = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bttnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelbooking
            // 
            this.labelbooking.AutoSize = true;
            this.labelbooking.BackColor = System.Drawing.Color.Transparent;
            this.labelbooking.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelbooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelbooking.Location = new System.Drawing.Point(62, 23);
            this.labelbooking.Name = "labelbooking";
            this.labelbooking.Size = new System.Drawing.Size(305, 46);
            this.labelbooking.TabIndex = 0;
            this.labelbooking.Text = "Booking Details";
            this.labelbooking.Click += new System.EventHandler(this.labelbooking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(81, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(81, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 27, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(81, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 27, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Movie :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(81, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 27, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Showtime :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(81, 307);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 27, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cinema Hall :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(81, 361);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 27, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Seat Number :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(236, 547);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(81, 469);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 27, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 33);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total Amount :";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCustomerName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxCustomerName.Location = new System.Drawing.Point(358, 92);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(459, 34);
            this.textBoxCustomerName.TabIndex = 9;
            this.textBoxCustomerName.TextChanged += new System.EventHandler(this.textBoxCustomerName_TextChanged);
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmount.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxTotalAmount.Location = new System.Drawing.Point(358, 470);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(459, 34);
            this.textBoxTotalAmount.TabIndex = 10;
            this.textBoxTotalAmount.TextChanged += new System.EventHandler(this.textBoxTotalAmount_TextChanged);
            // 
            // textBoxTicketPrice
            // 
            this.textBoxTicketPrice.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTicketPrice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTicketPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxTicketPrice.Location = new System.Drawing.Point(358, 414);
            this.textBoxTicketPrice.Name = "textBoxTicketPrice";
            this.textBoxTicketPrice.Size = new System.Drawing.Size(459, 34);
            this.textBoxTicketPrice.TabIndex = 11;
            this.textBoxTicketPrice.TextChanged += new System.EventHandler(this.textBoxTicketPrice_TextChanged);
            // 
            // textBoxSeatNumber
            // 
            this.textBoxSeatNumber.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSeatNumber.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSeatNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSeatNumber.Location = new System.Drawing.Point(358, 362);
            this.textBoxSeatNumber.Name = "textBoxSeatNumber";
            this.textBoxSeatNumber.Size = new System.Drawing.Size(459, 34);
            this.textBoxSeatNumber.TabIndex = 12;
            this.textBoxSeatNumber.TextChanged += new System.EventHandler(this.textBoxSeatNumber_TextChanged);
            // 
            // textBoxCinemaHall
            // 
            this.textBoxCinemaHall.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCinemaHall.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCinemaHall.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxCinemaHall.Location = new System.Drawing.Point(358, 307);
            this.textBoxCinemaHall.Name = "textBoxCinemaHall";
            this.textBoxCinemaHall.Size = new System.Drawing.Size(459, 34);
            this.textBoxCinemaHall.TabIndex = 13;
            this.textBoxCinemaHall.TextChanged += new System.EventHandler(this.textBoxCinemaHall_TextChanged);
            // 
            // textBoxShowtime
            // 
            this.textBoxShowtime.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxShowtime.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShowtime.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxShowtime.Location = new System.Drawing.Point(358, 254);
            this.textBoxShowtime.Name = "textBoxShowtime";
            this.textBoxShowtime.Size = new System.Drawing.Size(459, 34);
            this.textBoxShowtime.TabIndex = 14;
            this.textBoxShowtime.TextChanged += new System.EventHandler(this.textBoxShowtime_TextChanged);
            // 
            // textBoxMovie
            // 
            this.textBoxMovie.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMovie.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovie.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxMovie.Location = new System.Drawing.Point(358, 200);
            this.textBoxMovie.Name = "textBoxMovie";
            this.textBoxMovie.Size = new System.Drawing.Size(459, 34);
            this.textBoxMovie.TabIndex = 15;
            this.textBoxMovie.TextChanged += new System.EventHandler(this.textBoxMovie_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxEmail.Location = new System.Drawing.Point(358, 146);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(459, 34);
            this.textBoxEmail.TabIndex = 16;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(81, 415);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 27, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 33);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ticket Price :";
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
            this.button1.TabIndex = 91;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnPay
            // 
            this.bttnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.bttnPay.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnPay.Location = new System.Drawing.Point(970, 564);
            this.bttnPay.Margin = new System.Windows.Forms.Padding(51, 2, 100, 0);
            this.bttnPay.Name = "bttnPay";
            this.bttnPay.Size = new System.Drawing.Size(182, 53);
            this.bttnPay.TabIndex = 92;
            this.bttnPay.Text = "Confirm Booking";
            this.bttnPay.UseVisualStyleBackColor = false;
            this.bttnPay.Click += new System.EventHandler(this.bttnPay_Click);
            // 
            // BookingF6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ticket_Cinema.Properties.Resources.payment1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.bttnPay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxMovie);
            this.Controls.Add(this.textBoxShowtime);
            this.Controls.Add(this.textBoxCinemaHall);
            this.Controls.Add(this.textBoxSeatNumber);
            this.Controls.Add(this.textBoxTicketPrice);
            this.Controls.Add(this.textBoxTotalAmount);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelbooking);
            this.Name = "BookingF6";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.BookingF6_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelbooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.TextBox textBoxTicketPrice;
        private System.Windows.Forms.TextBox textBoxSeatNumber;
        private System.Windows.Forms.TextBox textBoxCinemaHall;
        private System.Windows.Forms.TextBox textBoxShowtime;
        private System.Windows.Forms.TextBox textBoxMovie;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttnPay;
        //private EventHandler backBtn_Click;
    }
}