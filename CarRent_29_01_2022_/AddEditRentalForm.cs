using CarRent_29_01_2022_.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent_29_01_2022_
{
    
    public partial class AddEditRentalForm : Form
    {
        CarRentDbContext _dbContext = new CarRentDbContext();
        private bool _isEditMode;
        private CarRentalRecord _carRentalRecord;
        public AddEditRentalForm()
        {
            InitializeComponent();
            this.Text = "Add";
        }

        public AddEditRentalForm(CarRentalRecord carRentalRecord)
        {
            InitializeComponent();
            btnSave.Text = "Update";
            _carRentalRecord = carRentalRecord;
            this.Text = "Edit";

            tbCustomerName.Text = carRentalRecord.CustomerName;
            tbCost.Text = carRentalRecord.Cost.ToString();
            dtpDateRented.Text = carRentalRecord.DateRented.Value.ToString();
            dtpDateReturned.Text = carRentalRecord.DateReturned.Value.ToString();
            cbTypesOfCars.SelectedValue = carRentalRecord.TypesOfCarId.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var customerName = tbCustomerName.Text;
                var cost = Convert.ToDecimal(tbCost.Text);
                var dateRented = dtpDateRented.Value;
                var dateReturned = dtpDateReturned.Value;
                var typeOfCarId = (int)cbTypesOfCars.SelectedValue;

                if(string.IsNullOrEmpty(customerName))
                {
                    MessageBox.Show("Fill field(Customer Name)");
                }
                if (cost <= 0)
                {
                    MessageBox.Show("Fill field(Cost)");
                }
                if (dateRented > dateReturned)
                {
                    MessageBox.Show("dateRented > dateReturned");
                }

                var car = new CarRentalRecord()
                {
                    CustomerName = customerName,
                    Cost = cost,
                    DateRented = dateRented,
                    DateReturned = dateReturned,
                    TypesOfCarId = typeOfCarId
                };

                if(_carRentalRecord != null)
                {
                    _carRentalRecord.CustomerName = customerName;
                    _carRentalRecord.DateRented = dateRented;
                    _carRentalRecord.DateRented = dateReturned;
                    _carRentalRecord.TypesOfCarId = typeOfCarId;
                    _carRentalRecord.Cost = cost;

                    _dbContext.CarRentalRecords.AddOrUpdate(_carRentalRecord);
                    _dbContext.SaveChanges();

                    
                }
                else
                {
                    _dbContext.CarRentalRecords.Add(car);
                    _dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AddEditRentalForm_Load(object sender, EventArgs e)
        {
            /*var path = new GraphicsPath();
            path.AddEllipse(0, 0, Width, Height);
            Region = new Region(path);*/

            var cars = _dbContext.TypesOfCars.Select(x => new{ x.Id, Name = x.Make + " " + x.Model}).ToList();
            cbTypesOfCars.DataSource = cars;
            cbTypesOfCars.DisplayMember = "Name";
            cbTypesOfCars.ValueMember = "Id";
        }
    }
}
