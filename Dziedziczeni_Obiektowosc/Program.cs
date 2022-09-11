using System;

public class Vehicle
{
    public string LicensePlate { get; set; }

    public Vehicle(string licensePlate)
    {
        Console.WriteLine("Konstruktor Vehicle.");
        LicensePlate = licensePlate;
    }


    public void Start()
    {
        Console.WriteLine("Vehicle started." + LicensePlate);
    }
}

public class Car : Vehicle
{
    public Car() : base("AA 123")
    {
        Console.WriteLine("Konstruktor Car.");
    }

    public Car(string licensePlate) : base(licensePlate)
    {
        Console.WriteLine("Konstruktor Car.");
    }

    public void Refuel()
    {
        Console.WriteLine("Car refuel.");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Car toyota = new Car("Toyota ABC 11XZ");
        toyota.Refuel();
        toyota.Start();
        Console.WriteLine();
        Car honda = new Car("Honda XYZ 12345");
        honda.Refuel();
        honda.Start();
        Console.WriteLine();
        Car suzuki = new Car("Suzuzki qwerty12");
        suzuki.Refuel();
        suzuki.Start();
    }
}