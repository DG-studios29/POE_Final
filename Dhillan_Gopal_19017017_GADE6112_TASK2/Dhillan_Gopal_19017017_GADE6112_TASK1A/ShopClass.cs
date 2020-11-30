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
		private string recentlyBoughtWeaponDisplay;

		public ShopClass(CharacterClass _buyer)
		{
			this.buyer = _buyer;
			numRand = new Random();
			weapons = new WeaponsClass[3];// add weapons into array
			for(int i = 0; i < weapons.Length; ++i)
			{
				//System.Windows.Forms.MessageBox.Show("i = " + i);
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
			recentlyBoughtWeaponDisplay = "Bought " + choosenWeapon.WeaponType + " (" + choosenWeapon.Cost.ToString() + " Gold)";
			weapons[num] = RandomWeapon();
		}
		public string DisplayWeapon(int num)
		{
			return recentlyBoughtWeaponDisplay;
		}
		private WeaponsClass RandomWeapon()
		{
			int[] possibleWeapons = { 0, 1, 2 };
			int randomWeapon = numRand.Next(0, 3);
			if (randomWeapon == 0)
			{
				if (this.getWeaponIndex("Dagger") < 0)
				{
					return new MeleeWeaponClass(MeleeWeaponClass.Types.Dagger);
				}
				
			}
			if (randomWeapon == 1)
			{
				if (this.getWeaponIndex("Longsword") < 0)
				{
					return new MeleeWeaponClass(MeleeWeaponClass.Types.Longsword);
				}
					
			}
			if (randomWeapon == 2)
			{
				if (this.getWeaponIndex("Longbow") < 0)
				{
					return new RangedWeaponClass(RangedWeaponClass.Types.Longbow);
				}
					
			}
				return new RangedWeaponClass(RangedWeaponClass.Types.Rifle);
		
		}
		public int getWeaponIndex(string w)
		{ 
			for (int i =0; i < weapons.Length; ++i)
			{
				if (weapons[i] != null && w == weapons[i].WeaponType)
				{
					return i;
				}
			}
			return -1;
		
		}
	}


}


