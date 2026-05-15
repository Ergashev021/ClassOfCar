


namespace Strings.Models;
public class Car
{
    public string Nomi {get;set;} = "BMW";
    public string Model {get;set;} ="M5 F90";

    public void Brake()
    {
        Console.WriteLine("Cars is stopped ");
    }
    public void Drive()
    {
        Console.WriteLine("Car is moving ");
    }
    public void Print()
    {
        Console.WriteLine($"{this.Nomi}: {this.Model}");
    }

}