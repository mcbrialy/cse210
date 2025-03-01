public class ReflectActivity : Activity
{
    private List<string> _promptList;
    private List<string> _questionList;
    private List<int> _hiddenIndexes;
    public ReflectActivity(string title, string desc) : base (title, desc)
    {

    }
    public void DoReflect()
    {   
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string _userInput = Console.ReadLine();
        while (_userInput != "")
        {
            Console.WriteLine("Invalid input. Please press enter to continue.");
            _userInput = Console.ReadLine();
        }
        if (_userInput.Equals(""))
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            Countdown();

            DisplayQuestions();
        }
    }
    public void DisplayPrompt()
    {
        _promptList = [
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
        ];

        _hiddenIndexes = [];

        Random rng = new Random();
        int _randomIndex = rng.Next(_promptList.Count);
        string _selectedPrompt = _promptList[_randomIndex];
        Console.WriteLine();
        Console.WriteLine($"------ {_selectedPrompt} ------");
        Console.WriteLine();

    }
    public void DisplayQuestions()
    {
        _questionList = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        ];

        int _questionstoAsk = _duration / 15; // This number will be the number of questions displayed.
        
        Console.Clear();

        _hiddenIndexes = [];

        while (_hiddenIndexes.Count < _questionstoAsk)
        {
            Random rng = new Random();
            int _randomIndex = rng.Next(_questionList.Count);
            
            if (!_hiddenIndexes.Contains(_randomIndex))
            {
                string _selectedQuestion = _questionList[_randomIndex];
                Console.WriteLine();
                Console.Write(_selectedQuestion);
                Spinner(15);
                Console.WriteLine();

                _hiddenIndexes.Add(_randomIndex);
            }
        }
        
    }
}