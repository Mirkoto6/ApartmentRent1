namespace ApartmentRent.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Apartment
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }
    }
}
