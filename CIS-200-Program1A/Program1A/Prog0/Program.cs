// Program 0
// CIS 200-01/76
// Fall 2017
// Due: 9/11/2017
// By: Andrew L. Wright (students use Grading ID)

// File: Program.cs
// Simple test program for initial Parcel classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1A
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            //Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", 
            //    "El Paso", "TX", 79901); // Test Address 3
            //Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
            //    "Portland", "ME", 04101); // Test Address 4

            //Letter l1 = new Letter(a1, a3, 0.50M); // Test Letter 1
            //Letter l2 = new Letter(a2, a4, 1.20M); // Test Letter 2
            //Letter l3 = new Letter(a4, a1, 1.70M); // Test Letter 3

            //List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            //// Add test data to list
            //parcels.Add(l1);
            //parcels.Add(l2);
            //parcels.Add(l3);

            //// Display data
            //Console.WriteLine("Program 0 - List of Parcels\n");

            //foreach (Parcel p in parcels)
            //{
            //    Console.WriteLine(p);
            //    Console.WriteLine("--------------------");
            //}



            //Testing classes
            GroundPackage gp = new GroundPackage(a1, a2, 10, 12.24, 13.3, 16.56);
            NextDayAirPackage nd = new NextDayAirPackage(a1, a2, 10, 12.24, 13.3, 16.56, 50);
            TwoDayAirPackage td = new TwoDayAirPackage(a1, a2, 10, 12.24, 13.3, 16.56, DeliveryEnum.Saver);

            Console.WriteLine(gp.ToString());
            Console.WriteLine(nd.ToString());
            Console.WriteLine(td.ToString());
        }
    }
}
