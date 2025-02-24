public class Bird : Animal
{
    private string _sound;
    public Bird(string name) : base(name)
    {
        _sound = "Caw";
    }
    public void MakeSound()
    {
        Console.WriteLine($"{GetName()} says {_sound}\a");
    }
}