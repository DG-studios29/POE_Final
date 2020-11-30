using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	[Serializable]
	class LeaderClass : EnemyClass
	{
		private TileClass target;
		public TileClass _target

		{
			get { return target; }
			set { target = value; }

		}
		public LeaderClass(int x, int y) : base(x,y,TileClass.tileType.Enemy,2,20,2)
		{
			
		}



		public override Movement returnMove(Movement move = 0)
		{
			//if((Math.Abs(target.getX()-getX()) >= Math.Abs(target.getY() - getY())))
			//{
				int targetX = target.getX();
				int targetY = target.getY();
				int leaderX = this.getX();
				int leaderY = this.getY();
				Random newRoll = new Random();

				if (leaderX > targetX && checkMove(CharacterClass.Movement.Down))
				{
					// Check if you can move down 
					//if it is return movement.down
					//toMove = Movement.Down;
					return CharacterClass.Movement.Down;
				}
				else if (leaderX < targetX && checkMove(CharacterClass.Movement.Up))
				{// Check if you can move up
				 //if it is return movement.up
					return CharacterClass.Movement.Up;
				}
				else if (leaderY > targetY && checkMove(CharacterClass.Movement.Right))
				{// Check if you can move left 
				 //if it is return movement.left
					return CharacterClass.Movement.Right;
				}
				else if (leaderY < targetY && checkMove(CharacterClass.Movement.Left))
				{// Check if you can move right 
				 //if it is return movement.right
					return CharacterClass.Movement.Left;
				}
				else
				{
					int[] possible_moves = { 0, 1, 2, 3 };
					Boolean moveFound = false;
					CharacterClass.Movement direction = CharacterClass.Movement.Nomovement;
					while (!moveFound)
					{
						direction = (CharacterClass.Movement)possible_moves[newRoll.Next(0, possible_moves.Length)];
						if (checkMove(direction))
						{
							moveFound = true;
							return direction;

						}

					}
				}

			//}
			return CharacterClass.Movement.Nomovement;
			
		}
			
		private bool checkMove(CharacterClass.Movement direction)
		{
			if (this.characterVision[(int)direction] is EmptyTileClass)
			{
				return true;
			}
			return false;
		}
	}
}
