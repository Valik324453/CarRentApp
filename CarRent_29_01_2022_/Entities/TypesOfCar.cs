using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent_29_01_2022_.Entities
{
    public class TypesOfCar
    {
        public int Id { get; set; }
        public string Make { get; set; }//Brand
        public string Model { get; set; }
        public string VIN { get; set; }
        public string LicensePlateNumber { get; set; }
        public int? Year { get; set; }

        public virtual ICollection<CerRentalRecord> CerRentalRecords { get; set; }
    }
}
