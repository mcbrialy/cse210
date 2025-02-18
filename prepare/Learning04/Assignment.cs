public class Assignment
{
    private string _studentName;
    private string _topic;
    
    public Assignment()
    {
        _studentName = "No student specified";
        _topic = "No topic specified";
    }
    
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
    
    public string GetStudentName()
    {
        return _studentName;
    }
}