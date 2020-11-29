using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	class ShopClass : GameEnginClass
	{
		private WeaponsClass[] weapon = new WeaponsClass[3];
		private Random numRand = new Random(Guid.NewGuid().GetHashCode());
		private CharacterClass Buyer;

		public ShopClass(CharacterClass buyer)
		{
			Buyer = buyer;
			
		}
		public bool CanBuy(int num)
		{ 
			
		}
		public void Buy(int num)
		{
			
		}
		public string DisplayWeapon(int num)
		{
			
		}
		private WeaponsClass RandomWeapon()
		{
			

		}
	}


}


