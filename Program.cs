using System;

public class SantaGiftingSystem
{
    public static void Main(string[] args)
    {
        string name;
        int correctAnswers = 0;

        // Get valid user name
        do
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        } while (!IsValidName(name));

        // Define quiz questions and answers
        string[] questions = {
            "What is the capital of France?",
            "What is 2 + 2?",
            "Who wrote 'Romeo and Juliet'?",
            "What is the largest planet in our solar system?",
            "What is the color of the sky on a clear day?"
        };
        string[] answers = { "paris", "4", "shakespeare", "jupiter", "blue" };

        // Ask and evaluate quiz questions
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine(questions[i]);
            Console.Write("Your answer: ");
            string userAnswer = Console.ReadLine().ToLower();

            if (userAnswer == answers[i].ToLower())
            {
                correctAnswers++;
            }
        }

        // Determine and display gifts
        if (correctAnswers > 0)
        {
            Console.WriteLine($"Hey! Mr./Miss {name}, you got {correctAnswers} gift(s) from Santa.");
        }
        else
        {
            Console.WriteLine("Santa is sleeping. Better luck next time!");
        }

        Console.ReadLine(); // Keep console window open
    }

    // Helper function to validate name
    private static bool IsValidName(string name)
    {
        foreach (char c in name)
        {
            if (!char.IsLetter(c))
            {
                return false;
            }
        }
        return !string.IsNullOrEmpty(name);
    }
}