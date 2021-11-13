using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("Choose your difficulty! Input the upper limit for the number range:");

            var upperLimit = int.Parse(Console.ReadLine());

            Console.WriteLine($"Thank you. Now input your guess by typing a number between 1 and {upperLimit}:");

            var random = new Random();
            var number = random.Next(1, upperLimit);

            int guess;

            do
            {
                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("That number is too high. Try again!");
                }
                else if (guess < number)
                {
                    Console.WriteLine("That number is too low. Try again!");
                }
                else
                {
                    Console.WriteLine("Correct. Well done!");
                }
            } while (guess != number);

        }
    }
}
