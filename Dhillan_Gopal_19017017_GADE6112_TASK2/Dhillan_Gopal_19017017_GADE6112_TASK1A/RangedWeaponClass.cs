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
		public enum Types
		{
            Longbow,
            Rifle			
		}
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
        public RangedWeaponClass(Types type, int x, int y) : base(x, y, "*")
        {
            if (type == Types.Longbow)
            {
                durability = 4;
                Range = 2;
                damage = 4;
                cost = 6;
                
            }
            else
            {
                if (type == Types.Rifle)
                {
                    durability = 3;
                    Range = 3;
                    damage = 5;
                    cost = 7;
                }
            }
            
        }
        public RangedWeaponClass(Types type, int x, int y, int durability) : this(type, x, y) // what to do Durability?
		{
           
		}

    }
}
	


