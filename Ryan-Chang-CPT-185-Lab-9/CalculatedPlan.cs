using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ryan_Chang_CPT_185_Lab_9
{
	public partial class CalculatedPlan : Form
	{
		public CalculatedPlan(int dormPrice, int mealPlanPrice, int totalCost)
		{
			InitializeComponent();

			// Display the values in labels or other UI elements
			lblTotal.Text = $"Dorm Price: ${dormPrice}\n";
			lblTotal.Text += $"Meal Plan Price: ${mealPlanPrice}\n";
			lblTotal.Text += $"Total Cost: ${totalCost}";
		}


		private void CalculatedPlan_Load(object sender, EventArgs e)
		{

		}
	}
}
