using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RChang_Lab_3_CPT_206
{
	// Inside detailFrm
	public partial class detailFrm : Form
	{
		private DataRow _stateDataRow;

		public detailFrm(DataRow stateDataRow)
		{
			InitializeComponent();
			_stateDataRow = stateDataRow;
		}

		private void detailFrm_Load(object sender, EventArgs e)
		{
			// Example of accessing values from the DataRow
			lblStateName.Text = "State: " +  _stateDataRow["StateName"].ToString();
			lblPopulation.Text = "Population: " +  _stateDataRow["Population"].ToString();
			lblFlagDescription.Text = "Flag Description: " + _stateDataRow["StateFlagDescription"].ToString();
			lblFlower.Text = "State Flower: " + _stateDataRow["StateFlower"].ToString();
			lblBird.Text = "State Bird: " + _stateDataRow["StateBird"].ToString();
			lblColors.Text = "State Colors: " + _stateDataRow["Colors"].ToString();
			lblThreeLargestCities.Text = "Three Largest Cities: " + _stateDataRow["ThreeLargestCities"].ToString();
			lblCapital.Text = "State Captial: " + _stateDataRow["StateCapitol"].ToString();
			lblMedianIncome.Text = "Median Income: " + _stateDataRow["MedianIncome"].ToString();
			lblComputerJobsPercentage.Text = "Computer Job Percentage: " + _stateDataRow["ComputerRelatedJobsPercentage"].ToString();
		}
	}

}

