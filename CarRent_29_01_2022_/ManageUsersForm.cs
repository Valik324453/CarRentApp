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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            var users = _dbContext.Users.Select(x => new
            {
                x.Id,
                x.UserName,
                RoleName = x.UserRoles.FirstOrDefault().Role.Name,
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
    }
}
