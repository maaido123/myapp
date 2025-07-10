using System;
using System.IO;

class Program
{
    const int NumQuestions = 5;
    const string TotalFile = "total.txt";

    static void Main()
    {
        int totalCorrect = File.Exists(TotalFile) && int.TryParse(File.ReadAllText(TotalFile), out int r) ? r : 0;
        Console.Write("Enter your name: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Enter your ID: ");
        string id = Console.ReadLine() ?? "";

        Console.WriteLine("\nMath Operations:\n1. +  2. -  3. *  4. /");
        Console.Write("Choose (1-4): ");
        string? op = Console.ReadLine();
        if (op is not ("1" or "2" or "3" or "4")) return;

        var rnd = new Random();
        string[] questions = new string[NumQuestions];
        int[] answers = new int[NumQuestions];

        for (int i = 0; i < NumQuestions; i++)
        {
            int a = 0, b = 0, res = 0;
            switch (op)
            {
                case "1": a = rnd.Next(1, 30); b = rnd.Next(1, 30); res = a + b; questions[i] = $"{a} + {b}"; break;
                case "2": a = rnd.Next(20, 100); b = rnd.Next(1, 20); res = a - b; questions[i] = $"{a} - {b}"; break;
                case "3": a = rnd.Next(2, 10); b = rnd.Next(2, 10); res = a * b; questions[i] = $"{a} * {b}"; break;
                case "4": b = rnd.Next(2, 10); res = rnd.Next(2, 10); a = b * res; questions[i] = $"{a} / {b}"; break;
            }
            answers[i] = res;
        }

        int correct = 0;
        for (int i = 0; i < NumQuestions; i++)
        {
            Console.Write($"Q{i + 1}: {questions[i]} = ");
            if (int.TryParse(Console.ReadLine(), out int userAns) && userAns == answers[i])
            {
                Console.WriteLine(" Correct!\n");
                correct++;
            }
            else
                Console.WriteLine($"  Incorrect! Correct answer: {answers[i]}\n");
        }

        totalCorrect += correct;
        File.WriteAllText(TotalFile, totalCorrect.ToString());

        Console.WriteLine("\n--- Result ---");
        Console.WriteLine($"Name    : {name}");
        Console.WriteLine($"ID      : {id}");
        Console.WriteLine($"Score   : {correct} / {NumQuestions}");
        Console.WriteLine($"All-time Correct: {totalCorrect}");
        Console.WriteLine($"Date    : {DateTime.Now:yyyy-MM-dd}");
    }
}
