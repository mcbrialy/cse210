public class Running : Activity
{
    private double _distance;
    public Running(double distance, string date, int activityLength) : base(date, activityLength)
    {
        _distance = distance;
    }
    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculatePace()
    {
        return _activityLength / _distance;
    }
    public override double CalculateSpeed()
    {
        return _distance / _activityLength * 60;
    }
    public override string GetSummary()
    {
        return _date + " Running " + base.GetSummary();
    }
}