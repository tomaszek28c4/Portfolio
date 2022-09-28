namespace PolimorfizmVehicleCar
{
    public abstract class Car : Vehicle, IAndroidAuto  //dziedziczy po Vehicle
    {
        public Car(string brand, string type)
        {
            Brand = brand;
            Type = type;
        }

        public string Brand { get; set; }
        public string Type { get; set; }

        public override Energy EnergyType => Energy.NotSpecified;

        public virtual bool AccidentOcurred()
        {
            throw new NotImplementedException();
        }

        public void BluetoothConnection()
        {
            Console.WriteLine();
        }

        public override void DisplayStatus()
        {
            Console.WriteLine($" Speed {Speed} Brand {Brand} Type {Type} Energy {EnergyType} ");
        }


    }


}
