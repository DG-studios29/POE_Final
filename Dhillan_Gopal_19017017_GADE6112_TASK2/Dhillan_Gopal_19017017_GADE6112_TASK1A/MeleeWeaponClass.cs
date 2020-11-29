using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	class MeleeWeaponClass : WeaponsClass
	{
		//public MeleeWeaponClass(int x, int y, string Meleesymbol) : base(x,y,Meleesymbol)
		//{

			
		//}
		public MeleeWeaponClass(Types type, int x, int y) : base(x,y,"&")
		{
			if (type == Types.Longsword)
			{
				durability = 6;
				damage = 5;
				cost = 4;
			}
			else
			{
				if (type == Types.Dagger)
				{
					durability = 10;
					damage = 3;
					cost = 3;
				}

			}

		}

		public enum Types
		{	
			Dagger,
			Longsword
		}
		
		public override int Range
		{
			get { return 1;}
		}
		

 
	}
}
