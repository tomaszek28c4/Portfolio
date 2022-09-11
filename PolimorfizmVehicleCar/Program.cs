
global using global::System;

namespace PolimorfizmVehicleCar
{
    class program
    {
        public static void Main(string[] args)
        {
            FuelCar Honda = new FuelCar();
            ElectricCar Tesla = new ElectricCar();

            Honda.DisplayStatus();
            Tesla.DisplayStatus();
            Honda.BluetoothConnection();
            Tesla.BluetoothConnection();

            //Car HondaAsCar = Honda as Car;
            //Car TeslaAsCar = Tesla as Car;
           // HondaAsCar.DisplayStatus();
           // TeslaAsCar.DisplayStatus();

           // Vehicle HondaAsVehicle = Honda as Vehicle;
           // Vehicle TeslaAsVehicle = Tesla as Vehicle;
           // HondaAsVehicle.DisplayStatus();
            // TeslaAsVehicle.DisplayStatus();


            //IAndroidAuto androidAutoCar = TeslaAsVehicle as IAndroidAuto;
            // androidAutoCar.BluetoothConnection();


        }
    }
}