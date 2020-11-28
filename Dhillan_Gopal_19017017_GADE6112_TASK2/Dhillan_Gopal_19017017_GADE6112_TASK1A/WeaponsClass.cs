using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	abstract class WeaponsClass : ItemClass
	{
		protected int damage;
		public int Damage
		{
			get { return damage; }
			set { damage = value; }

		}
		protected int durability;
		public int Durability
		{
			get { return durability; }
			set { durability = value; }

		}
		protected int cost;
		public int Cost
		{
			get { return cost; }
			set { cost = value; }

		}
		protected string weaponType;
		public string WeaponType
		{
			get { return weaponType; }
			set { weaponType = value; }

		}
		private int range;
		public virtual int Range
		{
			get { return range; }
			set { range = value; }
		}
		protected WeaponsClass(int x, int y) : base(x, y)
		{
			
			if (weaponType == "Danger")
			{
				durability = 10;
				damage = 3;
				cost = 3;
			}
			else
			{
				if (weaponType == "Longsword")
				{
					durability = 6;
					damage = 5;
					cost = 4;
				}
			}
		}
	}
		
}

