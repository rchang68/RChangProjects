using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassCPT18511._12._2024
{
	public partial class frmPigLatin : Form
	{

		private readonly Dictionary<char, string> morseCodeMap = new Dictionary<char, string>
		{
			{' ', " "}, {',', "--..--"}, {'.', ".-.-.-"},{'?', "..--.."},
			{'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, 
			{'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."}, 
			{'8', "---.."}, {'9', "----."},
			{'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."},
			{'E', "."}, {'F', "..-."}, {'G', "--."}, {'H', "...."},
			{'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
			{'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."},
			{'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
			{'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
			{'Y', "-.--"}, {'Z', "--.."}
        };

		public frmPigLatin()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtBoxUserInput.Text = string.Empty;
			lblMorseCode.Text = "Morse Code: ";
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{ 
			//Step 1: Convert the text to uppercase
			string userInput = txtBoxUserInput.Text.ToUpper();
			//Create List to store morse code after translation
			List<string> morseCodeWords = new List<string>();
			//Loop through each character in the input
			foreach (char character in userInput)
			{
				//Checks if Character is in the Disctionary
				if (morseCodeMap.ContainsKey(character))
				{
					//If yes then add this translates the character to morse code and adds it onto the List
					morseCodeWords.Add(morseCodeMap[character]);
				}
			}

			lblMorseCode.Text = "Morse Code: " + string.Join(" ", morseCodeWords);


		}
	}
}
