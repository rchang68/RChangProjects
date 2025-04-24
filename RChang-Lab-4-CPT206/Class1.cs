using System;
using System.Data;
using System.Linq;

namespace RChang_Lab_4_CPT206
{
	public class StateData
	{
		private DataTable statesTable;

		// Constructor to initialize with a DataTable
		public StateData(DataTable statesTable)
		{
			this.statesTable = statesTable;
		}

		// Method to sort states alphabetically
		public DataView GetSortedStates()
		{
			return new DataView(statesTable)
			{
				Sort = "StateName ASC"
			};
		}

		// Method to search for a state by name
		public DataRow GetStateDetails(string stateName)
		{
			DataRow[] selectedStateData = statesTable.Select($"StateName = '{stateName}'");
			return selectedStateData.Length > 0 ? selectedStateData[0] : null;
		}

		// Method to search for a state with a keyword in any column
		public bool SearchState(string searchText, out DataTable filteredTable)
		{
			searchText = searchText.ToLower();
			bool matchFound = false;

			DataTable resultTable = statesTable.Clone();

			foreach (DataRow row in statesTable.Rows)
			{
				foreach (DataColumn column in statesTable.Columns)
				{
					string columnValue = row[column].ToString().ToLower();

					if (columnValue.Contains(searchText))
					{
						resultTable.ImportRow(row);
						matchFound = true;
						break;
					}
				}
			}

			filteredTable = resultTable;
			return matchFound;
		}
	}
}
