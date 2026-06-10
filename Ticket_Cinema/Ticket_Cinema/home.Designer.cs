namespace Ticket_Cinema
{
    partial class HomeForm
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
            this.sideBar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.Navy;
            this.sideBar.Controls.Add(this.button4);
            this.sideBar.Controls.Add(this.button5);
            this.sideBar.Controls.Add(this.button6);
            this.sideBar.Controls.Add(this.button3);
            this.sideBar.Controls.Add(this.button2);
            this.sideBar.Controls.Add(this.button1);
            this.sideBar.Location = new System.Drawing.Point(0, -1);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(143, 676);
            this.sideBar.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 37);
            this.button3.TabIndex = 1;
            this.button3.Text = "Payments";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Bookings";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Movies";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Navy;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 353);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 37);
            this.button5.TabIndex = 3;
            this.button5.Text = "Profile";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Navy;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 299);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 37);
            this.button6.TabIndex = 2;
            this.button6.Text = "Tickets";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.sideBar);
            this.Name = "HomeForm";
            this.Text = "home";
            this.sideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}