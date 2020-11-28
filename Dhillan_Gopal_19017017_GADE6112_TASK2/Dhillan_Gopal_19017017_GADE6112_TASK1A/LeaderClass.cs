using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	class LeaderClass : EnemyClass
	{
		public LeaderClass(int x, int y, tileType type, int damage, int hp) : base(x, y, type, damage, hp)
		{
			damage = 2;
			hp = 20;
		}

		private int Tile
		{
			get { return Tile; }
			set { Tile = value; }

		}
		public override Movement returnMove(CharacterClass.Movement move)
		{
			throw new NotImplementedException();
		}
	}
}
