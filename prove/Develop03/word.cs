public class Word
{
    private string _word;
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
