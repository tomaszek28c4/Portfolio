namespace Lekcja100
{

    class Calculate
    {
        public virtual void Oblicz()
        {
            Console.WriteLine("Klasa Calculate");
        }
    }
    class First : Calculate
    {

        public override void Oblicz()
        {
            for (int i = 1; i <=2; i++)
            {
                string wysokosc;
                string szerokosc;


                double user1;
                double user2;
                double pole;



                Console.WriteLine("Rozpoczęzecie Programu");
                Console.WriteLine("podaj bok 1");
                wysokosc = Console.ReadLine();
                Console.WriteLine("podaj bok 2");
                szerokosc = Console.ReadLine();
                double.TryParse(wysokosc, out user1);
                double.TryParse(szerokosc, out user2);
                pole = user1 * user2;

                Console.WriteLine($"Wynik to  " + pole);
            }
        }

    }

    class Second : Calculate
    {
        public override void Oblicz()
        {
            Console.WriteLine("nadpisanie metody");
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Console.Write((i + x) % 2);
                }

                Console.WriteLine();

            }

        }
    }

    class program
    {
        public static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            calculate.Oblicz();

            First first1 = new First();
            first1.Oblicz();

            Second second1 = new Second();
            second1.Oblicz();

           
            //Oblicz();

        }
    }
}
