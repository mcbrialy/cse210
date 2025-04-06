using System;

class Program
{
    private static List<Event> _eventsList = new List<Event>();
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("223 Space Dr", "Little Rock", "Arkansas", "USA");
        Address outdoorGatheringAddress = new Address("338 Grassfield Ave", "Chicago", "Illinois", "USA");
        Address receptionAddress = new Address("128 Sickly Ct", "Outer Banks", "North Carolina", "USA");

        Lecture lecture1 = new Lecture("Professor Brand", 52, "Lecture", "Theorems on Space and Relativity", "Keynote speaker Dr. Brand addresses some of today's biggest concerns regarding hot topics in space.", "Dec 2, 2026", "11am", lectureAddress);

        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Cloudy", "Outdoor Gathering", "Play in the Park", "Ages 12 and under invited to the grand opening of Chicago's newest playground.", "July 26, 2025", "12pm", outdoorGatheringAddress);

        Reception reception1 = new Reception("shellycarter@receptionplanners.com", "Reception", "Wedding Reception", "Join Tyler and Sandy to celebrate their wedding.", "May 27, 2025", "7pm", receptionAddress);

        _eventsList.Add(lecture1);
        _eventsList.Add(outdoorGathering1);
        _eventsList.Add(reception1);

        foreach (Event e in _eventsList)
        {
            e.DisplayFullDetails();
            e.DisplayStandardDetails();
            e.DisplayShortDetails();
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
    }
}