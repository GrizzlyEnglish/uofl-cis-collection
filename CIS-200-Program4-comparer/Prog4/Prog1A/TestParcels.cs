// Program 1A
// CIS 200-01/76
// Fall 2017
// Due: 9/25/2017
// By: Andrew L. Wright (students use Grading ID)

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 74838); // Test Address 4
            Address a6 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 48392); // Test Address 4
            Address a7 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 23456); // Test Address 4

            Letter letter1 = new Letter(a1, a7, 3.95M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a6, 14, 10, 5, 12.5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a2, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a3, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);

            #region added By D4199
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a4, a4, 146.5, 239.5, 428.0, // Two Day test object
                180.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a4, a5, 16.5, 19.5, 18.0, // Two Day test object
                10.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap4 = new TwoDayAirPackage(a4, a6, 6.5, 9.5, 8.0, // Two Day test object
                0.5, TwoDayAirPackage.Delivery.Saver);
            GroundPackage gp2 = new GroundPackage(a4, a4, 16, 10, 5, 12.5);        // Ground test object
            GroundPackage gp3 = new GroundPackage(a3, a5, 143, 20, 35, 2.5);        // Ground test object
            GroundPackage gp4 = new GroundPackage(a3, a6, 165, 120, 15, 12.5);        // Ground test object
            GroundPackage gp5 = new GroundPackage(a3, a7, 9, 10, 5, 12.5);        // Ground test object
            #endregion

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);

                                                                                                                                                    #region added By D4199

            //Add in additional Parcels to test our sorter better
            parcels.Add(tdap2);
            parcels.Add(tdap3);
            parcels.Add(tdap4);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(gp4);
            parcels.Add(gp5);

            //Even add some nulls
            parcels.Add(null);
            parcels.Add(null);

            //First display full list
            Console.WriteLine("Original List:");
            PrintList(parcels, p => Console.WriteLine(p?.ToString()));
            Pause();

            //Then Sort by cost and display, using Parcels CompareTo
            Console.WriteLine("Sorted by Cost:");
            parcels.Sort();
            PrintList(parcels, p => Console.WriteLine(p?.CalcCost()));
            Pause();

            //Then Sort by destination zip and display, using ParcelZipCompaer
            Console.WriteLine("Sorted by Destination Zip:");
            parcels.Sort(new ParcelZipComparer());
            PrintList(parcels, p => Console.WriteLine(p?.DestinationAddress?.Zip));
            Pause();

            //Then Sort by type then cost and display, using ParcelTypeComparer
            Console.WriteLine("Sorted by Type then Cost:");
            parcels.Sort(new ParcelTypeComparer());
            PrintList(parcels, p => Console.WriteLine(p?.GetType().ToString() + ": " + p?.CalcCost()));
            Pause();
                                                                                                                                                    #endregion
        }

                                                                                                                                                    #region added By D4199
        public delegate void WriteLine(Parcel p); //Holder for PrintLsit delegate

        // Precondition:  Must pass list of Parcels and Delegate function
        // Postcondition: Ouputs a list of parcels based on the delegate
        public static void PrintList(List<Parcel> parcels, WriteLine write)
        {
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                write(p);
                Console.WriteLine("====================");
            }
        }
                                                                                                                                                    #endregion

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
