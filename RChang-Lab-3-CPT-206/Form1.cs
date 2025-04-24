using System;
using System.Data;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using RChang_Lab_4_CPT206; // Import the class library

namespace RChang_Lab_3_CPT_206
{
	public partial class StateInformation : Form
	{
		private StateData stateDataHandler; // Create an instance of the library class

		public StateInformation()
		{
			InitializeComponent();
		}

		private void StateInformation_Load(object sender, EventArgs e)
		{
			// Load data into the DataSet
			this.statesTableAdapter.Fill(this.stateInformationDataSet.States);

			// Initialize the StateData object
			stateDataHandler = new StateData(this.stateInformationDataSet.States);

			// Populate the ComboBox using the sorted list from the library
			stateCmboBox.DataSource = stateDataHandler.GetSortedStates();
			stateCmboBox.DisplayMember = "StateName";
		}

		private void btnDisplay_Click(object sender, EventArgs e)
		{
			string inputState = stateCmboBox.Text;

			// Use the library method to retrieve state details
			DataRow stateDataRow = stateDataHandler.GetStateDetails(inputState);

			if (stateDataRow != null)
			{
				// Pass the dataRow into the details form
				detailFrm newDetailForm = new detailFrm(stateDataRow);
				newDetailForm.ShowDialog();
			}
			else
			{
				MessageBox.Show("State not found.");
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string searchText = txtBoxSearch.Text.ToLower();

			if (!string.IsNullOrEmpty(searchText))
			{
				// Use the library method to filter the states
				if (stateDataHandler.SearchState(searchText, out DataTable filteredResults))
				{
					this.statesTableAdapter.Fill(this.stateInformationDataSet.States);
				}
				else
				{
					MessageBox.Show("Nothing matches your search!");
					txtBoxSearch.Text = "";
				}
			}
		}
	}
}
