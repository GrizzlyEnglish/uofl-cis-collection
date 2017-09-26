// Program 1A
// CIS 200-01/76
// Fall 2017
// Due: 9/25/2017
// Grading Id: D4199

// File: AirPackage.cs
// A special case of Package, has heavy and large status

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1A
{
    public abstract class AirPackage : Package
    {
        private int _heavyCutOff = 75; //Anything greater is a heavy package
        private int _largeCutOff = 100; //L+W+H > than this is a large package

        public AirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight) 
            : base(originAddress, destAddress, length, width, height, weight)
        {
            //Uses base constructor
        }

        //Precondition: None
        //Postcondition: Checks if package exceeds the heavy cut off
        public bool isHeavy()
        {
            return Weight >= _heavyCutOff;
        }

        //Precondition: None
        //Postcondition: Checks if package exceeds the large cut off
        public bool isLarge()
        {
            return (Length + Width + Height) >= _largeCutOff;
        }
        
        //Precondition: None
        //Postcondition: Formats AirPackage and its status into string
        public override string ToString()
        {
            var heavy = isHeavy() ? "Yes" : "No";
            var large = isLarge() ? "Yes" : "No";

            var str = base.ToString() + Environment.NewLine + $"Heavy:{heavy}" + Environment.NewLine + $"Large:{large}" + Environment.NewLine;
            return str;
        }
    }

}
