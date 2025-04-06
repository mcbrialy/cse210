using System;

class Program
{
    private static List<Activity> _activitiesList = new List<Activity>();
    static void Main(string[] args)
    {
        Swimming swim1 = new Swimming(25, "22 Dec 2024", 15);
        Cycling cycle1 = new Cycling(15, "2 Apr 2025", 50);
        Running run1 = new Running(6, "13 Jan 2025", 120);

        _activitiesList.Add(swim1);
        _activitiesList.Add(cycle1);
        _activitiesList.Add(run1);

        foreach (Activity activity in _activitiesList) 
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}