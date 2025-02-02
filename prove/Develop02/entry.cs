
using System.Reflection.Metadata;

public class Entry
{
    public string _entryDateTime = DateTime.Now.ToString("yyyy-MM-dd");
    public string _entryText;
    public string _givenPrompt;

    public void Display()
    {

        Console.WriteLine($"Date: {_entryDateTime} - Prompt: {_givenPrompt}");
        Console.WriteLine(_entryText);
    }
    public void Save(StreamWriter outputFile)
    {
        outputFile.WriteLine(_entryDateTime);
        outputFile.WriteLine(_givenPrompt);
        outputFile.WriteLine(_entryText);
    }
    public void Load(string[] lines, int i)
    {
        _entryDateTime = lines[i];
        _givenPrompt = lines[i+1];
        _entryText = lines[i+2];
    }

}