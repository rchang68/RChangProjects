using System;
using System.Collections.Generic;
using System.IO;

class DriverLicenseExam
{
	static void Main()
	{
		// Array to store the correct answers
		string[] correctAnswers = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };

		// Array to store the student's answers
		string[] studentAnswers = new string[20];

		// Try to read the student's answers from the file
		try
		{
			studentAnswers = File.ReadAllLines("StudentAnswers.txt");

			if (studentAnswers.Length != 20)
			{
				Console.WriteLine("Error: The file must contain exactly 20 answers. Each Line should contain the letter of your answer choice!");
				return;
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error reading file: " + ex.Message);
			return;
		}

		// Variables to keep track of correct and incorrect answers
		int correctCount = 0;
		List<int> incorrectQuestions = new List<int>();

		// Compare each answer and count correct and incorrect answers
		for (int i = 0; i < correctAnswers.Length; i++)
		{
			if (studentAnswers[i].Trim().ToUpper() == correctAnswers[i])
			{
				correctCount++;
			}
			else
			{
				incorrectQuestions.Add(i + 1); // Store the question number
			}
		}

		// Calculate total incorrect answers and determine pass/fail
		int incorrectCount = 20 - correctCount;
		bool passed = correctCount >= 15;

		// Display results
		Console.WriteLine(passed ? "The student passed the exam." : "The student failed the exam.");
		Console.WriteLine($"Total correct answers: {correctCount}");
		Console.WriteLine($"Total incorrect answers: {incorrectCount}");

		// Display list of incorrect questions
		if (incorrectQuestions.Count > 0)
		{
			Console.WriteLine("Questions answered incorrectly:");
			foreach (int question in incorrectQuestions)
			{
				Console.WriteLine($"Question {question}");
			}
		}
	}
}
