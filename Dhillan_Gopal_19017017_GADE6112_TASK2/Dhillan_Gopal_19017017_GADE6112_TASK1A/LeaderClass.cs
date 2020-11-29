using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	class LeaderClass : EnemyClass
	{
		private TileClass target
		{
			get { return target; }
			set { target = value; }

		}
		public LeaderClass(int x, int y) : base(x,y,TileClass.tileType.Enemy,2,20)
		{
			
			goldBag = 2;
		}



		public override Movement returnMove(Movement move = 0)
		{
			int targetX = target.getX();
			int targetY = target.getY();
			int leaderX = this.getX();
			int leaderY = this.getY();
			Movement toMove;
			if (leaderX > targetX)
			{
				// Check if you can move down 
				//if it is return movement.down
				toMove = Movement.Down;
			}
			else if (leaderX < targetX)
			{// Check if you can move up
			 //if it is return movement.up

			}
			else if (leaderY > targetY)
			{// Check if you can move left 
			 //if it is return movement.left

			}
			else if (leaderY < targetY)
			{// Check if you can move right 
			 //if it is return movement.right

			}

		}
			//int[] possible_moves = { 0, 1, 2, 3 };
			//Boolean moveFound = false;
			//CharacterClass.Movement direction = CharacterClass.Movement.Nomovement;


			//while (!moveFound)
			//{
			//	direction = (CharacterClass.Movement)possible_moves[rnd.Next(0, possible_moves.Length)];

			//	if (this.characterVision[(int)direction] is EmptyTileClass)
//{
				//	moveFound = true;

				//}
				//else if (possible_moves.Length != 1)
			//	{

			//		int[] new_possible_moves = new int[possible_moves.Length - 1];
			//		int index = 0;

			//		for (int i = 0; i < possible_moves.Length; ++i)
			//		{
			//			if (possible_moves[i] != (int)direction)
			//			{
			//				new_possible_moves[index] = possible_moves[i];
			//				++index;
			//			}
			//		}

			//		possible_moves = new_possible_moves;
			//	}
			//	else
			//	{
			//		direction = CharacterClass.Movement.Nomovement;
			//		moveFound = true;
			//	}
		
			//}
			//return direction;

		//}

	}
}
