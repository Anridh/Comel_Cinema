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
    public partial class LoginF2 : Form
    {
        public LoginF2()
        {
            InitializeComponent();
        }

        private void LoginF2_Load(object sender, EventArgs e)
        {

        }

        private void signUpLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupF1 signup = new SignupF1();
            signup.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
