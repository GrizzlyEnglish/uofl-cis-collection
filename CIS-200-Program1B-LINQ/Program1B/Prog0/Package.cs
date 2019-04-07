// Program 1A
// CIS 200-01/76
// Fall 2017
// Due: 9/25/2017
// Grading Id: D4199

// File: Package.cs
// An abstract Package class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1A
{
    public abstract class Package : Parcel
    {
        //Backening fields
        private double _length; //Length of the package
        private double _width; //Width of the package
        private double _height; //Height of the package
        private double _weight; //Width of the package


        //Constructor of Package
        //Precondition: Must provide origin destination, and non negative length, width, height, and weight
        //Postcondition: Get a Package
        public Package(Address originAddress, Address destAddress, double length, double width, double height, double weight) 
            : base(originAddress, destAddress)
        {
            Length = length;
            Width = width;
            Weight = weight;
            Height = height;
        }

        public double Length {
            //Precondition: None
            //Postcondition: Get the Packages Length
            get
            {
                return _length;
            }

            //Precondition: Must be non-negative
            //Postcondition: Setd the Packages Length, or throws exception
            set
            {
                if (value > 0) _length = value;
                else throw new ArgumentOutOfRangeException("Length must be greater than zero");
            }
        }

        public double Width
        {
            //Precondition: None
            //Postcondition: Get the Packages Width
            get
            {
                return _width;
            }

            //Precondition: Must be non-negative
            //Postcondition: Setd the Packages Width, or throws exception
            set
            {
                if (value > 0) _width = value;
                else throw new ArgumentOutOfRangeException("Width must be greater than zero");
            }
        }

        public double Height
        {
            //Precondition: None
            //Postcondition: Get the Packages Height
            get
            {
                return _height;
            }

            //Precondition: Must be non-negative
            //Postcondition: Setd the Packages Height, or throws exception
            set
            {
                if (value > 0) _height = value;
                else throw new ArgumentOutOfRangeException("Height must be greater than zero");
            }
        }

        public double Weight
        {
            //Precondition: None
            //Postcondition: Get the Packages Weight
            get
            {
                return _weight;
            }

            //Precondition: Must be non-negative
            //Postcondition: Setd the Packages Weight, or throws exception
            set
            {
                if (value > 0) _weight = value;
                else throw new ArgumentOutOfRangeException("Weight must be greater than zero");
            }
        }

        //Precondition: None
        //Postcondition: Returns Parcels to string
        public override string ToString()
        {
            var str = $"Length:{Length:f2} Width:{Width:f2} Height: {Height:f2} Weight: {Weight:f2}";
            return str + System.Environment.NewLine + System.Environment.NewLine + base.ToString();
        }

    }
}
