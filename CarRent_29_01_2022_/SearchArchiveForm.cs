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
            var date = DateTime.Now.AddDays(-3);
            var carRentalRecords = _dbContext.CarRentalRecords
                .Where(x => x.DateRented.Value < DateTime.Now)
                .Where(x => x.DateRented.Value > date)
                .Select(x => new
            {
                x.CustomerName,
                x.Cost,
                x.DateRented,
                x.DateReturned,
                Car = x.TypesOfCars.Model + " " + x.TypesOfCars.Make
            }).ToList();
            dgvCarRents.DataSource = carRentalRecords;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string search = tbSearch.Text.Trim();

            if (!string.IsNullOrEmpty(search))
            {
                var carRentalRecords = _dbContext.CarRentalRecords
                .Where(x => x.CustomerName.Contains(search) || x.TypesOfCars.Make.Contains(search))
                .Select(x => new
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
}
