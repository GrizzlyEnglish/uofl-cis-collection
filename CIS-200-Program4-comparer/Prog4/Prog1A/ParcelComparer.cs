// Program 4
// CIS 200-01/76
// Fall 2017
// Due: 11/19/2017
// By: D4199

// File: ParcelComparer.cs
// This contains two parcel comparer classes to help sort a list of parcels.
// One sorts by destination zip, the other by type then cost.   

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    // Precondition:  None
    // Postcondition: Sorts a list of Parcels by their destination zips
    class ParcelZipComparer : IComparer<Parcel>
    {
        public int Compare(Parcel x, Parcel y)
        {
            //Sets the zip, checking for nulls
            int? xZip = x?.DestinationAddress?.Zip;
            int? yZip = y?.DestinationAddress?.Zip;

            //Check is y is null and if it is move y up, if x is null move x up, if both are null return 0
            if(!yZip.HasValue || !xZip.HasValue)
            {
                return !yZip.HasValue ? (!xZip.HasValue ? 0 : 1) : -1;
            }
            //Checks if xZip or yZip is greater moving which backward
            else
            {
                return yZip.Value >= xZip.Value ? -1 : 1;
            }
        }
    }

    // Precondition:  None
    // Postcondition: Sorts a list of Parcels by their type then use Parcels CompareTo
    class ParcelTypeComparer : IComparer<Parcel>
    {
        public int Compare(Parcel x, Parcel y)
        {
            //Check if x or y is null, moving them based on null
            if (x == null || y == null)
            {
                return x == null ? (y == null ? 0 : 1) : -1;
            }

            //Get the type of parcel for each for comparison
            Type xType = x.GetType();
            Type yType = y.GetType();

            //If there types dont match we have to move one
            if(xType != yType)
            {
                //Get the one with the lowest letter and move forward
                return xType.ToString().ToLower()[0] > yType.ToString().ToLower()[0] ? 1 : -1;
            }
            else
            {
                //Use the default comparer to determine who moves
                return x.CompareTo(y);
            }
        }
    }

}
