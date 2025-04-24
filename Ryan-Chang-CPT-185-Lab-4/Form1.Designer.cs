namespace Ryan_Chang_CPT_185_Lab_4
{
	partial class Form1
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
			this.startLabel = new System.Windows.Forms.Label();
			this.percentLabel = new System.Windows.Forms.Label();
			this.daysLabel = new System.Windows.Forms.Label();
			this.startTextBox = new System.Windows.Forms.TextBox();
			this.percentTextBox = new System.Windows.Forms.TextBox();
			this.daysTextBox = new System.Windows.Forms.TextBox();
			this.exitButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.calculateButton = new System.Windows.Forms.Button();
			this.percentLabel2 = new System.Windows.Forms.Label();
			this.dataListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// startLabel
			// 
			this.startLabel.AutoSize = true;
			this.startLabel.Location = new System.Drawing.Point(47, 36);
			this.startLabel.Name = "startLabel";
			this.startLabel.Size = new System.Drawing.Size(146, 13);
			this.startLabel.TabIndex = 0;
			this.startLabel.Text = "Starting number of organisms:";
			// 
			// percentLabel
			// 
			this.percentLabel.AutoSize = true;
			this.percentLabel.Location = new System.Drawing.Point(47, 71);
			this.percentLabel.Name = "percentLabel";
			this.percentLabel.Size = new System.Drawing.Size(178, 13);
			this.percentLabel.TabIndex = 1;
			this.percentLabel.Text = "Average daily increase (Percetage): ";
			// 
			// daysLabel
			// 
			this.daysLabel.AutoSize = true;
			this.daysLabel.Location = new System.Drawing.Point(47, 107);
			this.daysLabel.Name = "daysLabel";
			this.daysLabel.Size = new System.Drawing.Size(136, 13);
			this.daysLabel.TabIndex = 2;
			this.daysLabel.Text = "Number of days to multiply: ";
			// 
			// startTextBox
			// 
			this.startTextBox.Location = new System.Drawing.Point(229, 36);
			this.startTextBox.Name = "startTextBox";
			this.startTextBox.Size = new System.Drawing.Size(100, 20);
			this.startTextBox.TabIndex = 3;
			// 
			// percentTextBox
			// 
			this.percentTextBox.Location = new System.Drawing.Point(229, 71);
			this.percentTextBox.Name = "percentTextBox";
			this.percentTextBox.Size = new System.Drawing.Size(100, 20);
			this.percentTextBox.TabIndex = 4;
			// 
			// daysTextBox
			// 
			this.daysTextBox.Location = new System.Drawing.Point(229, 99);
			this.daysTextBox.Name = "daysTextBox";
			this.daysTextBox.Size = new System.Drawing.Size(100, 20);
			this.daysTextBox.TabIndex = 5;
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(50, 177);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "&Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(150, 177);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(75, 23);
			this.clearButton.TabIndex = 7;
			this.clearButton.Text = "&Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(251, 177);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(75, 23);
			this.calculateButton.TabIndex = 8;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// percentLabel2
			// 
			this.percentLabel2.AutoSize = true;
			this.percentLabel2.Location = new System.Drawing.Point(335, 74);
			this.percentLabel2.Name = "percentLabel2";
			this.percentLabel2.Size = new System.Drawing.Size(15, 13);
			this.percentLabel2.TabIndex = 9;
			this.percentLabel2.Text = "%";
			// 
			// dataListBox
			// 
			this.dataListBox.FormattingEnabled = true;
			this.dataListBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.dataListBox.Location = new System.Drawing.Point(427, 24);
			this.dataListBox.Name = "dataListBox";
			this.dataListBox.Size = new System.Drawing.Size(211, 368);
			this.dataListBox.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataListBox);
			this.Controls.Add(this.percentLabel2);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.daysTextBox);
			this.Controls.Add(this.percentTextBox);
			this.Controls.Add(this.startTextBox);
			this.Controls.Add(this.daysLabel);
			this.Controls.Add(this.percentLabel);
			this.Controls.Add(this.startLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label startLabel;
		private System.Windows.Forms.Label percentLabel;
		private System.Windows.Forms.Label daysLabel;
		private System.Windows.Forms.TextBox startTextBox;
		private System.Windows.Forms.TextBox percentTextBox;
		private System.Windows.Forms.TextBox daysTextBox;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Label percentLabel2;
		private System.Windows.Forms.ListBox dataListBox;
	}
}

