using System;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	class HeroClass : CharacterClass
	{

		public HeroClass(int x, int y, int hp) : base(x, y, TileClass.tileType.Hero)
		{
			this.setHp(hp);
			this.setMaxHp(hp);
			this.setDamage(2);
			this.type = TileClass.tileType.Hero;
		}

		public override string ToString()
		{
			string infoDisplay = "Player stats:\n";
			if (IsDead() == true)
			{
				infoDisplay += "Your hero is dead :(\n";
			} 
			infoDisplay += "Player Hp: " + HP.ToString() + "\n";
			infoDisplay += this.hasWeapon()?"Current Weapon: " + weapon.WeaponType: "Current Weapon: Bare Hands";
			infoDisplay += "X Postion: " + x.ToString() + "\t";
			infoDisplay += "Y Postion: " + y.ToString() + "\t" + "\n";
			infoDisplay += this.hasWeapon() ? "Weapon Range: " + weapon.Range : "Weapon Range: 1 " + "\n";
			infoDisplay += this.hasWeapon() ? "Weapon Damage: " + damage.ToString() : "Weapon Damage: 2 " + "\n";
			infoDisplay += "Amount of gold: " + this.getgoldAmount();
			return infoDisplay;

			
		}

		public override Movement returnMove(Movement move)
		{
			{
				if (this.characterVision[(int)move] is EmptyTileClass || this.characterVision[(int)move] is GoldClass || this.characterVision[(int)move] is WeaponsClass)
				{
					return move;
				}
				else
				{
					return Movement.Nomovement;
				}
			}
		}


	}
}
