


namespace Strings.Models;
public class Car
{
    public string Nomi {get;set;} = "BMW";
    public string Model {get;set;} ="M5 F90";
    public int Year {get; set;} = 2026;
    public double Fuel {get; set;} = 50;

    public void ShowInfo()
    {
        Console.WriteLine($"CarName : {Nomi}\n CarMOdel : {Model}\n YearOfCar {Year}\n RateOfFuel {Fuel}");

    }
    public void Drive(double km)
    {
        double usedFuel = km / 10;
        if (usedFuel > Fuel)
        {
            Console.WriteLine("Not enuogh fuel");
        }
        else
        {
            Fuel -= usedFuel;
            Console.WriteLine($" Car is {km} km moved ");
            Console.WriteLine($"Rate of fuel {Fuel} %");
        }
    }
    public void Refuel(double amount)
    {
        if(Fuel + amount > 100)
        {
            Fuel = 100;
        }
        else
        {
            Fuel += amount;
        }
        Console.WriteLine($"Balance Of fuel {Fuel}");
    }

//     public void Brake()
//     {
//         Console.WriteLine("Cars is stopped ");
//     }
//     public void Drive()
//     {
//         Console.WriteLine("Car is moving ");
//     }
//     public void Print()
//     {
//         Console.WriteLine($"{this.Nomi}: {this.Model}");
//     }

}