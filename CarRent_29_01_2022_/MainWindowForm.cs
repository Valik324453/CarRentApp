using CarRent_29_01_2022_.Entities;
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
    public partial class MainWindow : Form
    {
        private LoginForm _login;
        public User user;//model (db)
        public string roleName;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(LoginForm loginForm, User userModel)
        {
            InitializeComponent();
            _login = loginForm;
            user = userModel;
            roleName = "Admin";
            //user.role      role:id,name,shortname
            //roleName= userModel.role.shortname;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();

        }

        

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageUsers"))
            {
                var manageUsers = new ManageUsersForm();
                // manageUsers.MdiParent = this;
                manageUsers.Show();
            }
        }
    }
}
