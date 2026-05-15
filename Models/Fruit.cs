namespace Strings.Models;

public class Fruit
{
    public string Name;
    public string Color;
    public string Unit;

    public void Print()
    {
        Console.WriteLine($"{Name}  {Color}  {Unit}");
    }
}