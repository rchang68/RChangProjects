namespace Ryan_Chang_CPT_185_Lab_2
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
			this.ticketsSoldLabel1 = new System.Windows.Forms.Label();
			this.ticketsSoldLabel2 = new System.Windows.Forms.Label();
			this.classALabel = new System.Windows.Forms.Label();
			this.classBLabel = new System.Windows.Forms.Label();
			this.classCLabel = new System.Windows.Forms.Label();
			this.classATextBox = new System.Windows.Forms.TextBox();
			this.classBTextBox = new System.Windows.Forms.TextBox();
			this.classCTextBox = new System.Windows.Forms.TextBox();
			this.revenueLabel = new System.Windows.Forms.Label();
			this.classARevenueLabel = new System.Windows.Forms.Label();
			this.classBRevenueLabel = new System.Windows.Forms.Label();
			this.classCRevenueLabel = new System.Windows.Forms.Label();
			this.revenueButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.revenueClassALabel = new System.Windows.Forms.Label();
			this.revenueClassBLabel = new System.Windows.Forms.Label();
			this.revenueClassCLabel = new System.Windows.Forms.Label();
			this.totalLabel = new System.Windows.Forms.Label();
			this.revenueTotalLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ticketsSoldLabel1
			// 
			this.ticketsSoldLabel1.AutoSize = true;
			this.ticketsSoldLabel1.Location = new System.Drawing.Point(137, 74);
			this.ticketsSoldLabel1.Name = "ticketsSoldLabel1";
			this.ticketsSoldLabel1.Size = new System.Drawing.Size(66, 13);
			this.ticketsSoldLabel1.TabIndex = 0;
			this.ticketsSoldLabel1.Text = "Tickets Sold";
			// 
			// ticketsSoldLabel2
			// 
			this.ticketsSoldLabel2.AutoSize = true;
			this.ticketsSoldLabel2.Location = new System.Drawing.Point(156, 97);
			this.ticketsSoldLabel2.Name = "ticketsSoldLabel2";
			this.ticketsSoldLabel2.Size = new System.Drawing.Size(159, 26);
			this.ticketsSoldLabel2.TabIndex = 1;
			this.ticketsSoldLabel2.Text = "Enter the number of tickets sold \r\nfor each class of seats";
			this.ticketsSoldLabel2.Click += new System.EventHandler(this.label1_Click);
			// 
			// classALabel
			// 
			this.classALabel.AutoSize = true;
			this.classALabel.Location = new System.Drawing.Point(196, 160);
			this.classALabel.Name = "classALabel";
			this.classALabel.Size = new System.Drawing.Size(45, 13);
			this.classALabel.TabIndex = 2;
			this.classALabel.Text = "Class A:";
			// 
			// classBLabel
			// 
			this.classBLabel.AutoSize = true;
			this.classBLabel.Location = new System.Drawing.Point(196, 194);
			this.classBLabel.Name = "classBLabel";
			this.classBLabel.Size = new System.Drawing.Size(45, 13);
			this.classBLabel.TabIndex = 3;
			this.classBLabel.Text = "Class B:";
			// 
			// classCLabel
			// 
			this.classCLabel.AutoSize = true;
			this.classCLabel.Location = new System.Drawing.Point(199, 228);
			this.classCLabel.Name = "classCLabel";
			this.classCLabel.Size = new System.Drawing.Size(48, 13);
			this.classCLabel.TabIndex = 4;
			this.classCLabel.Text = "Class C: ";
			// 
			// classATextBox
			// 
			this.classATextBox.Location = new System.Drawing.Point(273, 160);
			this.classATextBox.Name = "classATextBox";
			this.classATextBox.Size = new System.Drawing.Size(100, 20);
			this.classATextBox.TabIndex = 5;
			// 
			// classBTextBox
			// 
			this.classBTextBox.Location = new System.Drawing.Point(273, 194);
			this.classBTextBox.Name = "classBTextBox";
			this.classBTextBox.Size = new System.Drawing.Size(100, 20);
			this.classBTextBox.TabIndex = 6;
			// 
			// classCTextBox
			// 
			this.classCTextBox.Location = new System.Drawing.Point(273, 228);
			this.classCTextBox.Name = "classCTextBox";
			this.classCTextBox.Size = new System.Drawing.Size(100, 20);
			this.classCTextBox.TabIndex = 7;
			// 
			// revenueLabel
			// 
			this.revenueLabel.AutoSize = true;
			this.revenueLabel.Location = new System.Drawing.Point(416, 74);
			this.revenueLabel.Name = "revenueLabel";
			this.revenueLabel.Size = new System.Drawing.Size(104, 13);
			this.revenueLabel.TabIndex = 8;
			this.revenueLabel.Text = "Revenue Generated";
			// 
			// classARevenueLabel
			// 
			this.classARevenueLabel.AutoSize = true;
			this.classARevenueLabel.Location = new System.Drawing.Point(442, 124);
			this.classARevenueLabel.Name = "classARevenueLabel";
			this.classARevenueLabel.Size = new System.Drawing.Size(48, 13);
			this.classARevenueLabel.TabIndex = 9;
			this.classARevenueLabel.Text = "Class A: ";
			// 
			// classBRevenueLabel
			// 
			this.classBRevenueLabel.AutoSize = true;
			this.classBRevenueLabel.Location = new System.Drawing.Point(442, 158);
			this.classBRevenueLabel.Name = "classBRevenueLabel";
			this.classBRevenueLabel.Size = new System.Drawing.Size(45, 13);
			this.classBRevenueLabel.TabIndex = 10;
			this.classBRevenueLabel.Text = "Class B:";
			// 
			// classCRevenueLabel
			// 
			this.classCRevenueLabel.AutoSize = true;
			this.classCRevenueLabel.Location = new System.Drawing.Point(442, 192);
			this.classCRevenueLabel.Name = "classCRevenueLabel";
			this.classCRevenueLabel.Size = new System.Drawing.Size(48, 13);
			this.classCRevenueLabel.TabIndex = 11;
			this.classCRevenueLabel.Text = "Class C: ";
			// 
			// revenueButton
			// 
			this.revenueButton.Location = new System.Drawing.Point(273, 289);
			this.revenueButton.Name = "revenueButton";
			this.revenueButton.Size = new System.Drawing.Size(75, 57);
			this.revenueButton.TabIndex = 15;
			this.revenueButton.Text = "Calculate\r\nRevenue";
			this.revenueButton.UseVisualStyleBackColor = true;
			this.revenueButton.Click += new System.EventHandler(this.revenueButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(387, 289);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(75, 57);
			this.clearButton.TabIndex = 16;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(496, 289);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 57);
			this.exitButton.TabIndex = 17;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// revenueClassALabel
			// 
			this.revenueClassALabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.revenueClassALabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.revenueClassALabel.Location = new System.Drawing.Point(496, 124);
			this.revenueClassALabel.Name = "revenueClassALabel";
			this.revenueClassALabel.Size = new System.Drawing.Size(100, 23);
			this.revenueClassALabel.TabIndex = 18;
			this.revenueClassALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// revenueClassBLabel
			// 
			this.revenueClassBLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.revenueClassBLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.revenueClassBLabel.Location = new System.Drawing.Point(494, 158);
			this.revenueClassBLabel.Name = "revenueClassBLabel";
			this.revenueClassBLabel.Size = new System.Drawing.Size(100, 23);
			this.revenueClassBLabel.TabIndex = 19;
			this.revenueClassBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// revenueClassCLabel
			// 
			this.revenueClassCLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.revenueClassCLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.revenueClassCLabel.Location = new System.Drawing.Point(496, 192);
			this.revenueClassCLabel.Name = "revenueClassCLabel";
			this.revenueClassCLabel.Size = new System.Drawing.Size(100, 23);
			this.revenueClassCLabel.TabIndex = 20;
			this.revenueClassCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// totalLabel
			// 
			this.totalLabel.AutoSize = true;
			this.totalLabel.Location = new System.Drawing.Point(447, 238);
			this.totalLabel.Name = "totalLabel";
			this.totalLabel.Size = new System.Drawing.Size(37, 13);
			this.totalLabel.TabIndex = 21;
			this.totalLabel.Text = "Total: ";
			// 
			// revenueTotalLabel
			// 
			this.revenueTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.revenueTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.revenueTotalLabel.Location = new System.Drawing.Point(494, 233);
			this.revenueTotalLabel.Name = "revenueTotalLabel";
			this.revenueTotalLabel.Size = new System.Drawing.Size(100, 23);
			this.revenueTotalLabel.TabIndex = 22;
			this.revenueTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1059, 647);
			this.Controls.Add(this.revenueTotalLabel);
			this.Controls.Add(this.totalLabel);
			this.Controls.Add(this.revenueClassCLabel);
			this.Controls.Add(this.revenueClassBLabel);
			this.Controls.Add(this.revenueClassALabel);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.revenueButton);
			this.Controls.Add(this.classCRevenueLabel);
			this.Controls.Add(this.classBRevenueLabel);
			this.Controls.Add(this.classARevenueLabel);
			this.Controls.Add(this.revenueLabel);
			this.Controls.Add(this.classCTextBox);
			this.Controls.Add(this.classBTextBox);
			this.Controls.Add(this.classATextBox);
			this.Controls.Add(this.classCLabel);
			this.Controls.Add(this.classBLabel);
			this.Controls.Add(this.classALabel);
			this.Controls.Add(this.ticketsSoldLabel2);
			this.Controls.Add(this.ticketsSoldLabel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ticketsSoldLabel1;
		private System.Windows.Forms.Label ticketsSoldLabel2;
		private System.Windows.Forms.Label classALabel;
		private System.Windows.Forms.Label classBLabel;
		private System.Windows.Forms.Label classCLabel;
		private System.Windows.Forms.TextBox classATextBox;
		private System.Windows.Forms.TextBox classBTextBox;
		private System.Windows.Forms.TextBox classCTextBox;
		private System.Windows.Forms.Label revenueLabel;
		private System.Windows.Forms.Label classARevenueLabel;
		private System.Windows.Forms.Label classBRevenueLabel;
		private System.Windows.Forms.Label classCRevenueLabel;
		private System.Windows.Forms.Button revenueButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Label revenueClassALabel;
		private System.Windows.Forms.Label revenueClassBLabel;
		private System.Windows.Forms.Label revenueClassCLabel;
		private System.Windows.Forms.Label totalLabel;
		private System.Windows.Forms.Label revenueTotalLabel;
	}
}

