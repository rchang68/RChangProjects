namespace InClassCPT18511._12._2024
{
	partial class frmPigLatin
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
			this.txtBoxUserInput = new System.Windows.Forms.TextBox();
			this.btnConvert = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.lblMorseCode = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblEnterText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtBoxUserInput
			// 
			this.txtBoxUserInput.Location = new System.Drawing.Point(168, 133);
			this.txtBoxUserInput.Name = "txtBoxUserInput";
			this.txtBoxUserInput.Size = new System.Drawing.Size(480, 20);
			this.txtBoxUserInput.TabIndex = 0;
			// 
			// btnConvert
			// 
			this.btnConvert.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnConvert.Location = new System.Drawing.Point(55, 320);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(157, 59);
			this.btnConvert.TabIndex = 1;
			this.btnConvert.Text = "&Convert";
			this.btnConvert.UseVisualStyleBackColor = false;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnClear.Location = new System.Drawing.Point(270, 320);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(157, 59);
			this.btnClear.TabIndex = 2;
			this.btnClear.Text = "C&lear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnExit.Location = new System.Drawing.Point(491, 320);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(157, 59);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button1.Location = new System.Drawing.Point(55, 320);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 59);
			this.button1.TabIndex = 1;
			this.button1.Text = "&Convert";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button2.Location = new System.Drawing.Point(270, 320);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(157, 59);
			this.button2.TabIndex = 2;
			this.button2.Text = "C&lear";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// lblMorseCode
			// 
			this.lblMorseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMorseCode.Location = new System.Drawing.Point(77, 212);
			this.lblMorseCode.Name = "lblMorseCode";
			this.lblMorseCode.Size = new System.Drawing.Size(571, 78);
			this.lblMorseCode.TabIndex = 4;
			this.lblMorseCode.Text = "Morse Code: ";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(176, 41);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(445, 31);
			this.lblTitle.TabIndex = 5;
			this.lblTitle.Text = "Morse Code Conversion Program";
			// 
			// lblEnterText
			// 
			this.lblEnterText.AutoSize = true;
			this.lblEnterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnterText.Location = new System.Drawing.Point(77, 137);
			this.lblEnterText.Name = "lblEnterText";
			this.lblEnterText.Size = new System.Drawing.Size(85, 16);
			this.lblEnterText.TabIndex = 6;
			this.lblEnterText.Text = "Enter Text: ";
			// 
			// frmPigLatin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(760, 450);
			this.Controls.Add(this.lblEnterText);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblMorseCode);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.txtBoxUserInput);
			this.Name = "frmPigLatin";
			this.Text = "Morse Code Conversion Lab";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBoxUserInput;
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lblMorseCode;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblEnterText;
	}
}

