namespace Ryan_Chang_CPT_185_Lab_3
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
			this.distanceConvertInputLabel = new System.Windows.Forms.Label();
			this.distanceTextBox = new System.Windows.Forms.TextBox();
			this.fromLabel = new System.Windows.Forms.Label();
			this.toLabel = new System.Windows.Forms.Label();
			this.fromListBox = new System.Windows.Forms.ListBox();
			this.toListBox = new System.Windows.Forms.ListBox();
			this.convertDistanceLabel = new System.Windows.Forms.Label();
			this.convertedDistanceLabel = new System.Windows.Forms.Label();
			this.convertButon = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// distanceConvertInputLabel
			// 
			this.distanceConvertInputLabel.AutoSize = true;
			this.distanceConvertInputLabel.Location = new System.Drawing.Point(37, 33);
			this.distanceConvertInputLabel.Name = "distanceConvertInputLabel";
			this.distanceConvertInputLabel.Size = new System.Drawing.Size(144, 13);
			this.distanceConvertInputLabel.TabIndex = 0;
			this.distanceConvertInputLabel.Text = "Enter a Distance to Convert: ";
			this.distanceConvertInputLabel.Click += new System.EventHandler(this.distanceConvertInputLabel_Click);
			// 
			// distanceTextBox
			// 
			this.distanceTextBox.Location = new System.Drawing.Point(188, 34);
			this.distanceTextBox.Name = "distanceTextBox";
			this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
			this.distanceTextBox.TabIndex = 1;
			// 
			// fromLabel
			// 
			this.fromLabel.AutoSize = true;
			this.fromLabel.Location = new System.Drawing.Point(40, 92);
			this.fromLabel.Name = "fromLabel";
			this.fromLabel.Size = new System.Drawing.Size(30, 13);
			this.fromLabel.TabIndex = 2;
			this.fromLabel.Text = "From";
			// 
			// toLabel
			// 
			this.toLabel.AutoSize = true;
			this.toLabel.Location = new System.Drawing.Point(229, 92);
			this.toLabel.Name = "toLabel";
			this.toLabel.Size = new System.Drawing.Size(20, 13);
			this.toLabel.TabIndex = 3;
			this.toLabel.Text = "To";
			// 
			// fromListBox
			// 
			this.fromListBox.BackColor = System.Drawing.SystemColors.Window;
			this.fromListBox.FormattingEnabled = true;
			this.fromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
			this.fromListBox.Location = new System.Drawing.Point(61, 121);
			this.fromListBox.Name = "fromListBox";
			this.fromListBox.Size = new System.Drawing.Size(120, 95);
			this.fromListBox.TabIndex = 4;
			// 
			// toListBox
			// 
			this.toListBox.BackColor = System.Drawing.SystemColors.Window;
			this.toListBox.FormattingEnabled = true;
			this.toListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
			this.toListBox.Location = new System.Drawing.Point(248, 121);
			this.toListBox.Name = "toListBox";
			this.toListBox.Size = new System.Drawing.Size(120, 95);
			this.toListBox.TabIndex = 5;
			// 
			// convertDistanceLabel
			// 
			this.convertDistanceLabel.AutoSize = true;
			this.convertDistanceLabel.Location = new System.Drawing.Point(74, 248);
			this.convertDistanceLabel.Name = "convertDistanceLabel";
			this.convertDistanceLabel.Size = new System.Drawing.Size(107, 13);
			this.convertDistanceLabel.TabIndex = 6;
			this.convertDistanceLabel.Text = "Converted Distance: ";
			// 
			// convertedDistanceLabel
			// 
			this.convertedDistanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.convertedDistanceLabel.Location = new System.Drawing.Point(213, 247);
			this.convertedDistanceLabel.Name = "convertedDistanceLabel";
			this.convertedDistanceLabel.Size = new System.Drawing.Size(100, 23);
			this.convertedDistanceLabel.TabIndex = 7;
			// 
			// convertButon
			// 
			this.convertButon.Location = new System.Drawing.Point(97, 299);
			this.convertButon.Name = "convertButon";
			this.convertButon.Size = new System.Drawing.Size(75, 23);
			this.convertButon.TabIndex = 8;
			this.convertButon.Text = "Convert";
			this.convertButon.UseVisualStyleBackColor = true;
			this.convertButon.Click += new System.EventHandler(this.convertButon_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(248, 299);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 9;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 450);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.convertButon);
			this.Controls.Add(this.convertedDistanceLabel);
			this.Controls.Add(this.convertDistanceLabel);
			this.Controls.Add(this.toListBox);
			this.Controls.Add(this.fromListBox);
			this.Controls.Add(this.toLabel);
			this.Controls.Add(this.fromLabel);
			this.Controls.Add(this.distanceTextBox);
			this.Controls.Add(this.distanceConvertInputLabel);
			this.Name = "Form1";
			this.Text = "Distance Converter";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label distanceConvertInputLabel;
		private System.Windows.Forms.TextBox distanceTextBox;
		private System.Windows.Forms.Label fromLabel;
		private System.Windows.Forms.Label toLabel;
		private System.Windows.Forms.ListBox fromListBox;
		private System.Windows.Forms.ListBox toListBox;
		private System.Windows.Forms.Label convertDistanceLabel;
		private System.Windows.Forms.Label convertedDistanceLabel;
		private System.Windows.Forms.Button convertButon;
		private System.Windows.Forms.Button exitButton;
	}
}

