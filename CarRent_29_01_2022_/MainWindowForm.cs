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
        private CarRentDbContext _dbContext = new CarRentDbContext();

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

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Utils.FormIsOpen("AddEditRentalForm"))
            {
                var addEditRentalForm = new AddEditRentalForm();
                addEditRentalForm.Show();
            }
        }

        private void editRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = (int)dgvRentalRecords.SelectedRows[0].Cells["ID"].Value;

            if(index < 0)
            {
                MessageBox.Show("Please select an item from the Grid");
            }
            else
            {
                var carRentalRecord = _dbContext.CarRentalRecords.FirstOrDefault(x => x.Id == index);
                if(carRentalRecord != null)
                {
                    if (!Utils.FormIsOpen("AddEditRentalForm"))
                    {
                        var addEditRentalForm = new AddEditRentalForm(carRentalRecord);
                        addEditRentalForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Record is missing");
                }
            }

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var carRecords = _dbContext.CarRentalRecords.Select(x => new 
            {
                x.Id,
                x.CustomerName,
                x.Cost,
                x.DateRented,
                x.DateReturned,
                Car = x.TypesOfCars.Model + " " + x.TypesOfCars.Make,
                x.TypesOfCarId
            }).ToList();
            dgvRentalRecords.DataSource = carRecords;
            dgvRentalRecords.Columns["Id"].Visible = false;
            dgvRentalRecords.Columns["TypesOfCarId"].Visible = false;
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Hide();
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("SearchArchiveForm"))
            {
                SearchArchiveForm searchArchiveForm = new SearchArchiveForm();
                searchArchiveForm.Show();
                this.Hide();
            }
        }
    }
}
