using System;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_num = randomGenerator.Next(1, 101);

        int guess = -1;
        
        while (guess != magic_num)
        {
            Console.Write("Input your guess: ");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess > magic_num)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic_num)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}