namespace CarRent_29_01_2022_.Migrations
{
    using CarRent_29_01_2022_.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    
    public partial class AddCars : DbMigration
    {
        public override void Up()
        {
            var dbContext = new CarRentDbContext();
            dbContext.TypesOfCars.Add(
                new TypesOfCar
                {
                    Make = "Bugatti",
                    Model = "Veron",
                    LicensePlateNumber = "123qwer",
                    VIN = "32fdwd3",
                    Year = 2018,
                    CerRentalRecords = new List<CarRentalRecord>()
                });
            dbContext.TypesOfCars.Add(
                new TypesOfCar
                {
                    Make = "BMW",
                    Model = "X6",
                    LicensePlateNumber = "777BNDs",
                    VIN = "f4398gfe",
                    Year = 2012,
                });
            dbContext.TypesOfCars.Add(
                new TypesOfCar
                {
                    Make = "Mercedess",
                    Model = "CLS",
                    LicensePlateNumber = "rew3456",
                    VIN = "g4g349g9",
                    Year = 2016,
                    CerRentalRecords = new List<CarRentalRecord>()
                }) ;
            dbContext.SaveChanges();
        }
        
        public override void Down()
        {
        }
    }
}
