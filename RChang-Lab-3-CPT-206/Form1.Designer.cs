namespace RChang_Lab_3_CPT_206
{
	partial class StateInformation
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateInformation));
			this.statesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.statesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.statesDataGridView = new System.Windows.Forms.DataGridView();
			this.stateCmboBox = new System.Windows.Forms.ComboBox();
			this.lblDisplayStateInformation = new System.Windows.Forms.Label();
			this.btnDisplay = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtBoxSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.stateInformationDataSet = new RChang_Lab_3_CPT_206.StateInformationDataSet();
			this.statesTableAdapter = new RChang_Lab_3_CPT_206.StateInformationDataSetTableAdapters.StatesTableAdapter();
			this.tableAdapterManager = new RChang_Lab_3_CPT_206.StateInformationDataSetTableAdapters.TableAdapterManager();
			((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).BeginInit();
			this.statesBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statesDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stateInformationDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// statesBindingNavigator
			// 
			this.statesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.statesBindingNavigator.BindingSource = this.statesBindingSource;
			this.statesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.statesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.statesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.statesBindingNavigatorSaveItem});
			this.statesBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.statesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.statesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.statesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.statesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.statesBindingNavigator.Name = "statesBindingNavigator";
			this.statesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.statesBindingNavigator.Size = new System.Drawing.Size(1146, 25);
			this.statesBindingNavigator.TabIndex = 0;
			this.statesBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// statesBindingNavigatorSaveItem
			// 
			this.statesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.statesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statesBindingNavigatorSaveItem.Image")));
			this.statesBindingNavigatorSaveItem.Name = "statesBindingNavigatorSaveItem";
			this.statesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.statesBindingNavigatorSaveItem.Text = "Save Data";
			this.statesBindingNavigatorSaveItem.Click += new System.EventHandler(this.statesBindingNavigatorSaveItem_Click);
			// 
			// statesDataGridView
			// 
			this.statesDataGridView.AutoGenerateColumns = false;
			this.statesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.statesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
			this.statesDataGridView.DataSource = this.statesBindingSource;
			this.statesDataGridView.Location = new System.Drawing.Point(0, 28);
			this.statesDataGridView.Name = "statesDataGridView";
			this.statesDataGridView.Size = new System.Drawing.Size(1145, 487);
			this.statesDataGridView.TabIndex = 1;
			// 
			// stateCmboBox
			// 
			this.stateCmboBox.FormattingEnabled = true;
			this.stateCmboBox.Location = new System.Drawing.Point(257, 568);
			this.stateCmboBox.Name = "stateCmboBox";
			this.stateCmboBox.Size = new System.Drawing.Size(113, 21);
			this.stateCmboBox.TabIndex = 2;
			this.stateCmboBox.SelectedIndexChanged += new System.EventHandler(this.stateCmboBox_SelectedIndexChanged);
			// 
			// lblDisplayStateInformation
			// 
			this.lblDisplayStateInformation.AutoSize = true;
			this.lblDisplayStateInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisplayStateInformation.Location = new System.Drawing.Point(215, 545);
			this.lblDisplayStateInformation.Name = "lblDisplayStateInformation";
			this.lblDisplayStateInformation.Size = new System.Drawing.Size(213, 20);
			this.lblDisplayStateInformation.TabIndex = 3;
			this.lblDisplayStateInformation.Text = "Display State Information";
			// 
			// btnDisplay
			// 
			this.btnDisplay.Location = new System.Drawing.Point(275, 595);
			this.btnDisplay.Name = "btnDisplay";
			this.btnDisplay.Size = new System.Drawing.Size(75, 23);
			this.btnDisplay.TabIndex = 4;
			this.btnDisplay.Text = "&Display";
			this.btnDisplay.UseVisualStyleBackColor = true;
			this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(676, 595);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(85, 43);
			this.btnSearch.TabIndex = 5;
			this.btnSearch.Text = "&Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtBoxSearch
			// 
			this.txtBoxSearch.Location = new System.Drawing.Point(596, 569);
			this.txtBoxSearch.Name = "txtBoxSearch";
			this.txtBoxSearch.Size = new System.Drawing.Size(253, 20);
			this.txtBoxSearch.TabIndex = 6;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(686, 545);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(66, 20);
			this.lblSearch.TabIndex = 7;
			this.lblSearch.Text = "Search";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "StateID";
			this.dataGridViewTextBoxColumn1.HeaderText = "StateID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "StateName";
			this.dataGridViewTextBoxColumn2.HeaderText = "StateName";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Population";
			this.dataGridViewTextBoxColumn3.HeaderText = "Population";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "StateFlagDescription";
			this.dataGridViewTextBoxColumn4.HeaderText = "StateFlagDescription";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "StateFlower";
			this.dataGridViewTextBoxColumn5.HeaderText = "StateFlower";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "StateBird";
			this.dataGridViewTextBoxColumn6.HeaderText = "StateBird";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Colors";
			this.dataGridViewTextBoxColumn7.HeaderText = "Colors";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "ThreeLargestCities";
			this.dataGridViewTextBoxColumn8.HeaderText = "ThreeLargestCities";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "StateCapitol";
			this.dataGridViewTextBoxColumn9.HeaderText = "StateCapitol";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "MedianIncome";
			this.dataGridViewTextBoxColumn10.HeaderText = "MedianIncome";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "ComputerRelatedJobsPercentage";
			this.dataGridViewTextBoxColumn11.HeaderText = "ComputerRelatedJobsPercentage";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			// 
			// statesBindingSource
			// 
			this.statesBindingSource.DataMember = "States";
			this.statesBindingSource.DataSource = this.stateInformationDataSet;
			// 
			// stateInformationDataSet
			// 
			this.stateInformationDataSet.DataSetName = "StateInformationDataSet";
			this.stateInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// statesTableAdapter
			// 
			this.statesTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.StatesTableAdapter = this.statesTableAdapter;
			this.tableAdapterManager.UpdateOrder = RChang_Lab_3_CPT_206.StateInformationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// StateInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(1146, 695);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.txtBoxSearch);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnDisplay);
			this.Controls.Add(this.lblDisplayStateInformation);
			this.Controls.Add(this.stateCmboBox);
			this.Controls.Add(this.statesDataGridView);
			this.Controls.Add(this.statesBindingNavigator);
			this.Name = "StateInformation";
			this.Text = "State Information";
			this.Load += new System.EventHandler(this.StateInformation_Load);
			((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).EndInit();
			this.statesBindingNavigator.ResumeLayout(false);
			this.statesBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.statesDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stateInformationDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private StateInformationDataSet stateInformationDataSet;
		private System.Windows.Forms.BindingSource statesBindingSource;
		private StateInformationDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
		private StateInformationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator statesBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton statesBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView statesDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.ComboBox stateCmboBox;
		private System.Windows.Forms.Label lblDisplayStateInformation;
		private System.Windows.Forms.Button btnDisplay;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtBoxSearch;
		private System.Windows.Forms.Label lblSearch;
	}
}

