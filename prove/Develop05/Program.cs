using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.DisplayMenu();
    }
    private List<Goal> _goalList = new List<Goal>();
    private int _totalScore = 0;
    // private string _fileName = "goals.txt";
    public void DisplayMenu()
    {
        int option = 0;
        while(option != 6)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_totalScore} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("\t1. Simple Goal");
                    Console.WriteLine("\t2. Ongoing Goal");   
                    Console.WriteLine("\t3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    int option2 = int.Parse(Console.ReadLine());

                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int pointsPerCompletion = int.Parse(Console.ReadLine());

                    switch(option2)
                    {
                        case 1:
                            SimpleGoal simpleGoal = new SimpleGoal(name, description, pointsPerCompletion);
                            _goalList.Add(simpleGoal);
                            break;
                        case 2:
                            OngoingGoal ongoingGoal = new OngoingGoal(name, description, pointsPerCompletion);
                            _goalList.Add(ongoingGoal);
                            break;
                        case 3:
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int requiredCompletions = int.Parse(Console.ReadLine());

                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int bonusPoints = int.Parse(Console.ReadLine());

                            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, pointsPerCompletion, bonusPoints, requiredCompletions);
                            _goalList.Add(checklistGoal);
                            break;
                    }
                    break;
                case 2:
                    DisplayGoals();
                    break;
                case 3:
                    Save();
                    break;
                case 4:
                    Load();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    break;

            }
        }
    }
    public void Save()
    {
        Console.Write("What is the name of the file? ");
        string saveFile = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(saveFile))
        {
            outputFile.WriteLine(_totalScore);
            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.WriteGoal());
            }
        }
    }
    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goalList.Count; i++)
        {
            Console.WriteLine(_goalList[i].GetDisplay(i+1));
        }
    }
    public void Load()
    {
        Console.Write("What is the name of the file? ");
        string loadFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(loadFile);
        _totalScore = int.Parse(lines[0]);

        //_goalList.Clear();
        for (int i = 1; i < lines.Length; i++)
        {
            _goalList.Add(CreateGoal(lines[i]));
        }
    }
    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        int userInput = int.Parse(Console.ReadLine());
        Goal accomplishedGoal = _goalList[userInput - 1];
        int pointsEarned = accomplishedGoal.RecordEvent();
        _totalScore += pointsEarned;
        
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        Console.WriteLine($"You now have {_totalScore} points.");

    }
    public Goal CreateGoal(string fileLine)
    {
        string[] parts = fileLine.Split(Goal._delimiter);
        switch(parts[0])
        {
            case "SimpleGoal":
                return new SimpleGoal(parts);
            case "OngoingGoal":
                return new OngoingGoal(parts);
            case "ChecklistGoal":
                return new ChecklistGoal(parts);
        }
        return null;
    }
}