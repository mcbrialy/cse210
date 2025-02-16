using System;
using System.Runtime.InteropServices.Marshalling;

class Program
// Initialize a string for each scripture that contains all the text in the scripture in this class. When you call the Scripture constructor, pass the string in as its parameter.

{    static void Main(string[] args)
    {
        string nephi327 = "And it came to pass that we fled into the wilderness, and the servants of Laban did not overtake us, and we hid ourselves in the cavity of a rock.";
        //string moroni71112 = @"For behold, a bitter fountain cannot bring forth good water; neither can a good fountain bring forth bitter water; wherefore, a man being a servant of the devil cannot follow Christ; and if he follow Christ he cannot be a servant of the devil. Wherefore, all things which are good cometh of God; and that which is evil cometh of the devil; for the devil is an enemy unto God, and fightest against him continually, and inviteth and enticeth to sin, and to do that which is evil continually.";

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

        // Reference reference2 = new Reference("Moroni", 7, 11, 12);
        // Console.WriteLine(reference2.GetReference());

        // Scripture scripture2 = new Scripture(moroni71112);
        // string scripturePrint2 = scripture2.GetWordDisplay();
        // Console.WriteLine(scripturePrint2);

        
    }
}