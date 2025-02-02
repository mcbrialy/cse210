
public class Prompt
{
    public List<string> _promptList = new List<string>()
    {
        "How was my day?",
        "What was my favorite thing about today? ",
        "What is something I am grateful for today? ",
        "If I had one thing I could change about today, what would it be? ",
        "How did I see the hand of the Lord in my life today? ",
    };
    string _randomPrompt;
    public string GeneratePrompt()
    {
        Random random = new Random();
        // Generating a random number using the amount of items in the prompts list.
        int _randomIndex = random.Next(_promptList.Count);

        // Using the random number to pick a prompt from the prompts list.
        _randomPrompt = _promptList[_randomIndex];

        //Console.WriteLine($"Prompt: {_randomPrompt}\n");
        return _randomPrompt;
    }

}