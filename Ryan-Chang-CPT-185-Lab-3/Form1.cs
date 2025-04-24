using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ryan_Chang_CPT_185_Lab_3
{
	public partial class Form1 : Form
	{
		// Creating a dictionary to hold the Conversions
		private Dictionary<(string, string), double> conversionFactors = new Dictionary<(string, string), double>
		{
			{("Inches", "Feet"), 1.0 / 12},
			{("Inches", "Yards"), 1.0 / 36},
			{("Feet", "Inches"), 12},
			{("Feet", "Yards"), 1.0 / 3},
			{("Yards", "Inches"), 36},
			{("Yards", "Feet"), 3}
		};

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void convertButon_Click(object sender, EventArgs e)
		{
			double distanceValue;

			// Make sure that Distance is a valid Int,
			if (double.TryParse(distanceTextBox.Text, out distanceValue))
			{
				// Put the entry in From and To into the variables for the dictionary
				string fromUnit = fromListBox.SelectedItem.ToString();
				string toUnit = toListBox.SelectedItem.ToString();

				//If From and To is the same give this error
				if (fromUnit == toUnit)
				{
					MessageBox.Show("You cannot put the same input for From and To!");
				}
				else
				{
					// Format the inputs so the dictionary can read it
					var conversion = (fromUnit, toUnit);
						
						// Multiply the distance entered by the value returned in the Dictionary
						double convertedValue = distanceValue * conversionFactors[conversion];
						//Output the value
						convertedDistanceLabel.Text = $"{convertedValue} {toUnit}";
					
				}
			}
			else
			{
				//if the distance isn't an integer
				convertedDistanceLabel.Text = "Please enter a valid number.";
			}
		}

		private void distanceConvertInputLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
