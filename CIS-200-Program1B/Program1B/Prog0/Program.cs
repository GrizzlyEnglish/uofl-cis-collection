// Program 1B
// CIS 200-01/76
// Fall 2017
// Due: 9/11/2017
// Grading ID: D4199

// File: Program.cs
// Simple LINQ querys of parcels.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1A
{
    class Program
    {
        //Used to randomly get addresses
        public static Random rando = new Random();

        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            //Define some wacky addresses to send packages to and fro
            var addresses = new Address[]
            {
                new Address("Bruce Wayne", "123 Lane Ave", "Apt 10", "Louisville", "KY", 40023),
                new Address("Steve Rogers", "Street Lane", "Gilbertsville", "KY", 42044),
                new Address("Bojack Horesman", "203 Stree", "Apt 178", "Los Angles", "CA", 90210),
                new Address("Optimus Prime", "This is a road Rd", "Abie", "NE", 68001),
                new Address("Princess Carolyn", "Pince Lane", "Apt 56", "Pocatello", "ID", 83201),
                new Address("Megaman", "Blaster Street", "Biddeford", "ME", 04005),
                new Address("Boaty McBoatFace", "Waterway", "Apt 6", "Orange Park", "FL", 32003),
                new Address("Gary Gary", "Garys Street, go away", "Allenton", "MI", 48002),
            };

            List<Parcel> parcels = new List<Parcel>();

            //Loop through and create each Parcel type 10 times, I may have duplicates of parcels to addresses
            for (var i = 0; i < 5; i++)
            {
                //Get the index of our addresses, this way we can make sure they arent the same
                int oValue = getRandomInt(addresses.Length);
                int dValue = getRandomInt(addresses.Length, oValue);

                //Use the index to grab the addresses
                Address origin = addresses[oValue];
                Address destination = addresses[dValue];

                GroundPackage gp = new GroundPackage(origin, destination, getRandomDouble(5),
                    getRandomDouble(5), getRandomDouble(5), getRandomDouble(5));
                parcels.Add(gp);

                NextDayAirPackage ndap = new NextDayAirPackage(origin, destination,
                    getRandomDouble(14), getRandomDouble(14), getRandomDouble(14), getRandomDouble(140), 50m);
                parcels.Add(ndap);

                TwoDayAirPackage tdap = new TwoDayAirPackage(origin, destination, getRandomDouble(180), getRandomDouble(14),
                    getRandomDouble(16), getRandomDouble(6), (DeliveryEnum)getRandomInt(1));
                parcels.Add(tdap);
            }

            //Lets force some heavy packages, cause I'm too lazy to make a better randomizer
            TwoDayAirPackage heavy_tdap = new TwoDayAirPackage(addresses[2], addresses[6], getRandomDouble(180), getRandomDouble(14),
                    getRandomDouble(16), 250, (DeliveryEnum)getRandomInt(1));
            parcels.Add(heavy_tdap);

            NextDayAirPackage heavy_ndap = new NextDayAirPackage(addresses[6], addresses[2],
                    getRandomDouble(14), getRandomDouble(14), getRandomDouble(14), 200, 50m);
            parcels.Add(heavy_ndap);


            //Log the full list
            logParcels(parcels);
            
            //Part one Select all parcles and order by destination zip (desc)
            Console.WriteLine("-----------------------------------------------       Part 1");
            var descDest = from parcel in parcels orderby parcel.DestinationAddress.Zip descending select parcel;
            logParcels(descDest.ToList());


            //select all and order by cost (ascending)
            Console.WriteLine("-----------------------------------------------       Part 2");
            var byCost = from parcel in parcels orderby parcel.CalcCost() select parcel;
            logParcels(byCost.ToList());


            //select all parcels and orby parcel type then by cost (desc)
            Console.WriteLine("-----------------------------------------------       Part 3");
            var byTypeThenCost = from parcel in parcels orderby parcel.GetType().ToString() orderby parcel.CalcCost() descending select parcel;
            logParcels(byTypeThenCost.ToList());

            //select all air packages that are heavy and order by weight (desc)
            Console.WriteLine("-----------------------------------------------       Part 4");
            var heavyAirPackageByWeight = from airpackage in (from parcel in parcels
                                          where parcel.GetType().Equals(typeof(NextDayAirPackage)) || parcel.GetType().Equals(typeof(AirPackage))
                                          select (AirPackage)parcel) where airpackage.isHeavy() orderby airpackage.Weight descending
                                          select airpackage;
            logParcels(heavyAirPackageByWeight.ToList());

            Console.ReadLine();
        }

        //Using generic here since we can garauntee that it will be a parcel
        //PreCondition: Must give a list of T 
        //PostCondition: Logs out the objects and their type
        public static void logParcels<T>(List<T> parcels)
        {
            parcels.ForEach(p => {
                Type t = p.GetType();
                Console.WriteLine("Type of parcel: " + t.Name);
                Console.WriteLine(p.ToString());
                Console.WriteLine("-----------------------------");
            });
        }

        //Used to randomize the data, for fun
        //PreCondition: Give the scale to the
        //PostCondition: Returns the selected random int
        public static double getRandomDouble(int scale)
        {
            return rando.NextDouble() * scale;
        }

        //Used to randomize the data, for fun
        //PreCondition: Gize a size greater than zero, and if we need to exclude a result
        //PostCondition: Returns the selected random int
        public static int getRandomInt(int size, int? exluding = null)
        {
            int num;

            do
            {
                //Get a random int and make sure that we dont already have it
                num = rando.Next(size);
            } while (num == exluding);

            return num;
        }


    }
}
