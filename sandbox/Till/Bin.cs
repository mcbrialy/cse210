class Bin 
{
    //private makes it so only the software in my bin class can modify it
    private string _denomination;
    private double _value;
    private int _count;
    public Bin(string d, double v, int c)
    {
        // This is a constructor, it always has the same name as the class.
        _denomination = d;
        _value = v;
        _count = c;
    }

    public void Transaction(int count)
    // value parameter should be negative for debit, positive for credit
    {
        _count += count
    }
    public string GetDenomination()
    {
        return _denomination;
    }
    public double GetValue()
    {
        return _value;
    }
    public int GetCount()
    {
        return _count;
    }
    // public void SetCount(int amount)
    // {
    //     _count += amount;
    // }
}