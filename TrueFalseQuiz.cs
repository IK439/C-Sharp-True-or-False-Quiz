using System;

/* This program runs a simple True/False quiz. 
   It asks the user a series of questions, validates their input, stores their answers, and then calculates and displays their score */

namespace TrueOrFalse
{
  class Program
  {
    static void Main(string[] args)
    {
      // Display welcome message and wait for user to press enter
      Console.WriteLine("Welcome to 'True or False?'");
      Console.WriteLine("\nSee if you can answer all the questions below correctly. \nPress enter to begin:");
      Console.ReadLine();

      // Quiz questions
      string[] questions =
      {
        "Computers get tired if you don't turn them off?",
        "\nPressing the spacebar creates a space?",
        "\nA computer understands emojis better than humans?",
        "\nCode can tell a computer what to do?",
        "\nYou can break a program just by missing one tiny character?"
      };

      // Correct answers corresponding to each question
      bool[] answers = { false, true, false, true, true };

      // Store user responses
      bool[] responses = new bool[questions.Length];

      // Ensure questions and answers match in length
      if (questions.Length != answers.Length)
      {
        Console.WriteLine("Warning! Questions and answers must be the same length.");
        return;
      }

      int askingIndex = 0;

      // Loop through questions array and ask questions
      foreach (string question in questions)
      {
        // Display question
        Console.WriteLine(question);
        Console.WriteLine("True or False?");

        // Read and validate user input
        bool inputBool;
        while (!bool.TryParse(Console.ReadLine(), out inputBool))
        {
          Console.WriteLine("\nPlease respond with 'true' or 'false'");
        }

        // Store the validated response
        responses[askingIndex] = inputBool;
        askingIndex++;
      }

      int score = 0;
      Console.WriteLine();

      for (int i = 0; i < answers.Length; i++)
      {
        // Display correct answer vs user answer
        Console.WriteLine(
          $"Question {i + 1}: Correct answer = {answers[i]}, Your answer = {responses[i]}"
        );

        // Increase score if correct
        if (answers[i] == responses[i])
        {
          score++;
        }
      }
      
      // Display final score
      Console.WriteLine($"\nYou got {score} out of {responses.Length} correct!");
    }
  }
}