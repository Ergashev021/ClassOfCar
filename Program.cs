using Strings.Models;


namespace Strings;
internal class Program
{
    private static void Main(string[] args)
    {
        var gm = new Car
        {
            Nomi = "GeneralMotors ",
            Model = "Malibu",
            Year = 2024,
            Fuel = 35
        };
        gm.ShowInfo();
        gm.Drive(250);
        gm.Refuel(80);
        gm.ShowInfo();
        var merc = new Car
        {
            Nomi = "Mercedes Bens",
            Model = "W 124 E500",
            Year = 1994,
            Fuel = 14
        };
        merc.ShowInfo();
        merc.Drive(250);
        merc.Refuel(65);
        merc.Drive(250);
        merc.ShowInfo();


    }
}

