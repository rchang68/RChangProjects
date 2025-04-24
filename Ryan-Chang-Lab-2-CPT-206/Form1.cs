using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ryan_Chang_Lab_2_CPT_206
{
	public partial class lab2 : Form
	{
		public lab2()
		{
			InitializeComponent();
		}

		private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

		private void lab2_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

		private void btnTotalPopulation_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Total Population is: " + this.cityTableAdapter.TotalPopulation());
		}

		private void btnAvgPopulation_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Average Population is: " + this.cityTableAdapter.AveragePopulation());
		}

		private void btnHighestPopulation_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Total Population is: " + this.cityTableAdapter.MaxPopulation());
		}

		private void btnMinPopulation_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Total Population is: " + this.cityTableAdapter.MinPopulation());
		}
	}
}
