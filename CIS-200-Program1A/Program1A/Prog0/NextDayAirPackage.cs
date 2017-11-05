// Program 1A
// CIS 200-01/76
// Fall 2017
// Due: 9/25/2017
// Grading Id: D4199

// File: NextDayAirPackage.cs
// A special case of AirPackage

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1A
{
    public class NextDayAirPackage : AirPackage
    {

        //The fee set by the shipper
        private decimal _expressFree;

        //Constructor
        //Precondition: Origin and Destination, Length width height weight express fee must be positive
        //Postcondition: Creates Next Day Air Package
        public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight, decimal expressFee) 
            : base(originAddress, destAddress, length, width, height, weight)
        {
            ExpressFee = expressFee;
        }

        public decimal ExpressFee
        {

            //Precondition: None
            //Postcondition: Returns the express fee
            get
            {
                return _expressFree;
            }

            //Precondition: Must be the member and express fee must be positive or zero
            //Postcondition: Sets the express fee
            private set
            {
                if (value >= 0) _expressFree = value;
                else throw new ArgumentOutOfRangeException("Express Fee can't be negative");
            }
        }


        //Precondition: None
        //Postcondition: Returns the cost
        public override decimal CalcCost()
        {
            var lwhScale = .4; //Scales the Length, Width, Height
            var weightScale = .3; //Scales the weight

            decimal baseCost = (decimal)(lwhScale * (Length + Width + Height) + weightScale * (Weight)) + ExpressFee;
            if (isHeavy()) baseCost += heavyCharge(); //If heavy add the heavy charge
            if (isLarge()) baseCost += largeCharge(); //If large add the large charge
            return baseCost;
        }

        //Precondition: None
        //Postcondition: Returns the charge for heavy packages
        protected decimal heavyCharge()
        {
            double heavyScale = .25; //How much of the weight to use
            return (decimal)(Weight * heavyScale);
        }

        //Precondition: None
        //Postcondition: Returns the charge for large packages
        protected decimal largeCharge()
        {
            double largeScale = .25; //How much to scalle it down
            return (decimal)((Length + Width + Height) * largeScale);
        }

        //Precondition: None
        //Postcondition: Returns a formatted string
        public override string ToString()
        {
            var str = base.ToString() + Environment.NewLine + $"Express Fee:{ExpressFee}" + Environment.NewLine;
            return str;
        }

    }
}
