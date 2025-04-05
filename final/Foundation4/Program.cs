using System;

class Program
{
    static void Main(string[] args)
    {
        Swimming swim1 = new Swimming(25, "22 Dec 2024", 15);
        Cycling cycle1 = new Cycling(15, "2 Apr 2025", 50);
        Running run1 = new Running(6, "13 Jan 2025", 120);

        Console.WriteLine(swim1.GetSummary());
        Console.WriteLine(cycle1.GetSummary());
        Console.WriteLine(run1.GetSummary());
    }
}