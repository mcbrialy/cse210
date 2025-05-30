public class OutdoorGathering : Event
{
    private string _weatherForecast;
    public OutdoorGathering(string weatherForecast, string eventType, string eventTitle, string description, string date, string time, Address address) : base(eventType, eventTitle, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }
    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Forecast: {_weatherForecast}");
        Console.WriteLine();
    }
}