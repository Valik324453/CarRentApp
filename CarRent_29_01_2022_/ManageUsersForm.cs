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
    public partial class ManageUsersForm : Form
    {
        private CarRentDbContext _dbContext = new CarRentDbContext();
        private int _id;
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvUserList.SelectedRows[0].Cells["id"].Value;

                //query db for record
                var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
                var hashPassword = Utils.DefaultHashPassword();
                user.Password = hashPassword;
                _dbContext.SaveChanges();
                MessageBox.Show("Password has been reseted");
            }
            catch (Exception)
            {

                MessageBox.Show("Try again");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var users = _dbContext.Users.Select(x => new
            {
                x.Id,
                x.UserName,
                //RoleName = x.UserRoles.FirstOrDefault().Role.Name,
                x.UserRoles.FirstOrDefault().Role.Name,
                x.IsActive
            }).ToList();
            dgvUserList.DataSource = users;
            dgvUserList.Columns["Id"].Visible = false;
            dgvUserList.Columns["IsActive"].HeaderText = "Active";
            dgvUserList.Columns["Name"].HeaderText = "Role Name";
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void btnActivateDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvUserList.SelectedRows[0].Cells["Id"].Value;
                var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
                if (user != null)
                {
                    user.IsActive = !user.IsActive;
                    _dbContext.SaveChanges();
                    MessageBox.Show("User status has been changed");
                    PopulateGrid();
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Exception on update user status");
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            var addUser = new AddNewUserForm(this);
            addUser.Show();
        }
    }
}
