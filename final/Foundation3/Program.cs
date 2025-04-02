using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("223 Space Dr", "Little Rock", "Arkansas", "USA");
        Address outdoorGatheringAddress = new Address("338 Grassfield Ave", "Chicago", "Illinois", "USA");
        Address receptionAddress = new Address("128 Sickly Ct", "Outer Banks", "North Carolina", "USA");

        Lecture lecture1 = new Lecture("Professor Brand", 52, "Lecture", "Theorems on Space and Relativity", "Keynote speaker Dr. Brand addresses some of today's biggest concerns regarding hot topics in space.", "Dec 2, 2026", "11am", lectureAddress);

        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Cloudy", "Outdoor Gathering", "Play in the Park", "Ages 12 and under invited to the grand opening of Chicago's newest playground.", "July 26, 2025", "12pm", outdoorGatheringAddress);

        Reception reception1 = new Reception("shellycarter@receptionplanners.com", "Reception", "Wedding Reception", "Join Tyler and Sandy to celebrate their wedding.", "May 27, 2025", "7pm", receptionAddress);

        Console.WriteLine("LECTURE:");
        lecture1.DisplayFullDetails();
        lecture1.DisplayStandardDetails();
        lecture1.DisplayShortDetails();

        Console.WriteLine("OUTDOOR GATHERING:");
        outdoorGathering1.DisplayFullDetails();
        outdoorGathering1.DisplayStandardDetails();
        outdoorGathering1.DisplayShortDetails();

        Console.WriteLine("RECEPTION:");
        reception1.DisplayFullDetails();
        reception1.DisplayStandardDetails();
        reception1.DisplayShortDetails();
    }
}