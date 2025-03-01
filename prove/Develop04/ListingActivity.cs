using System.Net.WebSockets;

public class ListingActivity : Activity
{
    private List<string> _promptList;
    public ListingActivity(string title, string desc) : base (title, desc)
    {

    }
    public void DoListing()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayPrompt();
        Console.Write("You may begin in: ");
        Countdown();
        Console.WriteLine();
        ListItems();
    }
    public void DisplayPrompt()
    {
        _promptList = [
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?", 
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        ];

        Random rng = new Random();
        int _randomIndex = rng.Next(_promptList.Count);
        string _selectedPrompt = _promptList[_randomIndex];
        Console.WriteLine();
        Console.WriteLine($"------ {_selectedPrompt} ------");
        Console.WriteLine();
    }

    public void ListItems()
    {
        int _time = _duration;
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_time); // End time is *time* seconds after start time.

        int _itemCount = 0;

        while (DateTime.Now < _endTime)
        {
            Console.Write(">");
            Console.ReadLine();

            _itemCount += 1;
        }

        Console.Write($"You listed {_itemCount} items");
    }
}