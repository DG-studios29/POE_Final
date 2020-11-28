using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	class ShopClass
	{
		private WeaponsClass[] weapon = new WeaponsClass[3];
		private Random numRand = new Random(Guid.NewGuid().GetHashCode());
		private CharacterClass Buyer;

		public ShopClass(CharacterClass buyer)
		{
			Buyer = buyer;
			for(int i = 0; i < weapon.Length; i++)
			{
				weapon[i] = RandomWeapon();
			}
		}
		public bool CanBuy(int num)
		{ 
			return Buyer.goldBag >= weapon[num].Cost;
		}
		public void Buy(int num)
		{
			Buyer.goldBag -= weapon[num].Cost;
			Buyer.pickup(weapon[num]);
			weapon[num] = RandomWeapon();
		}
		public string DisplayWeapon(int num)
		{
			return "Buy " + weapon[num].WeaponType + weapon[num].Cost.ToString() + "Gold";
		}
		private WeaponsClass RandomWeapon()
		{
			WeaponsClass createweapon;
			int weaponSelect = numRand.Next(0, 3);

			if (weaponSelect == 0)
			{
				createweapon = new RangedWeaponClass(RangedWeaponClass.rangedWeapons.Longbow, 0, 0);

			}
			else
			{
				if (weaponSelect == 1)
				{
					createweapon = new RangedWeaponClass(RangedWeaponClass.rangedWeapons.Rifle, 0, 0);
				}
				else
				{
					if (weaponSelect == 2)
					{
						createweapon = new MeleeWeaponClass(0, 0, MeleeWeaponClass.weaponTypes.Longsword);
					}
					else
					{
						createweapon = new MeleeWeaponClass(0, 0, MeleeWeaponClass.weaponTypes.Dagger);
					}
				}
				
			}
			return createweapon;

		}
	}


}


