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
    public partial class SearchArchiveForm : Form
    {
        private CarRentDbContext _dbContext = new CarRentDbContext();
        public SearchArchiveForm()
        {
            InitializeComponent();
        }

        private void SearchArchiveForm_Load(object sender, EventArgs e)
        {
            var carRentalRecords = _dbContext.CarRentalRecords.Select(x => new
            {
                x.CustomerName,
                x.Cost,
                x.DateRented,
                x.DateReturned,
                Car = x.TypesOfCars.Model + " " + x.TypesOfCars.Make
            }).ToList();
            dgvCarRents.DataSource = carRentalRecords;
        }
    }
}
