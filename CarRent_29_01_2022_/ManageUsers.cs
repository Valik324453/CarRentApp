﻿using System;
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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvUserList.SelectedRows[0].Cells["id"].Value;
                var user = 1;
                //query db for record
                //dbContext.users.firstOrDefault(x->x.id==id);
                var hashPassword = Utils.DefaultHashPassword();
                //User.password=hashPassword
                //dbContext.SaveChanges();
                MessageBox.Show("Password has been reseted");
            }
            catch (Exception)
            {

                MessageBox.Show("Try again");
            }
        }
    }
}
