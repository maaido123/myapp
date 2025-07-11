using System;

class Barnaamij
{
    static void Main()
    {
        CollectUserInfo();
        GenerateRandomNumbers();
    }

    static void CollectUserInfo()
    {
        Console.Write("Magac: ");
        string name = Console.ReadLine();

        Console.Write("Hooyo: ");
        string mother = Console.ReadLine();

        Console.Write("Dhalasho (yyyy-mm-dd): ");
        DateTime dob = DateTime.Parse(Console.ReadLine());

        Console.Write("Jinsi: ");
        string sex = Console.ReadLine();

        Console.Write("Status: ");
        string status = Console.ReadLine();

        int age = CalculateAge(dob);

        Console.WriteLine($"\n{name}, {mother}, {dob.ToShortDateString()}, Da'da: {age}, {sex}, {status}");
    }

    static int CalculateAge(DateTime dob)
    {
        int age = DateTime.Today.Year - dob.Year;
        if (dob > DateTime.Today.AddYears(-age)) age--;
        return age;
    }

    static void GenerateRandomNumbers()
    {
        int total = 0;
        Random rand = new Random();

        Console.WriteLine("\nTirooyin Random:");
        for (int i = 1; i <= 10; i++)
        {
            int num = rand.Next(1, 50);
            Console.WriteLine($"{i}: {num}");
            total += num;
        }

        Console.WriteLine("Isku darka: " + total);
    }
}
