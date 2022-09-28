
global using global::System;

namespace PolimorfizmVehicleCar
{
    class program
    {
        public static void Main(string[] args)


        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Podaj Hasło");
                string haslo = Console.ReadLine();
                if (haslo == "12345")
                {
                    FuelCar Honda = new FuelCar();
                    ElectricCar Tesla = new ElectricCar();

                    Honda.DisplayStatus();
                    Tesla.DisplayStatus();
                    Honda.BluetoothConnection();
                    Tesla.BluetoothConnection();

                    Car HondaAsCar = Honda as Car;
                    Car TeslaAsCar = Tesla as Car;
                    HondaAsCar.DisplayStatus();
                    TeslaAsCar.DisplayStatus();

                    Vehicle HondaAsVehicle = Honda as Vehicle;
                    Vehicle TeslaAsVehicle = Tesla as Vehicle;
                    HondaAsVehicle.DisplayStatus();
                    TeslaAsVehicle.DisplayStatus();


                    IAndroidAuto androidAutoCar = TeslaAsVehicle as IAndroidAuto;
                    androidAutoCar.BluetoothConnection();
                }
                else
                {
                    Console.WriteLine("Błąd");
                }
            }
        }

    }
}