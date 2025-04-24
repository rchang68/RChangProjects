using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ryan_chang_CPT_185_Lab_5
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

		private void calculateButton_Click(object sender, EventArgs e)
		{
			//Initialize Variables and start calculating the routine Maintenance Total
			double routine_maintenance_total = 0.0;
			double parts = 0.0;
			double labor = 0.0;
			double service_labor = 0.0;
			double sales_tax = 0.07;
			double tax_on_parts = 0.0;
			double total = 0.0;

			//Checking to see if the checkbox's are checked and if so then add to the maintance total
			if (oilChangeCheckbox.Checked == true)
			{
				routine_maintenance_total = routine_maintenance_total + 26;
			}
			if (lubeJobCheckBox.Checked == true)
			{
				routine_maintenance_total = routine_maintenance_total + 18;
			}
			if (inspectionCheckBox.Checked == true)
			{
				routine_maintenance_total = routine_maintenance_total + 15;
			}
			if (replaceMufflerCheckbox.Checked == true)
			{
				routine_maintenance_total = routine_maintenance_total + 100;
			}
			if (tireRotationCheckBox.Checked == true)
			{
				routine_maintenance_total = routine_maintenance_total + 20;
			}
			if (radiatorFlushCheckBox.Checked == true)
			{
				routine_maintenance_total = routine_maintenance_total + 30;
			}
			if (transmissionFlushCheckBox.Checked == true)
			{
				routine_maintenance_total = routine_maintenance_total + 80;
			}
			
			//Make sure Parts is a number
			try
			{
				parts = double.Parse(partsTextBox.Text);
			}
			catch
			{
				MessageBox.Show("You have not inputted a Price Correctly for Parts!");
				partsTextBox.Text = "";
			}

			//Make sure labor is a number
			try
			{
				labor = double.Parse(laborTextBox.Text);
			}
			catch
			{
				MessageBox.Show("You have not inputted a Price Correctly for Labor ($)");
				laborTextBox.Text = "";
			}

			//Calculate and input into the Summary

			service_labor = routine_maintenance_total + labor;
			tax_on_parts = sales_tax * parts;
			total = service_labor + parts + tax_on_parts;

			serviceAndLaborLabel2.Text = service_labor.ToString("c");
			partsSummaryLabel2.Text = parts.ToString("c");
			taxLabel2.Text = tax_on_parts.ToString("c");
			totalFeesLabel2.Text = total.ToString("c");

		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			oilChangeCheckbox.Checked = false;
			lubeJobCheckBox.Checked = false;
			inspectionCheckBox.Checked = false;
			replaceMufflerCheckbox.Checked = false;
			tireRotationCheckBox.Checked = false;
			radiatorFlushCheckBox.Checked = false;
			transmissionFlushCheckBox.Checked = false;
			laborTextBox.Text = "";
			partsTextBox.Text = "";
			serviceAndLaborLabel2.Text = "";
			partsSummaryLabel2.Text = "";
			taxLabel2.Text = "";
			totalFeesLabel2.Text = "";
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
