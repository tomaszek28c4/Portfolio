using System.Data;

namespace LekcjaTablice2
{
    class program
    {
        public static void Main(string[] args)
        {
            


        }

        public abstract class human
        {
           // human h = new human();
            public abstract human tomek();
        }

        public class man : human
        {
            public override human tomek()
            {
               return this;
            }
        }

    }






}