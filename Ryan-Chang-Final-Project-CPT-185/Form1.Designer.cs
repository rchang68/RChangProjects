namespace Ryan_Chang_Final_Project_CPT_185
{
	partial class toDoList
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.txtBoxTitle = new System.Windows.Forms.TextBox();
			this.txtBoxDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblToDoTitle = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.toDoListView = new System.Windows.Forms.DataGridView();
			this.lblDueDate = new System.Windows.Forms.Label();
			this.txtBoxDueDate = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.toDoListView)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(12, 19);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(1309, 76);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "To-Do List";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtBoxTitle
			// 
			this.txtBoxTitle.Location = new System.Drawing.Point(15, 98);
			this.txtBoxTitle.Name = "txtBoxTitle";
			this.txtBoxTitle.Size = new System.Drawing.Size(1299, 26);
			this.txtBoxTitle.TabIndex = 1;
			// 
			// txtBoxDescription
			// 
			this.txtBoxDescription.Location = new System.Drawing.Point(15, 150);
			this.txtBoxDescription.Name = "txtBoxDescription";
			this.txtBoxDescription.Size = new System.Drawing.Size(1299, 26);
			this.txtBoxDescription.TabIndex = 2;
			// 
			// lblDescription
			// 
			this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescription.Location = new System.Drawing.Point(12, 127);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(1303, 20);
			this.lblDescription.TabIndex = 3;
			this.lblDescription.Text = "Description: ";
			// 
			// lblToDoTitle
			// 
			this.lblToDoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblToDoTitle.Location = new System.Drawing.Point(12, 75);
			this.lblToDoTitle.Name = "lblToDoTitle";
			this.lblToDoTitle.Size = new System.Drawing.Size(1303, 20);
			this.lblToDoTitle.TabIndex = 4;
			this.lblToDoTitle.Text = "Title:";
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(198, 230);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(269, 29);
			this.btnClear.TabIndex = 5;
			this.btnClear.Text = "&Clear Text Box";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(482, 230);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(269, 29);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.Text = "&Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(767, 230);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(269, 29);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(1052, 230);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(269, 29);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// toDoListView
			// 
			this.toDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.toDoListView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.toDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.toDoListView.Location = new System.Drawing.Point(21, 286);
			this.toDoListView.Name = "toDoListView";
			this.toDoListView.Size = new System.Drawing.Size(1300, 394);
			this.toDoListView.TabIndex = 9;
			// 
			// lblDueDate
			// 
			this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDueDate.Location = new System.Drawing.Point(12, 179);
			this.lblDueDate.Name = "lblDueDate";
			this.lblDueDate.Size = new System.Drawing.Size(1303, 20);
			this.lblDueDate.TabIndex = 10;
			this.lblDueDate.Text = "Due Date:";
			// 
			// txtBoxDueDate
			// 
			this.txtBoxDueDate.Location = new System.Drawing.Point(15, 198);
			this.txtBoxDueDate.Name = "txtBoxDueDate";
			this.txtBoxDueDate.Size = new System.Drawing.Size(1299, 26);
			this.txtBoxDueDate.TabIndex = 11;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(12, 230);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(180, 29);
			this.btnExit.TabIndex = 12;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// toDoList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1333, 692);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtBoxDueDate);
			this.Controls.Add(this.lblDueDate);
			this.Controls.Add(this.toDoListView);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.lblToDoTitle);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.txtBoxDescription);
			this.Controls.Add(this.txtBoxTitle);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "toDoList";
			this.Text = "To-Do List";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.toDoListView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtBoxTitle;
		private System.Windows.Forms.TextBox txtBoxDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblToDoTitle;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DataGridView toDoListView;
		private System.Windows.Forms.Label lblDueDate;
		private System.Windows.Forms.TextBox txtBoxDueDate;
		private System.Windows.Forms.Button btnExit;
	}
}

