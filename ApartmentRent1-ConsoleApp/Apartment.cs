using System;
using System.Collections.Generic;
using System.Text;

namespace Apartment_Rent1
{
    public class Apartment
    {
        public int ApartmentNumber { get; set; }
        public string Location { get; set; }
        public int Bedrooms { get; set; }
        public decimal RentAmount { get; set; }

        public override string ToString()
        {
            return $"Apartment {ApartmentNumber} - {Location} ({Bedrooms} bedrooms) - Rent: ${RentAmount}";
        }
    }
}