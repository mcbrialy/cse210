using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        int sum = 0;
        int amount = -1;
        int largestNumber = 0;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            sum += number;
            amount += 1;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        float average = (float)sum / amount;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}