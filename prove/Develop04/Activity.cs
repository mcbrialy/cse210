public class Activity
{
    private string _title;
    private string _desc;
    private List<string> _animationStrings = new List<string>();
    private List<string> _countList = new List<string>();
    protected DateTime _startTime;
    protected DateTime _endTime;
    protected int _duration; // !! Perhaps make this private and use a GetDuration() method

    public Activity(string title, string desc) // constructor
    {
        _title = title;
        _desc = desc;
    }
    public void WelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title} Activity.");
        Console.WriteLine();
        Console.WriteLine(_desc);
        Console.WriteLine();
        _duration = 0;
        while (_duration < 15)
        {   
            if (_duration != 0)
            {
                Console.WriteLine("Minimum 15 seconds.");
            }
            Console.Write("How long, in seconds, would you like for your session? (minimum 15) ");
            _duration = int.Parse(Console.ReadLine());
        }
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(4);
    }
    public void Spinner(int length)
    {
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(length); // End time is *length* seconds after start time.

        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("—"); //Em dash
        _animationStrings.Add("\\");

        int i = 0;

        while (DateTime.Now < _endTime)
        {
            string s = _animationStrings[i];
            Console.Write(s);
            Thread.Sleep(400);
            Console.Write("\b \b");

            i++;

            if (i >= _animationStrings.Count())
            {
                i = 0;
            }
        }
    }
    
    public void Countdown()
    {
        _countList = ["5", "4", "3", "2", "1"];

        foreach (string count in _countList)
        {
            Console.Write(count);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Spinner(2);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_title} Activity.");
        Spinner(4);
    }
}