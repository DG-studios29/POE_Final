using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	class MeleeWeaponClass : WeaponsClass
	{
		public MeleeWeaponClass(int x, int y,weaponTypes type) : base(x, y)
		{
		}

		public enum weaponTypes
		{	
			Dagger,
			Longsword
		}
		
		public override int Range
		{
			get 
			{ 
			return 1; 
			}
		}
		

 
	}
}
