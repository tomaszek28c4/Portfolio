namespace PolimorfizmVehicleCar
{
    public sealed class ElectricCar : Car   //tesla Car dziedziczy po Car
    {
        public ElectricCar() : base("Tesla", "P90") { } //base - ozdziedziczy zmienne string brand i string type z klasy Car
        public override Energy EnergyType => Energy.Electric;

        public void BluetoothConnection()
        {

            Console.WriteLine("Bluetooth Connected");
        }

        public override void SpeedUp()
        {
            Speed += 4;
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Im Tesla ");
            Console.WriteLine();
        }


    }
}
