using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RChangTicTacToe_CPT_185
{
	public partial class Form1 : Form
	{
		int[,] TicTacToeBox = new int[3, 3];
		int player1 = 1;
		int player2 = 0;
		int turn = 0;
		bool ready = false;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void lblPos0_Click_1(object sender, EventArgs e)
		{
			if (turn % 2 == 0)
			{
				lblPos0.Text = "X";
				//Position 0 is 0,0
				play(0, 0, player1);

			}
			else
			{
				//player 2 turn
				lblPos0.Text = "O";
				play(0, 0, player2);
			}
			turn++;

		}

		private void play(int row, int column, int player)
		{
			TicTacToeBox[row, column] = player;
			checkWinner(player);
		}

		private void checkWinner(int player)
		{
			//horizontal, vertical

			for (int i = 0; i < TicTacToeBox.GetLength(0); i++)
			{
				if ((TicTacToeBox[i, 0] == player && TicTacToeBox[i, 1] == player && TicTacToeBox[i, 1] == player && TicTacToeBox[i, 2] == player)
					|| (TicTacToeBox[0, i] == TicTacToeBox[1, i] && TicTacToeBox[1, i] == player && TicTacToeBox[2, i] == player))
				{
					setWinner(player);
				}


				if ((TicTacToeBox[i, 0] == player && TicTacToeBox[i, 1] == player && TicTacToeBox[i, 2] == player) ||
					(TicTacToeBox[0, i] == player && TicTacToeBox[1, i] == player && TicTacToeBox[2, i] == player))
				{
					setWinner(player);
				}
				//diagonal compare
				if ((TicTacToeBox[0, 0] == player && TicTacToeBox[1, 1] == player && TicTacToeBox[1, 1] == player && TicTacToeBox[2, 2] == player)
					|| (TicTacToeBox[0, 2] == player && TicTacToeBox[1, 1] == player && TicTacToeBox[1, 1] == player && TicTacToeBox[2, 0] == player))
				{
					setWinner(player);
					return;
				}
				if (turn == 8)
				{
					lblWinner.Text = "It's A Tie!!!";
				}
			}
		}

		private void setWinner(int player)
		{
			if (player == 1)
				lblWinner.Text = "Player 1 Wins. X's Rule";
			else
				lblWinner.Text = "Player 2 Wins. O's Rule";
		}

		private void lblPos1_Click(object sender, EventArgs e)
		{
			if (turn % 2 == 0)
			{
				lblPos1.Text = "X";
				//Position 0 is 0,0
				play(0, 1, player1);

			}
			else
			{
				//player 2 turn
				lblPos1.Text = "O";
				play(0, 1, player2);
			}
			turn++;
		}

		private void lblPos2_Click(object sender, EventArgs e)
		{
			if (turn % 2 == 0)
			{
				lblPos2.Text = "X";
				//Position 0 is 0,0
				play(0, 2, player1);

			}
			else
			{
				//player 2 turn
				lblPos2.Text = "O";
				play(0, 2, player2);
			}
			turn++;
		}

		private void lblPos3_Click(object sender, EventArgs e)
		{
			if (turn % 2 == 0)
			{
				lblPos3.Text = "X";
				//Position 0 is 0,0
				play(1, 0, player1);

			}
			else
			{
				//player 2 turn
				lblPos3.Text = "O";
				play(1, 0, player2);
			}
			turn++;
		}

		private void lblPos4_Click_1(object sender, EventArgs e)
		{
			if (turn % 2 == 0)
			{
				lblPos4.Text = "X";
				//Position 0 is 0,0
				play(1, 1, player1);

			}
			else
			{
				//player 2 turn
				lblPos4.Text = "O";
				play(1, 1, player2);
			}
			turn++;
		}

		private void lblPos5_Click_1(object sender, EventArgs e)
		{
			if (turn % 2 == 0)
			{
				lblPos5.Text = "X";
				//Position 0 is 0,0
				play(1, 2, player1);

			}
			else
			{
				//player 2 turn
				lblPos5.Text = "O";
				play(1, 2, player2);
			}
			turn++;
		}

		private void lblPos6_Click_1(object sender, EventArgs e)
		{
			if (turn % 2 == 0)
			{
				lblPos6.Text = "X";
				//Position 0 is 0,0
				play(2, 0, player1);

			}
			else
			{
				//player 2 turn
				lblPos6.Text = "O";
				play(2, 0, player2);
			}
			turn++;
		}

		private void lblPos7_Click_1(object sender, EventArgs e)
		{
			if (turn % 2 == 0)
			{
				lblPos7.Text = "X";
				//Position 0 is 0,0
				play(2, 1, player1);

			}
			else
			{
				//player 2 turn
				lblPos7.Text = "O";
				play(2, 1, player2);
			}
			turn++;
		}

		private void lblPos8_Click_1(object sender, EventArgs e)
		{
			if (turn % 2 == 0)
			{
				lblPos8.Text = "X";
				//Position 0 is 0,0
				play(2, 2, player1);

			}
			else
			{
				//player 2 turn
				lblPos8.Text = "O";
				play(2, 2, player2);
			}
			turn++;
		}

		private void btnNewGame_Click_1(object sender, EventArgs e)
		{
			//Start Game
			//Set Round to Zero
			//build our tic tac toe gridusing a 2d 
			for (int row = 0; row < TicTacToeBox.GetLength(0); row++)
			{
				for (int col = 0; col < TicTacToeBox.GetLength(1); col++)
				{
					//setting tic tac toe box to -1: nothing is entered
					TicTacToeBox[row, col] = -1;
				}
			}
			lblPos0.Text = "";
			lblPos1.Text = "";
			lblPos2.Text = "";
			lblPos3.Text = "";
			lblPos4.Text = "";
			lblPos5.Text = "";
			lblPos6.Text = "";
			lblPos7.Text = "";
			lblPos8.Text = "";
			lblWinner.Text = "";
			MessageBox.Show("Game Ready to Begin");
			ready = true;

		}

		private void btnExit_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		

		private void lblWinner_Click(object sender, EventArgs e)
		{

		}

	}
}
