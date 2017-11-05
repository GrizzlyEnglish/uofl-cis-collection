// Program 1A
// CIS 200-01/76
// Fall 2017
// Due: 9/25/2017
// Grading Id: D4199

// File: TwoDayAirPackage.cs
// A special case of AirPackage

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1A
{
    //Specifices the type of two day delivery
    public enum DeliveryEnum
    {
        Early = 0,
        Saver = 1
    }


    public class TwoDayAirPackage : AirPackage
    {
        //The amount of discount saver gets
        private decimal _saverDiscount = .1m;

        //Constructor
        //Precondition: Origin and Destination, Length width height weight express fee must be positive
        //Postcondition: Creates TwoDayAirPackage
        public TwoDayAirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight, DeliveryEnum deliveryType) 
            : base(originAddress, destAddress, length, width, height, weight)
        {
            DeliveryType = deliveryType;
        }
        
        //Precondition: None
        //Postcondition: Gets and Sets DeliveryType, no validation needed
        protected DeliveryEnum DeliveryType { get; set; }

        public override decimal CalcCost()
        {
            var scale = .25; //Scale in equation

            decimal baseCost = (decimal)(scale * (Length + Width + Height) + scale * Weight);
            if (DeliveryType == DeliveryEnum.Saver) baseCost -= baseCost * _saverDiscount;
            return baseCost;
        }


        //Precondition: None
        //Postcondition: Returns a formatted string
        public override string ToString()
        {
            var str = base.ToString() + Environment.NewLine + $"Type of Delivery: {DeliveryType}";
            return str;
        }
    }
}
