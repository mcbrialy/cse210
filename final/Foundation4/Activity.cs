public abstract class Activity
{
    protected string _date;
    protected int _activityLength;
    public Activity(string date, int activityLength)
    {
        _date = date;
        _activityLength = activityLength;
    }

    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();

    public virtual string GetSummary()
    {
        return $"({_activityLength}min)- " + "Distance " + $"{CalculateDistance():F1} miles, " + "Speed: " + $"{CalculateSpeed():F1} mph, " + "Pace: " + $"{CalculatePace():F2} min per mile";
    }
}