using System;
using System.IO;

class Program
{
    static void Main()
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string dailyTotalFile = $"total_{date}.txt";

        // Read previous daily total from file or start at 0
        int dailyTotalCorrect = 0;
        if (File.Exists(dailyTotalFile))
        {
            string content = File.ReadAllText(dailyTotalFile);
            int.TryParse(content, out dailyTotalCorrect);
        }

        // User info
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine() ?? string.Empty;

        Console.Write("Please enter your ID: ");
        string id = Console.ReadLine() ?? string.Empty;

        // Choose quiz type
        Console.WriteLine("\nTypes of calculations:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter your choice (1-4): ");
        string choice = Console.ReadLine() ?? string.Empty;

        string[,] questions = new string[2, 1];
        int[] correctAnswers = new int[2];

        bool validChoice = true;

        switch (choice)
        {
            case "1":
                questions[0, 0] = "17 + 5"; correctAnswers[0] = 22;
                questions[1, 0] = "33 + 7"; correctAnswers[1] = 40;
                break;
            case "2":
                questions[0, 0] = "20 - 5"; correctAnswers[0] = 15;
                questions[1, 0] = "100 - 33"; correctAnswers[1] = 67;
                break;
            case "3":
                questions[0, 0] = "3 * 4"; correctAnswers[0] = 12;
                questions[1, 0] = "7 * 6"; correctAnswers[1] = 42;
                break;
            case "4":
                questions[0, 0] = "12 / 4"; correctAnswers[0] = 3;
                questions[1, 0] = "50 / 10"; correctAnswers[1] = 5;
                break;
            default:
                validChoice = false;
                Console.WriteLine("Invalid choice!");
                break;
        }

        if (!validChoice)
            return;

        Console.WriteLine("\n--- Questions ---");
        int correctCount = 0;

        for (int i = 0; i < 2; i++)
        {
            Console.Write($"Q{i + 1}: {questions[i, 0]} = ? ");
            string? userInput = Console.ReadLine();

            if (int.TryParse(userInput ?? string.Empty, out int userAnswer))
            {
                if (userAnswer == correctAnswers[i])
                {
                    Console.WriteLine("Correct\n");
                    correctCount++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer is: {correctAnswers[i]}\n");
                }
            }
            else
            {
                Console.WriteLine($"Invalid answer. The correct answer is: {correctAnswers[i]}\n");
            }
        }

        // Update daily total correct answers
        dailyTotalCorrect += correctCount;
        File.WriteAllText(dailyTotalFile, dailyTotalCorrect.ToString());

        // Output results
        Console.WriteLine("\n----- Results -----");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Correct answers this session: {correctCount} / 2");
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Total correct answers today: {dailyTotalCorrect}");
    }
}
