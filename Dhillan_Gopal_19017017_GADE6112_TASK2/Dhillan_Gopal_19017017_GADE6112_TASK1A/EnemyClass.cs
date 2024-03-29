﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	abstract class EnemyClass : CharacterClass
	{
		
		public EnemyClass(int x, int y, TileClass.tileType type, int damage, int hp,int golddrop) : base(x, y, type)
		{
			setDamage(damage);
			setHp(hp);
			setMaxHp(hp);
			this.type = TileClass.tileType.Enemy;
		}


		public override string ToString()
		{
			string infoDisplay = "";
			infoDisplay += "Hp: " + hp.ToString()+"\n";
			infoDisplay += "X Postion: "+x.ToString() + "\n";
			infoDisplay += "Y Postion: " + y.ToString() +  "\n";
			infoDisplay += "Damage: " + damage.ToString();
			
			return infoDisplay;
			
		}

		
	}
}
