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
            //tbUsername.Text = Utils.HashPassword("1");
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            var carRentDbContext = new CarRentDbContext();
            try
            {

                /*SHA256 sha = SHA256.Create();
                string hashPassword = Utils.HashPassword(tbPassword.Text);

                var userName = tbUsername.Text.Trim();

                var user = carRentDbContext.Users.FirstOrDefault
                    (x => x.UserName == userName && x.Password == hashPassword && x.IsActive == true);

                if (user == null)
                {
                    MessageBox.Show("Incorrect password or login");
                }
                else
                {

                    
                    var mainWindow = new MainWindow(this, user);
                    mainWindow.Show();
                    Hide();
                }*/

                var user = carRentDbContext.Users.FirstOrDefault
                    (x => x.UserName == "Valik");

                var mainWindow = new MainWindow(this, user);
                mainWindow.Show();
                Hide();


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

        public static string DefaultHashPassword()
        {
            var defaultHash = Utils.HashPassword("Password@123");
            return defaultHash;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            bLogin.Enabled = true;
        }
    }
}
