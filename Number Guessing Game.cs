using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("----Number Guessing Game----");

        Random random = new Random();

        while (true)
        {
            int number = random.Next(1, 11);

            while (true)
            {
                Console.WriteLine("Enter a number between 1 to 10: ");
                string input = Console.ReadLine();

                int guess;

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                if (number < guess)
                {
                    Console.WriteLine("\nYour guess is too high!");
                }
                else if (number > guess)
                {
                    Console.WriteLine("\nYour guess is too low!");
                }
                else
                {
                    Console.WriteLine("\nCongratulations! You guessed the number!");
                    break;
                }
            }

            Console.WriteLine("Do you want to play again? (y/n)");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "n")
            {
                break;
            }
        }
        Console.WriteLine("The End!");
    }
}
