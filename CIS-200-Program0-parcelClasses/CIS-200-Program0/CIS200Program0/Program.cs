/*
 * Program 0
 * Grading ID: D4199
 * 
 * A simple console application 
 * that creates a parcel -> letter
 * and outputs the origin and destionation.
 * 
 */


using System;
using System.Collections.Generic;

namespace CIS200Program0
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Create a list of parcels
			List<Parcel> parcelList = new List<Parcel>();

			//init a few address to be used to send letters to and fro
			Address myHome = new Address("My Home", "10405 Thrift Drive", "Apt 105",
										 "Louisville", "Kentucky", 40223);

			Address uOfL = new Address("U of L", "2301 S 3rd St.", "Louisville", "Kentucky", 40208);

			Address randoAK = new Address("Alaska Home", "2920", "Chesapeake Ave", "Alaska", 99516);
			
			Address randoOR = new Address("Oregon Home", "7340 SW Kimberly Ct", "Beaverton", "Oregon", 97008);

			//Create a special parcel, a letter, and set its origin destion and cost
			Letter letterOne = new Letter(myHome, uOfL, 500);
			parcelList.Add(letterOne);

			Letter letterTwo = new Letter(randoAK, randoOR, 2500);
			parcelList.Add(letterTwo);

			Letter letterThree = new Letter(uOfL, randoOR, 234.23m);
			parcelList.Add(letterThree);

			//Output the contents of each parcel
			parcelList.ForEach(p =>
			{
                Console.WriteLine("-------------");
                Console.WriteLine(p.ToString());
			});
		}
	}
}
