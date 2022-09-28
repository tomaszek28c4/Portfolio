namespace Lekcja100
{

    abstract class Calculate
    {
        public virtual void Oblicz()
        {
            Console.WriteLine("Program Calculate");
            Console.WriteLine("Rozpoczęzecie Programu");
        }
    }
    class First : Calculate
    {

        public override void Oblicz()
        {
            base.Oblicz();


            for (int i = 0; i <= 1; i++)
            {

                string wysokosc;
                string szerokosc;


                double user1;
                double user2;
                double pole;


                Console.WriteLine("Klasa First - oblicznie pola kwadratu");

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



    class Second : First
    {

        public override void Oblicz()

        {



            Console.WriteLine("Klasa Second - oblicznie modulo 2");
            Console.WriteLine("nadpisanie metody klasy First za pomocą metody :base");

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


    class Third
    {
        public void Oblicz()
        {
            List<Calculate> zadanie1 = new List<Calculate>()


            {
               new First() ,
                new Second(),
                new Fourth(),


            };

            foreach (Calculate oblicz1 in zadanie1) // z listy Calculate na podstawie elementu
                                                    // "zadanie1" tworze element "zadanie1l"
                                                    // i tworze metode "zadamie1l
            {
                oblicz1.Oblicz();
            }

        }
    }
    class Fourth : Calculate
    {
        override public void Oblicz()
        {
            Console.WriteLine("Clasa Czwarta");
        }
    }
    sealed class Password : Third
    {
        public void Oblicz()
        {

            Console.WriteLine("Podaj Hasło");
            // int num = Convert.ToInt32(Console.ReadLine());
            string dupa = Console.ReadLine();

            if (dupa == "12345")
            {


                for (int i = 0; i < 1; i++)
                {
                    Third third = new Third();
                    third.Oblicz();
                }



            }
            else
            {
                Console.WriteLine("Bład");
            }
        }
    }

    class program
    {
        public static void Main(string[] args)
        {
            // Calculate calculate = new Calculate();
            // calculate.Oblicz();

            // First first1 = new First();
            // first1.Oblicz();

            // Second second1 = new Second();
            //second1.Oblicz();

            // Third third1 = new Third();
            // third1.Oblicz();

            // Calculate[] jeden = new Calculate[] { new First(), new Second() };

            // foreach (Calculate dupa in jeden)
            // {
            // dupa.Oblicz();
            // }
            // Second second1 = new Second();
            // second1.Oblicz();
            for (int i = 1; 3 >= i; i++)
            {

                Password haslo = new Password();
                haslo.Oblicz();
            }
        }
    }
}
