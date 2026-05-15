using Strings.Models;


namespace Strings;
internal class Program
{
    private static void Main(string[] args)
    {
        var audio = new Car
        {
            Nomi = "Audio",
            Model = "A 6"
        };
        audio.Print();
        audio.Drive();
        audio.Brake();

        var apple = new Fruit
        {
            Name = "Apple",
            Color = "Yellow",
            Unit = "Count"
        };
        apple.Print();
    }
}

