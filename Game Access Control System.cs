using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("____Welcome to Game Access System____");

        Console.WriteLine("\nWhat is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("What is your age?");
        string Input = Console.ReadLine();

        int age;

        if (int.TryParse(Input, out age))
        {
            Console.WriteLine("\n----Game Access----");
            Console.WriteLine($"Welcome {name}");
            Console.WriteLine($"Your age: {age}");

            if (age >= 18)
            {
                Console.WriteLine("Access Level: Full Access");
                Console.WriteLine("Unlocked: Multiplayer + Ranked");
            }
            else
            {
                Console.WriteLine("Access Level: Limited Access");
                Console.WriteLine("Training mode only");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }

    }
}
