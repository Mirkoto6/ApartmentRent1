using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApartmentRent.Models;

namespace ApartmentRent.Data
{


    public class AppDbContext : DbContext
    {
        public DbSet<Apartment> Apartments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = Mirko-PC; Initial Catalog = ApartmentRent1; Integrated Security = true; Trusted_Connection = true");
        }
    }
}

