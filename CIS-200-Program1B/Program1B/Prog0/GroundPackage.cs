// Program 1A
// CIS 200-01/76
// Fall 2017
// Due: 9/25/2017
// Grading Id: D4199

// File: GroundPackage.cs
// A special case of Package, calculates cost based on zip

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1A
{
    public class GroundPackage : Package
    {
        //Distance between the zones (zip codes) of the origin and destination. Used in calculating the cost
        private int _zoneDistance;

        //Constructor, uses base of Package
        //Precondition: Origin and Destination Addresses and non-negative Length, Width, Height, Width
        //Postcondition: Creates GroundPackage with zone distance
        public GroundPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight) 
            : base(originAddress, destAddress, length, width, height, weight)
        {
            _zoneDistance = CalcZoneDistance(OriginAddress.Zip, destAddress.Zip);
        }

        //Precondition: OriginZip and DestZip, must be greater than 0
        //Postcondition: Calcs the distance between zones and returns the value
        private int CalcZoneDistance(int originZip, int destZip)
        {
            var oFirstDigit = int.Parse(originZip.ToString().Substring(0, 1));
            var dFirstDigit = int.Parse(destZip.ToString().Substring(0, 1));

            return Math.Abs(oFirstDigit - dFirstDigit);
        }

        public int ZoneDistance {
            //Precondition: None
            //Postcondition: Returns Zone Distance
            get { return _zoneDistance; }
        }

        //Precondition: None
        //Postcondition: Calculates Cost of shipment
        public override decimal CalcCost()
        {
            var lwhFraction = .2; //Fraction of Length, Width, Height
            var zoneFraction = .5; // Fraction of zone distance plus zone scale
            var zoneScale = 1; //How much we scale zone distance

            return (decimal)(lwhFraction * (base.Length + base.Width + base.Height) + zoneFraction * (ZoneDistance + zoneScale) * base.Weight);
        }

        //Precondition: None
        //Postcondition: Formats GroundPackage and its zone distance into string
        public override string ToString()
        {
            var str = base.ToString() + Environment.NewLine + $"ZoneDistance:{ZoneDistance}" + Environment.NewLine;
            return str;
        }

    }

}
