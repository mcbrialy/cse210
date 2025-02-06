using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Cashier!");

        Bin myBin = new Bin("Singles",1.00,25); // Have to create a constructor in bin class in order to pass in these arguments at the time of initialization

        Console.WriteLine(myBin.GetDenomination());
        Console.WriteLine(myBin.GetValue());
        Console.WriteLine(myBin.GetCount());
    }

}