public class Swimming : Activity
{
    private double _laps;
    public Swimming(double laps, string date, int activityLength) : base(date, activityLength)
    {
        _laps = laps;
    }
    public override double CalculateDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double CalculatePace()
    {
        return _activityLength / CalculateDistance();
    }
    public override double CalculateSpeed()
    {
        return CalculateDistance() / _activityLength * 60;
    }
    public override string GetSummary()
    {
        return _date + " Swimming " + base.GetSummary();
    }
}