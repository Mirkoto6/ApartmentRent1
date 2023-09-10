using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apartment_Rent1
{
    public class ApartmentManager
    {
        private List<Apartment> apartments = new List<Apartment>();

        public void AddApartment(Apartment apartment)
        {
            apartments.Add(apartment);
        }

        public List<Apartment> GetApartments()
        {
            return apartments;
        }

        public void RemoveApartment(int apartmentNumber)
        {
            Apartment apartmentToRemove = apartments.FirstOrDefault(apt => apt.ApartmentNumber == apartmentNumber);

            if (apartmentToRemove != null)
            {
                apartments.Remove(apartmentToRemove);
                Console.WriteLine($"Apartment {apartmentNumber} removed.");
            }
            else
            {
                Console.WriteLine($"Apartment {apartmentNumber} not found.");
            }
        }

        public void EditApartment(int apartmentNumber, Apartment updatedApartment)
        {
            Apartment apartmentToEdit = apartments.FirstOrDefault(apt => apt.ApartmentNumber == apartmentNumber);

            if (apartmentToEdit != null)
            {
                apartmentToEdit.Location = updatedApartment.Location;
                apartmentToEdit.Bedrooms = updatedApartment.Bedrooms;
                apartmentToEdit.RentAmount = updatedApartment.RentAmount;

                Console.WriteLine($"Apartment {apartmentNumber} updated.");
            }
            else
            {
                Console.WriteLine($"Apartment {apartmentNumber} not found.");
            }
        }
    }
}
