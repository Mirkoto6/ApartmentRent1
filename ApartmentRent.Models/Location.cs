namespace ApartmentRent.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.ComponentModel.DataAnnotations;
    public class Location
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
