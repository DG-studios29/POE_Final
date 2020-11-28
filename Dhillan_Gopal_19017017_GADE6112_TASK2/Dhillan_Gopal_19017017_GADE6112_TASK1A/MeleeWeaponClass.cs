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
		public MeleeWeaponClass(int x, int y, weaponTypes type) : base(TileClass.tileType.MeleeWeapon, x, y)
		{
			weapontype = type;
			if (type == weaponTypes.Longsword)
			{
				if (weaponType == "Longsword")
				{
					durability = 6;
					damage = 5;
					cost = 4;
				}
				else
				{
					if (type == weaponTypes.Dagger)
					{
						if (weaponType == "Danger")
						{
							durability = 10;
							damage = 3;
							cost = 3;
						}
					}

				}
			}
		}

		public enum weaponTypes
		{	
			Dagger,
			Longsword
		}
		public weaponTypes weapontype;
		
		public override int Range
		{
			get 
			{ 
			return 1; 
			}
		}
		

 
	}
}
