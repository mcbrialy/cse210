using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Menu();
    }
    static void Menu()
    {   
        int option = 0;
        while (option != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    BreatheActivity breatheActivity = new BreatheActivity("Breathe", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breatheActivity.WelcomeMessage();
                    breatheActivity.DoBreathe();
                    breatheActivity.EndMessage();
                    break;
                case 2:
                    ReflectActivity reflectActivity = new ReflectActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectActivity.WelcomeMessage();
                    reflectActivity.DoReflect();
                    reflectActivity.EndMessage();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.WelcomeMessage();
                    listingActivity.DoListing();
                    listingActivity.EndMessage();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Please input a valid option");
                    break;
            }
        }
    }
}