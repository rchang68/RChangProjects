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
	
	public partial class Form1 : Form
	{
		
		public Form1()
		{

			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			//Creating Dictionarys for the Dorms and Meal plan
			Dictionary<string, int> dormPrices = new Dictionary<string, int>
		{
			{ "Allen Hall", 1500 },
			{ "Pike Hall", 1600 },
			{ "Farthing Hall", 1800 },
			{ "University Suites", 2500 }
		};

			Dictionary<string, int> mealPlanPrices = new Dictionary<string, int>
		{
			{ "7 meals per week", 600 },
			{ "14 meals per week", 1200 },
			{ "Unlimited Meals", 1700 }
		};
			if (listBoxDorm.SelectedItem == null || listBoxMealPlan.SelectedItem == null)
			{
				MessageBox.Show("Make sure you select a dorm and Meal Plan!!!");
			}
			else
			{
				int selectedDormPrice = dormPrices[listBoxDorm.SelectedItem.ToString()];
				int selectedMealPlanPrice = mealPlanPrices[listBoxMealPlan.SelectedItem.ToString()];
				int totalCost = selectedDormPrice + selectedMealPlanPrice;
				CalculatedPlan calculatedPlan = new CalculatedPlan(selectedDormPrice, selectedMealPlanPrice, totalCost);
				calculatedPlan.Show();
			}
			
			
		}
	}
}
