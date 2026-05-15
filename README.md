# Car Class Project 🚗

This project is a simple C# console application that simulates a Car model with basic behaviors like driving, refueling, and displaying information.

## Features

- Store car information (Name, Model, Year)
- Fuel system (0 - 100%)
- Drive method (fuel decreases based on distance)
- Refuel method (fuel increases but cannot exceed 100%)
- ShowInfo method (prints car details)

## Rules

- Every 10 km consumes 1% fuel
- Fuel cannot go below 0%
- Fuel cannot exceed 100%

## Example Usage

```csharp
Car car = new Car();

car.Nomi = "Mercedes Benz";
car.Model = "W124 E500";
car.Year = 1994;
car.Fuel = 50;

car.ShowInfo();

car.Drive(100);

car.Refuel(30);

car.ShowInfo();
