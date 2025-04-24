namespace Ryan_Chang_CPT_185_Lab_9
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
			this.lblDorm = new System.Windows.Forms.Label();
			this.listBoxDorm = new System.Windows.Forms.ListBox();
			this.lblMealPlan = new System.Windows.Forms.Label();
			this.listBoxMealPlan = new System.Windows.Forms.ListBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblDorm
			// 
			this.lblDorm.AutoSize = true;
			this.lblDorm.Location = new System.Drawing.Point(92, 53);
			this.lblDorm.Name = "lblDorm";
			this.lblDorm.Size = new System.Drawing.Size(74, 13);
			this.lblDorm.TabIndex = 0;
			this.lblDorm.Text = "Select a Dorm";
			// 
			// listBoxDorm
			// 
			this.listBoxDorm.FormattingEnabled = true;
			this.listBoxDorm.Items.AddRange(new object[] {
            "Allen Hall",
            "Pike Hall",
            "Farthing hall",
            "University Suites"});
			this.listBoxDorm.Location = new System.Drawing.Point(74, 69);
			this.listBoxDorm.Name = "listBoxDorm";
			this.listBoxDorm.Size = new System.Drawing.Size(120, 95);
			this.listBoxDorm.TabIndex = 1;
			// 
			// lblMealPlan
			// 
			this.lblMealPlan.AutoSize = true;
			this.lblMealPlan.Location = new System.Drawing.Point(268, 53);
			this.lblMealPlan.Name = "lblMealPlan";
			this.lblMealPlan.Size = new System.Drawing.Size(96, 13);
			this.lblMealPlan.TabIndex = 2;
			this.lblMealPlan.Text = "Select a Meal Plan";
			// 
			// listBoxMealPlan
			// 
			this.listBoxMealPlan.FormattingEnabled = true;
			this.listBoxMealPlan.Items.AddRange(new object[] {
            "7 meals per week",
            "14 meals per week",
            "Unlimited Meals"});
			this.listBoxMealPlan.Location = new System.Drawing.Point(261, 69);
			this.listBoxMealPlan.Name = "listBoxMealPlan";
			this.listBoxMealPlan.Size = new System.Drawing.Size(120, 95);
			this.listBoxMealPlan.TabIndex = 3;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(271, 216);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(110, 59);
			this.btnCalculate.TabIndex = 4;
			this.btnCalculate.Text = "&Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(74, 216);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(110, 59);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(459, 390);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.listBoxMealPlan);
			this.Controls.Add(this.lblMealPlan);
			this.Controls.Add(this.listBoxDorm);
			this.Controls.Add(this.lblDorm);
			this.Name = "Form1";
			this.Text = "Dorm and Meal Plan Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDorm;
		private System.Windows.Forms.ListBox listBoxDorm;
		private System.Windows.Forms.Label lblMealPlan;
		private System.Windows.Forms.ListBox listBoxMealPlan;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnExit;
	}
}

