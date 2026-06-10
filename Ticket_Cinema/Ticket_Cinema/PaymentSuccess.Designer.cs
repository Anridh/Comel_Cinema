namespace Ticket_Cinema
{
    partial class PaymentSuccess
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblPMethod = new System.Windows.Forms.Label();
            this.lblPDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ticket_Cinema.Properties.Resources._checked;
            this.pictureBox1.Location = new System.Drawing.Point(277, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment Successful!";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(323, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 42);
            this.label8.TabIndex = 8;
            this.label8.Text = "Booking ID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(322, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 17, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Payment Method:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(322, 387);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 17, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Payment Amount:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(322, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 17, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 42);
            this.label4.TabIndex = 11;
            this.label4.Text = "Payment Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBookID
            // 
            this.lblBookID.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBookID.Location = new System.Drawing.Point(691, 210);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(248, 42);
            this.lblBookID.TabIndex = 12;
            this.lblBookID.Text = "Booking ID num";
            this.lblBookID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBookID.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblPMethod
            // 
            this.lblPMethod.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMethod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPMethod.Location = new System.Drawing.Point(691, 269);
            this.lblPMethod.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lblPMethod.Name = "lblPMethod";
            this.lblPMethod.Size = new System.Drawing.Size(248, 42);
            this.lblPMethod.TabIndex = 13;
            this.lblPMethod.Text = "Method Pay";
            this.lblPMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPDate
            // 
            this.lblPDate.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPDate.Location = new System.Drawing.Point(691, 328);
            this.lblPDate.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lblPDate.Name = "lblPDate";
            this.lblPDate.Size = new System.Drawing.Size(248, 42);
            this.lblPDate.TabIndex = 14;
            this.lblPDate.Text = "Payment date";
            this.lblPDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(745, 386);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 42);
            this.label6.TabIndex = 18;
            this.label6.Text = "0.00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(691, 386);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 42);
            this.label7.TabIndex = 17;
            this.label7.Text = "RM";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // signUpBtn
            // 
            this.signUpBtn.AllowDrop = true;
            this.signUpBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.signUpBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.signUpBtn.Location = new System.Drawing.Point(424, 492);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(412, 76);
            this.signUpBtn.TabIndex = 20;
            this.signUpBtn.Text = "View Ticket";
            this.signUpBtn.UseVisualStyleBackColor = false;
            // 
            // PaymentSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPDate);
            this.Controls.Add(this.lblPMethod);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PaymentSuccess";
            this.Text = "PaymentSuccess";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblPMethod;
        private System.Windows.Forms.Label lblPDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button signUpBtn;
    }
}