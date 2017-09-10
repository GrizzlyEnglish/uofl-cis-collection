/*
 * Program 0
 * Grading ID: D4199
 * 
 * Addresses are standard.
 * Address Line2 is optional.
 * Zip code must be between 0 - 99999
 * 
 */

using System;
namespace CIS200Program0
{
	public class Address
	{
		uint _zipCode; //Non negative zip code

		//Full address constructor
		public Address(string name, string line1, string line2, string city, string state, uint zip)
		{
			initVals(name, line1, line2, city, state, zip);
		}

		//Address constructor without line 2, for addressed without a second line
		public Address(string name, string line, string city, string state, uint zip)
		{
			initVals(name, line, String.Empty, city, state, zip);
		}

		//An easier way to initiliaze variables twice
		private void initVals(string name, string line1, string line2, string city, string state, uint zip)
		{
			this.Name = name;
			this.Address1 = line1;
			this.Address2 = line2;
			this.City = city;
			this.State = state;
			this.Zip = zip;
		}

		//Properties
		public string Name { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string State { get; set; }

		//Property for zip code, can't be negative or above 99999
		public uint Zip { 
			get {
				return _zipCode;
			} 
			set {
                if (value < 99999)
                {
                    _zipCode = value;
                }
                //For now if out of range, lets just throw an error
                else throw new ArgumentOutOfRangeException();
			} 
		}


		//Override toString and output the contents of the addresses and the costs
		public override string ToString()
		{
			string str = Name + Environment.NewLine + Address1 + Environment.NewLine;
			if(Address2 != String.Empty) str += Address2 + Environment.NewLine;
			str += City + " " + State + ", " + Zip.ToString("D5");
			return str;
		}

	}
}
