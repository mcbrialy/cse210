public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _requiredCompletions;
    private int _actualCompletions;
    public ChecklistGoal(string name, string description, int pointsPerCompletion, int bonusPoints, int requiredCompletions) : base(name, description, pointsPerCompletion)
    {
        _bonusPoints = bonusPoints;
        _requiredCompletions = requiredCompletions;
        _actualCompletions = 0;
    }
    public ChecklistGoal(string[] parts) : base(parts)
    {
        _bonusPoints = Convert.ToInt32(parts[4]);
        _requiredCompletions = Convert.ToInt32(parts[5]);
        _actualCompletions = Convert.ToInt32(parts[6]);
    }
    public override string GetDisplay(int index)
    {
        return base.GetDisplay(index) + " -- Currently Completed: " + _actualCompletions + "/" + _requiredCompletions;
    }
    public override int RecordEvent()
    {
        if(GetIsCompleted())
        {
            return 0;
        }

        _actualCompletions++;

        if(GetIsCompleted())
        {
            return _pointsPerCompletion + _bonusPoints;
        }

        return _pointsPerCompletion;
    }
    public override string GetGoalType()
    {
        return "ChecklistGoal";
    }
    public override string WriteGoal()
    {
        return base.WriteGoal() + _delimiter + _bonusPoints + _delimiter + _requiredCompletions + _delimiter + _actualCompletions;
    }
    public override bool GetIsCompleted()
    {
        return _actualCompletions == _requiredCompletions;
    }
}