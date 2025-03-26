public class SimpleGoal: Goal
{
    private bool _isCompleted;
    public SimpleGoal(string name, string description, int pointsPerCompletion) : base(name, description, pointsPerCompletion)
    {
        _isCompleted = false;
    }
    public SimpleGoal(string[] parts) : base(parts)
    {
        _isCompleted = bool.Parse(parts[4]);
    }
    public override int RecordEvent()
    {
        if(_isCompleted)
        {
            return 0;
        }
        _isCompleted = true;
        return _pointsPerCompletion;
    }
    public override string GetGoalType()
    {
        return "SimpleGoal";
    }
    public override string WriteGoal()
    {
        return base.WriteGoal() + _delimiter + _isCompleted;
    }
    public override bool GetIsCompleted()
    {
        return _isCompleted;
    }
}