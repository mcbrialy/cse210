public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string speaker, int capacity, string eventType, string eventTitle, string description, string date, string time, Address address) : base(eventType, eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine();
    }
}
