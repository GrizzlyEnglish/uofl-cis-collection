using System;
namespace CIS200Program0
{
	//Abstract Parcel is anything that is shippped from one address to another
	public abstract class Parcel
	{

		//Default constructor with an origin and an destination
		public  Parcel(Address origin, Address destination)
		{
			this.OriginAddress = origin;
			this.DestinationAddress = destination;
		}

		//Properties
		protected Address OriginAddress { get; set; }
		protected Address DestinationAddress { get; set; }

		//Each instance of a parcel will calulate its costs differently
		public abstract decimal CalcCost();

		//Override the to string and print the origin, destionation and cost
		public override string ToString()
		{
			return string.Format("Origin: \n{0} \n\nDestintion: \n{1} \nCosts: {2}", OriginAddress.ToString(),
			                     DestinationAddress.ToString(), CalcCost().ToString("C"));
		}

	}
}
