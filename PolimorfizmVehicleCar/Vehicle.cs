﻿namespace PolimorfizmVehicleCar
{
    public abstract class Vehicle
    {
        public int Speed { get; protected set; }

        virtual public void SpeedUp()
        {
            Speed++;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($" Speed {Speed} Energy {EnergyType}");
        }

        public abstract Energy EnergyType { get; }
    }
}
