namespace ApartmentRent.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
    }
}
