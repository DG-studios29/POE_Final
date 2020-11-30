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
                base.Range = value;
            }
        }
        public RangedWeaponClass(Types type, int x = 0, int y= 0) : base(x, y)
        {
            if (type == Types.Longbow)
            {
                weaponType = "Longbow";
                durability = 4;
                Range = 2;
                damage = 4;
                cost = 6;
                
            }
            else
            {
                if (type == Types.Rifle)
                {
                    weaponType = "Rifle";
                    durability = 3;
                    Range = 3;
                    damage = 5;
                    cost = 7;
                    //System.Windows.Forms.MessageBox.Show("Rifle");

				}
               // else
				//{
                   // System.Windows.Forms.MessageBox.Show("UnKnown Range");
                //}
            }
            
        }
        public RangedWeaponClass(Types type, int x, int y, int durability) : this(type, x, y) // what to do Durability?
		{
           
		}

    }
}
	


