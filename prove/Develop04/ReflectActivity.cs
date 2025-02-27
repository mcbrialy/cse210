public class ReflectActivity : Activity
{
    private List<string> _promptList;
    public ReflectActivity(string title, string desc) : base (title, desc)
    {

    }
    public void DoReflect()
    {
        Random rng = new Random();
        
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("------");
        Console.WriteLine("When you have something in mind, press enter to continue.");
    }
    public void DisplayPrompt()
    {

    }
}