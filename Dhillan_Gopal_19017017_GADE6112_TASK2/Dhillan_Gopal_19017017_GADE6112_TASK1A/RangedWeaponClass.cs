using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
    [Serializable]
    class RangedWeaponClass : WeaponsClass
	{
		public enum rangedWeapons
		{
            Longbow,
            Rifle			
		}
        public rangedWeapons rangedtype;
        public override int Range
        { 
            get 
            { 
                return base.Range;
            } 

            set 
            { 
                Range = value; 
            } 
        }

        public RangedWeaponClass(rangedWeapons type, int x, int y) : base(x, y)
        {
            if (type == rangedWeapons.Rifle)
            {
                WeaponType = "Rifle"; durability = 3; Range = 3; damage = 5; cost = 7;
            }
            else
            {
                WeaponType = "Longbow"; durability = 4; Range = 2; damage = 4; cost = 6;
            }
            rangedtype = type;
        }

        public override string ToString()
        {
            return weaponType; 
        }
    }
}
	


