using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ryan_Chang_CPT_185_Lab_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void revenueButton_Click(object sender, EventArgs e)
		{
			decimal classA = 0.0m;
			decimal classB = 0.0m;
			decimal classC = 0.0m;
			decimal classTotal  = 0.0m;
			try
			{

				classA = decimal.Parse(classATextBox.Text) * 15;
				classB = decimal.Parse(classBTextBox.Text) * 12;
				classC = decimal.Parse(classCTextBox.Text) * 9;
				classTotal = classA + classB + classC;
				revenueClassALabel.Text = classA.ToString("c");
				revenueClassBLabel.Text = classB.ToString("c");
				revenueClassCLabel.Text = classC.ToString("c");
				revenueTotalLabel.Text = classTotal.ToString("c");

			}
			catch
			{
				classATextBox.Text = "";
				classBTextBox.Text = "";
				classCTextBox.Text = "";
				revenueClassALabel.Text = "";
				revenueClassBLabel.Text = "";
				revenueClassCLabel.Text = "";

				MessageBox.Show("You inputted the information incorrectly!");
			}


		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			classATextBox.Text = "";
			classBTextBox.Text = "";
			classCTextBox.Text = "";
			revenueClassALabel.Text = "";
			revenueClassBLabel.Text = "";
			revenueClassCLabel.Text = "";
			revenueTotalLabel.Text  = "";
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
