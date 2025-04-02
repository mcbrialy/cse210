public class Event
{
    protected string _eventType;
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    public Event(string eventType, string eventTitle, string description, string date, string time, Address address)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public void DisplayStandardDetails()
    {
        Console.WriteLine("Standard details:");
        Console.WriteLine($"Event title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine();
    }
    public void DisplayFullDetails()
    {
        Console.WriteLine("Full details:");
        Console.WriteLine($"Event title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine();
    }

    public void DisplayShortDetails()
    {
        Console.WriteLine("Short details:");
        Console.WriteLine($"Event type: {_eventType}");
        Console.WriteLine($"Event title: {_eventTitle}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine();
    }
}