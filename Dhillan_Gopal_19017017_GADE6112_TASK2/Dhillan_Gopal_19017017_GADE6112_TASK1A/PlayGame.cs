using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	public partial class PlayGame : Form
	{
		private GameMenu caller;
		private GameEnginClass ge;
		private int width;
		private int height;

		public PlayGame(int min_width, int max_width, int min_height, int max_height, int num_enemies, bool loadGame, int gold)
		{
			InitializeComponent();
			if (!loadGame)
			{
				ge = new GameEnginClass(min_width, max_width, min_height, max_height, num_enemies, gold);
				width = ge.getWidth();
				height = ge.getHeight();
			}
			else
			{
				ge = new GameEnginClass();
				ge.setMap(GameEnginClass.loadGame());
				width = ge.getWidth();
				height = ge.getHeight();
			}
			redraw();

		}
		public void setCaller(GameMenu caller)
		{
			this.caller = caller;
		}

		private void actionStatus(String action, Boolean success, String meta)
		{
			if (success)
			{
				if (action.Substring(0, 6) == "attack")
				{
					lblActionStatus.ForeColor = Color.Green;
					lblActionStatus.Text = "Action successful!";
					lblActionStatus.Text += '\n' + meta;
				}
				redraw();
			}
			else
			{
				lblActionStatus.ForeColor = Color.Red;
				lblActionStatus.Text = "You can not " + action;
			}
		}

		private void redraw()
		{
			updateMap();
			updatePlayerStats(ge.getHeroStats());
			updateEnemiesRemaining(ge.getEnemiesRemaining());


		}

		private void updateMap()
		{
			TileClass[,] view = ge.getMapView();
			string textview = "";

			for (int i = 0; i < height; ++i)
			{
				for (int j = 0; j < width; ++j)
				{
					textview += this.getRepresentation(view[i, j]) + (j == (width - 1) ? "" : " ");
				}
				textview += '\n';
			}

			lblMapView.Text = textview;
		}

		private void updatePlayerStats(String info)
		{
			lblHeroStats.Text = info;
		}

		private void updateEnemiesRemaining(String info)
		{
			lblEnemiesRemaining.Text = info;
		}

		private char getRepresentation(TileClass type)
		{
			//MessageBox.Show("Type= " + type.type);
			if (type is EmptyTileClass)
			{
				return '.';
			}
			else if (type is HeroClass)
			{
				if (ge.getMap().getHero().IsDead())
				{
					return '.';

				}
				else
				{
					return 'H';
				}
			}
			else if (type is GoblinClass)
			{
				return 'G';
			}
			else if (type is LeaderClass)
			{
				return 'L';
			}
			else if (type is GoldClass)
			{
				return '$';
			}
			else if (type is MeleeWeaponClass)
			{
				if(((MeleeWeaponClass)type).WeaponType == "Longsword")
				{
					return '!';
				}
				else if(((MeleeWeaponClass)type).WeaponType == "Dagger")
				{
					return '^';
				}
			}

			else if (type is RangedWeaponClass)
			{

				if (((RangedWeaponClass)type).WeaponType == "Longbow")
				{
					return '*';
				}
				 if (((RangedWeaponClass)type).WeaponType == "Rifle")
				{
					return '>';
				}
			}
			else if (type is MagesClass)
			{
				return 'M';
			}
			//MessageBox.Show("Type= " + type.type);
			return 'X';
			
		}

		private void PlayGame_Load(object sender, EventArgs e)
		{


		}

		private void btnUp_Click_1(object sender, EventArgs e)
		{
			actionStatus("move up", ge.movePlayer(CharacterClass.Movement.Up), "");
			this.checkGold();
		}

		private void btnLeft_Click_1(object sender, EventArgs e)
		{
			actionStatus("move left", ge.movePlayer(CharacterClass.Movement.Left), "");
			this.checkGold();
		}

		private void btnDown_Click_1(object sender, EventArgs e)
		{
			actionStatus("move down", ge.movePlayer(CharacterClass.Movement.Down), "");
			this.checkGold();
		}

		private void btnRight_Click_1(object sender, EventArgs e)
		{
			actionStatus("move right", ge.movePlayer(CharacterClass.Movement.Right), "");
			this.checkGold();
		}
		private int check(string w,Button b) 
		{
			int i = ge.Shop.getWeaponIndex(w);
			if (i >= 0 && ge.Shop.CanBuy(i))
			{
				b.Enabled = true;
				
			}
			else
			{
				b.Enabled = false;
			}
			return i;
		}
		private void checkGold(HeroClass hero = null)
		{
			this.check("Dagger", btnDagger);
			this.check("Longsword", btnLongsword);
			this.check("Longbow", btnLongbow);
			this.check("Rifle", btnRilfe);
			//MessageBox.Show("LW= " + this.check("Longsword", btnLongsword) + " LB= " + this.check("Longbow", btnLongbow) + " R= " + this.check("Rifle", btnRilfe)+ " D= "+ this.check("Dagger", btnDagger));
		}
		private void btnAttackUp_Click(object sender, EventArgs e)
		{
			String response = ge.attackEnemy(CharacterClass.Movement.Up);
			Boolean success = false;
			if (response[0] == '1')
			{
				success = true;
			}
			actionStatus("attack up", success, response.Substring(1));
		}

		private void btnAttackLeft_Click(object sender, EventArgs e)
		{
			String response = ge.attackEnemy(CharacterClass.Movement.Left);
			Boolean success = false;
			if (response[0] == '1')
			{
				success = true;
			}
			actionStatus("attack left", success, response.Substring(1));
		}

		private void btnAttackDown_Click(object sender, EventArgs e)
		{
			String response = ge.attackEnemy(CharacterClass.Movement.Down);
			Boolean success = false;
			if (response[0] == '1')
			{
				success = true;
			}
			actionStatus("attack down", success, response.Substring(1));
		}

		private void btnAttackRight_Click(object sender, EventArgs e)
		{
			String response = ge.attackEnemy(CharacterClass.Movement.Right);
			Boolean success = false;
			if (response[0] == '1')
			{
				success = true;
			}
			actionStatus("attack right", success, response.Substring(1));
		}

		private void btnSaveGame_Click(object sender, EventArgs e)
		{
			ge.saveGame();
			MessageBox.Show("Your game was saved you may exit the game");
		}

		private void btnDagger_Click(object sender, EventArgs e)
		{
			int i = ge.Shop.getWeaponIndex("Dagger");
			if (i >= 0 && ge.Shop.CanBuy(i))
			{
				ge.Shop.Buy(i);
				lblWeaponCost.Text = ge.Shop.DisplayWeapon(i);
				updatePlayerStats(ge.getHeroStats());
			}
			checkGold();
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int i = ge.Shop.getWeaponIndex("Longsword");
			if (i >= 0 && ge.Shop.CanBuy(i))
			{
				ge.Shop.Buy(i);
				lblWeaponCost.Text = ge.Shop.DisplayWeapon(i);
				updatePlayerStats(ge.getHeroStats());
			}
			checkGold();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int i = ge.Shop.getWeaponIndex("Longbow");
			if (i >= 0 && ge.Shop.CanBuy(i))
			{
				ge.Shop.Buy(i);
				lblWeaponCost.Text = ge.Shop.DisplayWeapon(i);
				updatePlayerStats(ge.getHeroStats());
			}
			checkGold();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int i = ge.Shop.getWeaponIndex("Rifle");
			if (i >= 0 && ge.Shop.CanBuy(i))
			{
				ge.Shop.Buy(i);
				lblWeaponCost.Text = ge.Shop.DisplayWeapon(i);
				updatePlayerStats(ge.getHeroStats());
			}
			checkGold();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}
	}

}
