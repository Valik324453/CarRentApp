using System;

namespace CarRent_29_01_2022_.Entities
{
    public class CarRentalRecord
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
        public decimal Cost { get; set; }
        public int? TypesOfCarId { get; set; }
        public virtual TypesOfCar TypesOfCars { get; set; }
    }
}