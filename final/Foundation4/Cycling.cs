public class Cycling : Activity
{
    private double _speed;
    public Cycling(double speed, string date, int activityLength): base(date, activityLength)
    {
        _speed = speed;
    }
    public override double CalculateDistance()
    {
        return _speed / 60 * _activityLength;
    }
    public override double CalculatePace()
    {
        return 60 / _speed;
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override string GetSummary()
    {
        return _date + " Cycling " + base.GetSummary();
    }
}