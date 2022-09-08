using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiekty.Polimorfizm2.Cars
{
    public abstract class Car
    {
        protected int Rounds;
        protected int RoundsShiftUp;

        protected Car(int roundsShiftUp)
        {

        }

        //public abstract void Tank(int litres);

        public virtual void SpeedUp(int progress)
        {
            Rounds += progress;
            if (Rounds >= RoundsShiftUp)
            {
                ShiftUp();
                // ?? Rounds ?
            }
        }

        protected abstract void ShiftUp();
    }
}
