using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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
            try
            {
                SHA256 sha = SHA256.Create();
                string hashPassword = Utils.HashPassword(tbPassword.Text);
                //get active user by username, password(hashpassword)
                var user = "Valik";//user from db
                if (user == null)
                {
                    MessageBox.Show("Incorrect password or login");
                }
                else//user exists
                {
                    Thread.Sleep(1000);
                    var mainWindow = new MainWindow(this, user);
                    mainWindow.Show();
                    Hide();
                }


            }
            catch (Exception)
            {

                throw;
                MessageBox.Show("Call admin");
            }
        }

        private void tbPassword_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUsername.Text) && !string.IsNullOrEmpty(tbPassword.Text))
            {
                bLogin.Enabled = true;
                bLogin.Select();
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                label1.Text = "Please fill username";
                tbUsername.Select();
            }
        }
    }
}
