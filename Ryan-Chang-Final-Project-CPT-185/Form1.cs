using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ryan_Chang_Final_Project_CPT_185
{
	public partial class toDoList : Form
	{
		public toDoList()
		{
			InitializeComponent();
		}

		//Initialize our Data Source
		DataTable todoList = new DataTable();
		bool isEditing = false;
		StreamWriter reader;
		
		private void Form1_Load(object sender, EventArgs e)
		{
			//Create Columns for our data source
			todoList.Columns.Add("Title");
			todoList.Columns.Add("Description");
			todoList.Columns.Add("Due Date");

			//Get the grid on front end to read from data source just created+
			toDoListView.DataSource = todoList;

			//Load the txt file onto the data source
			try
			{
				if (File.Exists("toDoList.txt"))
				{
					// Clear existing rows in the DataTable
					todoList.Rows.Clear();

					// Read lines from the file
					string[] lines = File.ReadAllLines("toDoList.txt");

					foreach (string line in lines)
					{
						// Split the lines into columns based comma
						string[] columns = line.Split(',');

						// Add the data as a new row in the DataTable
						if (columns.Length == 3) // Ensure there are exactly 3 columns
						{
							todoList.Rows.Add(columns[0], columns[1], columns[2]);
						}
					}
					MessageBox.Show("Data loaded successfully!");
				}
				else
				{
					MessageBox.Show("No saved data file found.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading the list: {ex.Message}");
			}
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			//Clear the Text Boxes
			txtBoxTitle.Text = "";
			txtBoxDescription.Text = "";
			txtBoxDueDate.Text = "";
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			//allows us to edit datetable
			isEditing = true;
			//Find data from table and fill out the text box
			txtBoxTitle.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
			txtBoxDescription.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
			txtBoxDueDate.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[2].ToString();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
			}
			catch(Exception ex)
			{
				//If an error is thrown
				MessageBox.Show("Please click on an Item on the list!!");
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (txtBoxTitle.Text != "" && txtBoxDueDate.Text != "")
			{

				if (isEditing)
				{
					todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = txtBoxTitle.Text;
					todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = txtBoxDescription.Text;
					todoList.Rows[toDoListView.CurrentCell.RowIndex]["Due Date"] = txtBoxDueDate.Text;
				}
				else
				{
					//Add to database
					todoList.Rows.Add(txtBoxTitle.Text, txtBoxDescription.Text, txtBoxDueDate.Text);
				}
				//Clear Text Boxes
				txtBoxTitle.Text = "";
				txtBoxDescription.Text = "";
				txtBoxDueDate.Text = "";
				isEditing = false;
				try
				{
					using (StreamWriter writer = new StreamWriter("toDoList.txt"))
					{
						foreach (DataRow row in todoList.Rows)
						{
							// Write each row as a comma separated line
							writer.WriteLine($"{row["Title"]},{row["Description"]},{row["Due Date"]}");
						}
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error saving the list: {ex.Message}");
				}
			}
			else
			{
				MessageBox.Show("Make sure to enter a title and due date!");
			}
		}
	}
}
