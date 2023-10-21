using ApartmentRent.Data;
using ApartmentRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services
{
    public class CarsService
    {
        AppDbContext db = new AppDbContext();

        public List<ApartmentRent.Data.Apartment> GetCarsByBrand(string location)
        {
            return db.Apartments
                .Where(x => x.Location == location)
                .Select(c => new ApartmentRent.Data.Apartment() { Location = c.Location, Bedrooms = c.Bedrooms })
                .ToList();
        }
    }


}
