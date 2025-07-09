using System;


//// Variables
//string name = "samsam";
//Console.WriteLine(name);

//string motherName = "maryan Ali";
//Console.WriteLine(motherName);

//string dobString = "1990-06-25";  // Taariikhda dhalashada string ahaan
//Console.WriteLine(dobString);

//// Convert dob string to DateTime
//DateTime dob = DateTime.Parse(dobString);
//Console.WriteLine(dob.ToShortDateString());

//// Calculate age
//DateTime today = DateTime.Today;
//int age = today.Year - dob.Year;
//if (dob > today.AddYears(-age)) age--;
//Console.WriteLine(age);

//string pop = "Somali";
//Console.WriteLine(pop);

//string address = "Galkacyo, Somalia";
//Console.WriteLine(address);

//string telephone = "09000000";
//Console.WriteLine(telephone);

//string sex = "Female";
//Console.WriteLine(sex);

//string status = "Single";
//Console.WriteLine(status);

//string name, motherName, dobString, pop, address ,single , sex,status;
//int tell;
//Console.WriteLine("gali magacaga");
//name = Console.ReadLine();

//Console.WriteLine("gali hooyada");
//motherName =Console.ReadLine();

//Console.WriteLine("gali taariikhda dhalashada");
//dobString = Console.ReadLine();


//Console.WriteLine("gali meesha kudhalatay");
//pop = Console.ReadLine();

//Console.WriteLine("gali address");
//address = Console.ReadLine();

//Console.WriteLine("gali sex");
//sex = Console.ReadLine();


//Console.WriteLine("gali statuskaga");
//status = Console.ReadLine();


//int tiro;
//Random qulxin = new Random(); // random object
// function to generate a random number between 1 and 50


//int loop;
//for (loop = 1; loop <= 10; loop++)
//{
//    tiro = qulxin.Next(1, 50);
//    Console.WriteLine(tiro);

//}


int tiro;
int iskuday = 0; 
Random qulxin = new Random(); // Object Random

int loop;
for (loop = 1; loop <= 10; loop++)
{
    tiro = qulxin.Next(1, 50); // Random 1 ilaa 49
    Console.WriteLine(loop+"\t\t"+tiro);
    iskuday = iskuday + tiro;

}
Console.WriteLine("iskudarka" +iskuday);

using System;
using System.IO;

class Program
{
    static void Main()
    {
        const string totalFile = "total.txt";

        // Read previous total from file or start at 0
        int totalCorrect = 0;
        if (File.Exists(totalFile))
        {
            string content = File.ReadAllText(totalFile);
            int.TryParse(content, out totalCorrect);
        }

        // Student information
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine() ?? string.Empty;

        Console.Write("Please enter your ID: ");
        string id = Console.ReadLine() ?? string.Empty;

        // Choose the type of math operation
        Console.WriteLine("\nMath operations:");
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
        int score = 0;

        for (int i = 0; i < 2; i++)
        {
            Console.Write($"Q{i + 1}: {questions[i, 0]} = ? ");
            string? userInput = Console.ReadLine();

            if (int.TryParse(userInput ?? string.Empty, out int userAnswer))
            {
                if (userAnswer == correctAnswers[i])
                {
                    Console.WriteLine("Correct\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer is: {correctAnswers[i]}\n");
                }
            }
            else
            {
                Console.WriteLine($"Invalid input. The correct answer is: {correctAnswers[i]}\n");
            }
        }

        // Update total correct answers
        totalCorrect += score;
        File.WriteAllText(totalFile, totalCorrect.ToString());

        string date = DateTime.Now.ToString("yyyy-MM-dd");

        // Display result
        Console.WriteLine("\n----- Result -----");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Correct answers: {score} / 2");
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Total correct answers overall: {totalCorrect}");
    }
}
