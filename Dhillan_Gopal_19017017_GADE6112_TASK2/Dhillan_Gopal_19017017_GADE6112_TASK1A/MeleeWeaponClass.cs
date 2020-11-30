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
		public MeleeWeaponClass(Types type, int x = 0, int y = 0) : base(x,y)
		{
			if (type == Types.Longsword)
			{
				weaponType = "Longsword";
				durability = 6;
				damage = 5;
				cost = 5;
			}
			else
			{
				if (type == Types.Dagger)
				{
					weaponType = "Dagger";
					durability = 10;
					damage = 3;
					cost = 3;
					//System.Windows.Forms.MessageBox.Show("Dagger");

				}
				//else
				//{
					//System.Windows.Forms.MessageBox.Show("UnKnown M");
				//}

			
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
