
public class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;
    
    public Reference(string book, int chapter, int firstVerse)
    {// for references with one verse
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = 0;
    }
    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {// for references with two or more verses
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }
    public string GetReference()
    {
        if (_lastVerse == 0)
        {
            return $"{_book} {_chapter}:{_firstVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
        }
    }
}