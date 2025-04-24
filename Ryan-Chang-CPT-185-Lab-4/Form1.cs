using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ryan_Chang_CPT_185_Lab_4
{
	public partial class Form1 : Form
	{
		//Initialize Variables
		double currentPopulation = 0.0;
		double dailyIncreaseFactor = 0.0;
		double days_multiplies	= 0;

		//Initialize Array for storing days and populations
		int[] daysArray;
		double[] populationArray;

		public Form1()
		{
			InitializeComponent();
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{
			try
			{
				currentPopulation = double.Parse(startTextBox.Text);
				dailyIncreaseFactor = double.Parse(percentTextBox.Text) / 100.0;
				days_multiplies = double.Parse(daysTextBox.Text);

				//Initialize array based on the amount of days inputted
				daysArray = new int[(int)days_multiplies];
				populationArray = new double[(int)days_multiplies];
			}
			catch 
			{
				MessageBox.Show("Please enter a correct number for Current Population, Daily Increase(Percentage), and Days");
				return;
			}

			//start loop that stores day and population onto an array
			for (int day = 1; day <= days_multiplies; day++)
			{
				// Add current day and population to the ListBox
				dataListBox.Items.Add($"Day {day}: Population {currentPopulation:F2}");

				// Update the population for the next day
				currentPopulation += currentPopulation * dailyIncreaseFactor;
			}
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			dataListBox.Items.Clear();
			startTextBox.Text = string.Empty;
			percentTextBox.Text = string.Empty;
			daysTextBox.Text = string.Empty;	
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
