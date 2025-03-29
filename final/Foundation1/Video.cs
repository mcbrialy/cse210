public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void Display()
    {
        Console.WriteLine(_title + ", " + _author + ", " + "Length: " + _length + "min");
        Console.WriteLine($"{NumComments()} comments:");
        
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
    public int NumComments()
    {
        return _comments.Count();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}