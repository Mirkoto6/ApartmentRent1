namespace ApartmentRent.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.ComponentModel.DataAnnotations;

    public class ApartmentType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
