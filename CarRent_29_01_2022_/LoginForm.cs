using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent_29_01_2022_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            
            /*else
            {
                MessageBox.Show(tbUsername.Text + " " + tbPassword.Text);
            }*/
        }

        private void tbPassword_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                MessageBox.Show("Please fill username");
                tbUsername.Select();
            }
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please fill password");
                tbUsername.Select();
            }
            bLogin.Enabled = true;
            bLogin.Select();
        }

    }
}
