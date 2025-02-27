public class BreatheActivity : Activity
{
    public BreatheActivity(string title, string desc) : base (title, desc)
    {

    }
    public void DoBreathe()
    {
        int _time = _duration; // This number divided by 10 will be the number of full breath cycles iterated.
        for (int i = _time; i >= 10; i -= 10) //ensures that breath cycles will be completed
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            Countdown();
            Console.WriteLine("Breathe out...");
            Countdown();
            Console.WriteLine();
        }
    }
}