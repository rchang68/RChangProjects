namespace Ryan_Chang_Lab_2_CPT_206
{
	partial class lab2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lab2));
			this.cityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.cityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.cityDataGridView = new System.Windows.Forms.DataGridView();
			this.btnTotalPopulation = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cityDBDataSet = new Ryan_Chang_Lab_2_CPT_206.CityDBDataSet();
			this.cityTableAdapter = new Ryan_Chang_Lab_2_CPT_206.CityDBDataSetTableAdapters.CityTableAdapter();
			this.tableAdapterManager = new Ryan_Chang_Lab_2_CPT_206.CityDBDataSetTableAdapters.TableAdapterManager();
			this.btnAvgPopulation = new System.Windows.Forms.Button();
			this.btnHighestPopulation = new System.Windows.Forms.Button();
			this.btnMinPopulation = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).BeginInit();
			this.cityBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cityDBDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// cityBindingNavigator
			// 
			this.cityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.cityBindingNavigator.BindingSource = this.cityBindingSource;
			this.cityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.cityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.cityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cityBindingNavigatorSaveItem});
			this.cityBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.cityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.cityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.cityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.cityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.cityBindingNavigator.Name = "cityBindingNavigator";
			this.cityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.cityBindingNavigator.Size = new System.Drawing.Size(800, 25);
			this.cityBindingNavigator.TabIndex = 0;
			this.cityBindingNavigator.Text = "bindingNavigator1";
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
			// cityBindingNavigatorSaveItem
			// 
			this.cityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cityBindingNavigatorSaveItem.Image")));
			this.cityBindingNavigatorSaveItem.Name = "cityBindingNavigatorSaveItem";
			this.cityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.cityBindingNavigatorSaveItem.Text = "Save Data";
			this.cityBindingNavigatorSaveItem.Click += new System.EventHandler(this.cityBindingNavigatorSaveItem_Click);
			// 
			// cityDataGridView
			// 
			this.cityDataGridView.AllowUserToOrderColumns = true;
			this.cityDataGridView.AutoGenerateColumns = false;
			this.cityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.cityDataGridView.DataSource = this.cityBindingSource;
			this.cityDataGridView.Location = new System.Drawing.Point(12, 28);
			this.cityDataGridView.Name = "cityDataGridView";
			this.cityDataGridView.Size = new System.Drawing.Size(776, 252);
			this.cityDataGridView.TabIndex = 1;
			// 
			// btnTotalPopulation
			// 
			this.btnTotalPopulation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnTotalPopulation.Location = new System.Drawing.Point(13, 302);
			this.btnTotalPopulation.Name = "btnTotalPopulation";
			this.btnTotalPopulation.Size = new System.Drawing.Size(113, 39);
			this.btnTotalPopulation.TabIndex = 2;
			this.btnTotalPopulation.Text = "Get Total Population";
			this.btnTotalPopulation.UseVisualStyleBackColor = false;
			this.btnTotalPopulation.Click += new System.EventHandler(this.btnTotalPopulation_Click);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "CityID";
			this.dataGridViewTextBoxColumn1.HeaderText = "CityID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "City";
			this.dataGridViewTextBoxColumn2.HeaderText = "City";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "State";
			this.dataGridViewTextBoxColumn3.HeaderText = "State";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Population";
			this.dataGridViewTextBoxColumn4.HeaderText = "Population";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// cityBindingSource
			// 
			this.cityBindingSource.DataMember = "City";
			this.cityBindingSource.DataSource = this.cityDBDataSet;
			// 
			// cityDBDataSet
			// 
			this.cityDBDataSet.DataSetName = "CityDBDataSet";
			this.cityDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cityTableAdapter
			// 
			this.cityTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
			this.tableAdapterManager.UpdateOrder = Ryan_Chang_Lab_2_CPT_206.CityDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// btnAvgPopulation
			// 
			this.btnAvgPopulation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAvgPopulation.Location = new System.Drawing.Point(216, 302);
			this.btnAvgPopulation.Name = "btnAvgPopulation";
			this.btnAvgPopulation.Size = new System.Drawing.Size(113, 39);
			this.btnAvgPopulation.TabIndex = 3;
			this.btnAvgPopulation.Text = "Get Average Population";
			this.btnAvgPopulation.UseVisualStyleBackColor = false;
			this.btnAvgPopulation.Click += new System.EventHandler(this.btnAvgPopulation_Click);
			// 
			// btnHighestPopulation
			// 
			this.btnHighestPopulation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnHighestPopulation.Location = new System.Drawing.Point(445, 302);
			this.btnHighestPopulation.Name = "btnHighestPopulation";
			this.btnHighestPopulation.Size = new System.Drawing.Size(113, 39);
			this.btnHighestPopulation.TabIndex = 4;
			this.btnHighestPopulation.Text = "Get Highest Population";
			this.btnHighestPopulation.UseVisualStyleBackColor = false;
			this.btnHighestPopulation.Click += new System.EventHandler(this.btnHighestPopulation_Click);
			// 
			// btnMinPopulation
			// 
			this.btnMinPopulation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnMinPopulation.Location = new System.Drawing.Point(675, 302);
			this.btnMinPopulation.Name = "btnMinPopulation";
			this.btnMinPopulation.Size = new System.Drawing.Size(113, 39);
			this.btnMinPopulation.TabIndex = 5;
			this.btnMinPopulation.Text = "Get Minimum Population";
			this.btnMinPopulation.UseVisualStyleBackColor = false;
			this.btnMinPopulation.Click += new System.EventHandler(this.btnMinPopulation_Click);
			// 
			// lab2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnMinPopulation);
			this.Controls.Add(this.btnHighestPopulation);
			this.Controls.Add(this.btnAvgPopulation);
			this.Controls.Add(this.btnTotalPopulation);
			this.Controls.Add(this.cityDataGridView);
			this.Controls.Add(this.cityBindingNavigator);
			this.Name = "lab2";
			this.Text = "Lab 2";
			this.Load += new System.EventHandler(this.lab2_Load);
			((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).EndInit();
			this.cityBindingNavigator.ResumeLayout(false);
			this.cityBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cityDBDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CityDBDataSet cityDBDataSet;
		private System.Windows.Forms.BindingSource cityBindingSource;
		private CityDBDataSetTableAdapters.CityTableAdapter cityTableAdapter;
		private CityDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator cityBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton cityBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView cityDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.Button btnTotalPopulation;
		private System.Windows.Forms.Button btnAvgPopulation;
		private System.Windows.Forms.Button btnHighestPopulation;
		private System.Windows.Forms.Button btnMinPopulation;
	}
}

