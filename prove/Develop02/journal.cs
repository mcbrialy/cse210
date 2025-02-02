using System.IO;
public class Journal
{
    public List<Entry> _entryList { get; set; }
    public string _fileName;
    public Journal()
    {
        _entryList = new List<Entry>();
    }
    public void AppendEntry(Entry e)
    {
        _entryList.Add(e);
    }
    public void Display()
    {
        foreach (Entry e in _entryList)
        {
            e.Display();
        }
    }
    public void SaveEntries()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry e in _entryList)
            {
                e.Save(outputFile);
            }
        }
    }
    public void LoadEntries()
    {
        _entryList.Clear();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        
        for (int i = 0;i<lines.Length-2;i+=3)
        {
            Entry entry = new Entry();
            entry.Load(lines, i);
            AppendEntry(entry);
        }
    }
}