using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	class ShopClass : GameEnginClass
	{
		private WeaponsClass[] weapons;
		private Random numRand;
		private CharacterClass buyer;

		public ShopClass(CharacterClass _buyer)
		{
			this.buyer = _buyer;
			numRand = new Random();
			weapons = new WeaponsClass[3];// add weapons into array
			for(int i = 0; i < weapons.Length; ++i)
			{
				weapons[i] = RandomWeapon();
			}
		}
		public bool CanBuy(int num)
		{
			WeaponsClass choosenWeapon = weapons[num];
			if (choosenWeapon.Cost <= buyer.getgoldAmount())
			{
				return true;
			}
			return false;
		}
		public void Buy(int num)
		{
			WeaponsClass choosenWeapon = weapons[num];
			buyer.deductGold(choosenWeapon.Cost);
			buyer.pickup(choosenWeapon);
			weapons[num] = RandomWeapon();
		}
		public string DisplayWeapon(int num)
		{
			WeaponsClass choosenWeapon = weapons[num];
			return "Buy WeaponType (" + choosenWeapon.Cost.ToString() + " Gold)";
		}
		private WeaponsClass RandomWeapon()
		{
			int[] possibleWeapons = { 0, 1, 2, 3 };
			int randomWeapon = possibleWeapons[numRand.Next(0, possibleWeapons.Length)];
			if (randomWeapon == 0)
			{
				return new MeleeWeaponClass(MeleeWeaponClass.Types.Dagger);
			}
			else if (randomWeapon == 1)
			{
				return new MeleeWeaponClass(MeleeWeaponClass.Types.Longsword);
			}
			else if (randomWeapon == 2)
			{
				return new RangedWeaponClass(RangedWeaponClass.Types.Longbow);
			}
			else 
			{
				return new RangedWeaponClass(RangedWeaponClass.Types.Rifle);
			}
		}
	}


}


