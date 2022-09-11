using System;
public class Vehicle
{
    public string LicensePlate { get; set; }

    public void Start()
    {
        Console.WriteLine("License plate." + LicensePlate);
        Console.WriteLine("Vehicle started.");
    }
}

public class Car : Vehicle
{
    public void Refuel()
    {
        Console.WriteLine("Car refuel.");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.LicensePlate = "ABC 11XZ";
        car.Refuel();
        car.Start();
    }
}