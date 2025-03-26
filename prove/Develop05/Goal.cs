public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointsPerCompletion;
    public static string _delimiter = "|";
    public Goal(string name, string description, int pointsPerCompletion)
    {
        _name = name;
        _description = description;
        _pointsPerCompletion = pointsPerCompletion;
    }
    public Goal(string[] parts)
    {
        _name = parts[1];
        _description = parts[2];
        _pointsPerCompletion = Convert.ToInt32(parts[3]);
    }
    public abstract int RecordEvent();
    public abstract string GetGoalType();
    public virtual string GetDisplay(int index)
    {
        string result = index + ". [";
        if (GetIsCompleted())
        {
            result += "X";
        }
        else
        {
            result += " ";
        }
        result += "] " + _name + " (" + _description + ")";
        return result;
    }
    public virtual string WriteGoal()
    {
        return GetGoalType() + _delimiter + _name + _delimiter + _description + _delimiter + _pointsPerCompletion; 
    }
    public virtual bool GetIsCompleted()
    {
        return false;
    }
}
    