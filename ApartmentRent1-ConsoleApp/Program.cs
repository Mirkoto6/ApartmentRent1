using System;
using System.Collections.Generic;

namespace Apartment_Rent1
{
    class Program
    {
        static void Main(string[] args)
        {
            ApartmentManager manager = new ApartmentManager();

            while (true)
            {
                Console.WriteLine("1. Add Apartment");
                Console.WriteLine("2. View Apartments");
                Console.WriteLine("3. Remove Apartment");
                Console.WriteLine("4. Edit Apartment");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Apartment Number: ");
                        int aptNumber = int.Parse(Console.ReadLine());

                        Console.Write("Location: ");
                        string location = Console.ReadLine();

                        Console.Write("Number of Bedrooms: ");
                        int bedrooms = int.Parse(Console.ReadLine());

                        Console.Write("Rent Amount: ");
                        decimal rentAmount = decimal.Parse(Console.ReadLine());

                        Apartment apartment = new Apartment
                        {
                            ApartmentNumber = aptNumber,
                            Location = location,
                            Bedrooms = bedrooms,
                            RentAmount = rentAmount
                        };

                        manager.AddApartment(apartment);
                        Console.WriteLine("Apartment added!");
                        break;
                    case "2":
                        List<Apartment> apartments = manager.GetApartments();
                        foreach (var apt in apartments)
                        {
                            Console.WriteLine(apt);
                        }
                        break;

                    case "3":
                        Console.Write("Enter Apartment Number to remove: ");
                        int aptNumberToRemove = int.Parse(Console.ReadLine());
                        manager.RemoveApartment(aptNumberToRemove);
                        break;

                    case "4":
                        Console.Write("Enter Apartment Number to edit: ");
                        int aptNumberToEdit = int.Parse(Console.ReadLine());
                        Apartment updatedApartment = new Apartment();

                        Console.Write("Updated Location: ");
                        updatedApartment.Location = Console.ReadLine();

                        Console.Write("Updated Number of Bedrooms: ");
                        updatedApartment.Bedrooms = int.Parse(Console.ReadLine());

                        Console.Write("Updated Rent Amount: ");
                        updatedApartment.RentAmount = decimal.Parse(Console.ReadLine());

                        manager.EditApartment(aptNumberToEdit, updatedApartment);
                        break;

                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
