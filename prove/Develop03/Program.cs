using System;
using System.Runtime.InteropServices.Marshalling;

class Program
// Initialize a string for each scripture that contains all the text in the scripture in this class. When you call the Scripture constructor, pass the string in as its parameter.

{    static void Main(string[] args)
    {
        string nephi327 = "And it came to pass that we fled into the wilderness, and the servants of Laban did not overtake us, and we hid ourselves in the cavity of a rock.";
        
        Reference reference1 = new Reference("1 Nephi", 3, 27);
        Console.WriteLine(reference1.GetReference());

        Scripture scripture1 = new Scripture(reference1, nephi327);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture1.GetWordDisplay());
            Console.WriteLine("Press Enter to hide three random words or type 'quit' to exit.");

            string userInput = Console.ReadLine();
            if (userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break; // Exit the loop if the user inputs 'quit'
            }
            else if (userInput.Equals(""))
            {
                if (!scripture1.HideThreeRandomWords())
                {
                    break;
                }
                
            }
        }
    }
}