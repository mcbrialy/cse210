using System.Runtime.CompilerServices;

public class Word
{
    private string _word;
    // private List<string> _notHidden = new List<string>();
    // Need Word constructor so that each time a word object is passed in, we can use the constructor to store it/use it (I think).
    public Word(string word)
    {
        _word = word;
    }
    public string Hide()
    {
        string hiddenWord = "";
        foreach (char character in _word.ToUpper())
        {
            if (character >= 'A' && character <= 'Z')
            {
                hiddenWord += "_";
            }
            else
            {
                hiddenWord += character;
            }
        }
        _word = hiddenWord;
        return _word;
    }
    public string GetDisplayText()
    {
        return _word;
    }
}
