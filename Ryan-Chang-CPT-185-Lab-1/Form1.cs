using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ryan_Chang_CPT_185_Lab_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			text1Label.Text = "Three of Clubs";
		}

		private void card2PicutreBox_Click(object sender, EventArgs e)
		{
			text1Label.Text = "Seven of Diamonds";
		}

		private void card3PicutreBox_Click(object sender, EventArgs e)
		{
			text1Label.Text = "Queen of Diamonds";
		}
		private void card4PicutreBox_Click(object sender, EventArgs e)
		{
			text1Label.Text = "Ten of Hearts";
		}

		private void card5PicutreBox_Click(object sender, EventArgs e)
		{
			text1Label.Text = "Ace of Spades";
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
