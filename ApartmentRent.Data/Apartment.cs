using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRent.Data
{
    public class Apartment
    {
        public int ApartmentId { get; set; }
        public int ApartmentNumber { get; set; }
        public string Location { get; set; }
        public int Bedrooms { get; set; }
        public decimal RentAmount { get; set; }
    }
}
