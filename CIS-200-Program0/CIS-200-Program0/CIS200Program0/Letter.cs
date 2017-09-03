using System;
namespace CIS200Program0
{
	//Letter is a special parcel
	public class Letter : Parcel
	{
		//Fix cost determined by the shippers
		decimal _fixedCost;

		public Letter(Address origin, Address destination, decimal fixedCost) 
			: base(origin,destination)
		{
			//If a negative value is entered we will just assume free for now.
			_fixedCost = fixedCost > 0 ? fixedCost : 0;
		}

		//Letters have a fixed cost just return it
		public override decimal CalcCost()
		{
			return _fixedCost;			
		}

	}
}
