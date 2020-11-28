using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	class RangedWeaponClass
	{
		public RangedWeaponClass(int x, int y, rangedWeapons type)
		{
		}

		public enum rangedWeapons
		{
			Rifle,
			Longbow
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

