using System;

class Program
{
    static public Journal journal = new Journal();
    static public Prompt prompt = new Prompt();

    static void Main(string[] args)
    {
        MenuLoop();

    }
    static void MenuLoop()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        bool repeat = true;
        while (repeat)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string _menuChoice = Console.ReadLine();

            switch(_menuChoice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    Display();
                    break;
                case "3":
                    LoadJournalFile();
                    break;
                case "4":
                    SaveJournalFile();
                    break;
                case "5":
                    repeat = false;
                    break;
                default:
                    Console.WriteLine("Error: Please input a number between 1 and 5.");
                    break;
            }
        }
    }
    static void WriteNewEntry()
    {
        string _randomPrompt = prompt.GeneratePrompt();
        Console.WriteLine($"Random prompt: {_randomPrompt}");
        string _userInput = Console.ReadLine();

        Entry entry = new Entry();
        entry._givenPrompt = _randomPrompt;
        entry._entryText = _userInput;

        journal.AppendEntry(entry);
    }
    static void Display()
    {
        journal.Display();
    }
    public static void SaveJournalFile()
    {
        Console.WriteLine("What is the filename?");
        string _givenFileName = Console.ReadLine();
        journal._fileName = _givenFileName;

        journal.SaveEntries();
    }
    static void LoadJournalFile()
    {
        Console.WriteLine("What is the filename?");
        string _givenFileName = Console.ReadLine();
        journal._fileName = _givenFileName;

        journal.LoadEntries();
    }
}