public class OngoingGoal : Goal
{
    public OngoingGoal(string name, string description, int pointsPerCompletion) : base(name, description, pointsPerCompletion)
    {

    }
    public OngoingGoal(string[] parts) : base(parts)
    {

    }
    public override int RecordEvent()
    {
        return _pointsPerCompletion;
    }
    public override string GetGoalType()
    {
        return "OngoingGoal";
    }
}