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
		public LeaderClass(int x, int y, TileClass heroTarget) : base(x, y, TileClass.tileType.Enemy, 2, 20, 2)
		{
			this.target = heroTarget;
			base.weapon = new MeleeWeaponClass(MeleeWeaponClass.Types.Longsword);
		}
		private int DistanceTo(int x1, int y1, int x2, int y2)
		{
			return (Math.Abs(x1 - x2) + Math.Abs(y1 - y2));
		}
		public bool checkIfIsLowerDistance(Movement move, TileClass source, TileClass target, int maxDistanceToTarget)
		{
			int x1 = source.getX();
			int y1 = source.getY();

			int x2 = target.getX();
			int y2= target.getY();
			if (move == Movement.Up) { --y1; }
			else if (move == Movement.Down) { ++y1; }
			else if (move == Movement.Left) { --x1; }
			else if (move == Movement.Right) { ++x1; }

			if (this.DistanceTo(x1,y1,x2,y2) < maxDistanceToTarget)
			{
				return true;
			}
			return false;
		}


		public override Movement returnMove(Movement move = 0)
		{
			int leaderX = this.getX();
			int leaderY = this.getY();
			int targetX = _target.getX();
			int targetY = _target.getY();
			Random newRoll = new Random();
			int minDistaceToTarget = Int32.MaxValue;
			CharacterClass.Movement direction = CharacterClass.Movement.Nomovement;
			//string toLog = " ";

			if (leaderX > targetX && checkMove(CharacterClass.Movement.Left))
			{
				// Check if you can move down 
				//if it is return movement.down

				if (this.checkIfIsLowerDistance(Movement.Left, this, _target, minDistaceToTarget))
				{
					direction = Movement.Left;
					minDistaceToTarget = this.DistanceTo(leaderX, leaderY, targetX, targetY);
					//toLog = "LX > HX, ND = " + minDistaceToTarget + " DIR = " + direction+" \n";
				}
				//return CharacterClass.Movement.Down;
			}
			
			if (leaderX < targetX && checkMove(CharacterClass.Movement.Right))
			{// Check if you can move up
			 //if it is return movement.up
				if (this.checkIfIsLowerDistance(Movement.Right, this, _target, minDistaceToTarget))
				{
					direction = Movement.Right;
					minDistaceToTarget = this.DistanceTo(leaderX, leaderY, targetX, targetY);
					//toLog = "LX < HX, ND = " + minDistaceToTarget + " DIR = " + direction + " \n";
				}
				//return CharacterClass.Movement.Up;
			}
			 
			if (leaderY > targetY && checkMove(CharacterClass.Movement.Up))
			{// Check if you can move left 
			 //if it is return movement.left
				if (this.checkIfIsLowerDistance(Movement.Up, this, _target, minDistaceToTarget))
				{
					direction = Movement.Up;
					minDistaceToTarget  = this.DistanceTo(leaderX, leaderY, targetX, targetY);
					//toLog = "LY > HY, ND = " + minDistaceToTarget + " DIR = " + direction + " \n";
				}
				//return CharacterClass.Movement.Right;
			}
			 
			if (leaderY < targetY && checkMove(CharacterClass.Movement.Down))
			{// Check if you can move right 
			 //if it is return movement.right
				if (this.checkIfIsLowerDistance(Movement.Down, this, _target, minDistaceToTarget))
				{
					direction = Movement.Down;
					minDistaceToTarget  = this.DistanceTo(leaderX, leaderY, targetX, targetY);
					//toLog = "LY < HY, ND = " + minDistaceToTarget + " DIR = " + direction + " \n";
				}
				//return CharacterClass.Movement.Left;
			}
			if (direction == Movement.Nomovement)
			{
				int[] possible_moves = { 0, 1, 2, 3 };
				Boolean moveFound = false;
				while (!moveFound)
				{
					direction = (CharacterClass.Movement)possible_moves[newRoll.Next(0, possible_moves.Length)];
					if (checkMove(direction))
					{
						moveFound = true;
						//return direction;
						//toLog = "randMove =" + direction + " \n";
					}
				}
			}
			//System.Windows.Forms.MessageBox.Show(toLog+"LX ="+ leaderX+" LY ="+leaderY+" HX ="+targetX+" HY ="+targetY+" Move=" + direction);
			return direction;
			//return CharacterClass.Movement.Nomovement;
			
		}
			
		private bool checkMove(CharacterClass.Movement direction)
		{
			if (this.characterVision[(int)direction] is EmptyTileClass)
			{
				return true;
			}
			return false;
		}
		public override string ToString()
		{
			string infoDisplay = "";
			infoDisplay += this.hasWeapon() ? "Equipped: " + weapon.WeaponType : "Barehanded: ";
			infoDisplay += "Leader";
			infoDisplay += "(20/20HP)";
			infoDisplay += " at [ " + x.ToString() + ", " + y.ToString() + "] with Longsword";
			infoDisplay += "("+ (this.weapon.Durability * this.weapon.Cost)+  " DMG)";
			
			return infoDisplay;
		}

	}
}
