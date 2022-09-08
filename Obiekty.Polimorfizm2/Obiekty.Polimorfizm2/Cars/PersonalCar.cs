using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiekty.Polimorfizm2.Cars
{
    public class PersonalCar : Car
    {
        public PersonalCar() : base(5000)
        {
        }

        protected override void ShiftUp()
        {
            //throw new NotImplementedException();
        }
    }
}
