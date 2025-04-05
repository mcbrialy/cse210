public class Reception : Event
{
    private string _rsvpInfo;
    public Reception(string rsvpInfo, string eventType, string eventTitle, string description, string date, string time, Address address) : base(eventType, eventTitle, description, date, time, address)
    {
        _rsvpInfo = rsvpInfo;
    }
    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"RSVP: {_rsvpInfo}");
        Console.WriteLine();
    }
}