﻿using CarRent_29_01_2022_.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent_29_01_2022_
{
    public class CarRentDbContext : DbContext
    {
        public CarRentDbContext():base("MyConnectionString")
        {

        }
        public virtual DbSet<CarRentalRecord> CarRentalRecords { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<TypesOfCar> TypesOfCars { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }


    }
}
