using System;

class Program
{
    static void Main(string[] args)
    {
        Product cabbage = new Product("Cabbage", "38204", 2.74, 2);
        Product boots = new Product("Rain boots", "74892", 21.49, 1);
        Product tape = new Product("Scotch Tape", "61930", 5.99, 1);
        Product paper = new Product("Printer paper", "22987", 11.97, 1);

        Address shellys_address = new Address("11 Hillcrest", "Georgetown", "Ohio", "US");
        Customer shelly = new Customer("Shelly Smith", shellys_address);

        Address johns_address = new Address("221B Baker St", "London", "England", "UK");
        Customer john = new Customer("John Watson", johns_address);

        Order order1 = new Order(shelly, cabbage, boots);
        Order order2 = new Order(john, tape, paper);

        Console.WriteLine("ORDER 1:");
        order1.DisplayOrder();

        Console.WriteLine("ORDER 2:");
        order2.DisplayOrder();
        
        

    }
}