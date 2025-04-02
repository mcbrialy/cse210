public class Reception : Event
{
    private string _rsvpInfo;
    public Reception(string rsvpInfo, string eventType, string eventTitle, string description, string date, string time, Address address) : base(eventType, eventTitle, description, date, time, address)
    {
        _rsvpInfo = rsvpInfo;
    }
}