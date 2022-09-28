namespace PolimorfizmVehicleCar
{
    public class FuelCar : Car // Honda car dziedziczy po Car
    {

        public FuelCar() : base("Honda", " Civic") { } //base - ozdziedziczy zmienne string brand i string type z klasy Car
        public override Energy EnergyType => Energy.Fuel;
        public void BluetoothConnection()
        {
            Console.WriteLine("Not Connected");
        }

        public override void SpeedUp()
        {
            Speed += 20;

        }
        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Im Honda ");
            Console.WriteLine();
        }


    }
}
