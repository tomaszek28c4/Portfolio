namespace LekcjaObiekty
{
    class program
    {
        public static void Main(string[] args)
        {
            human[] ludzie = new[] //tablica typu human 
            {
                humanBartek(),
                humanIga(),
                humanMarta(),
                humanTom(),
                new human() { gender="trans", imie="krzys", nazwisko="zap", Wiek=65  } /*składnia szybkiej
                     Console.Wri                                                                  inicjalizacji w tabeli*/
            };

            foreach (human human in ludzie)
            {
                Print(human);
            }

          /* Print(humanIga());
            Console.WriteLine();
            
            Print(humanTom());
            Console.WriteLine();

            Print(humanBartek());

            Console.WriteLine();
            Print(humanMarta());*/

            Console.WriteLine();
            filtr Rok = new filtr();
            Rok.Rocznik(ludzie);


        }
        public static human humanTom()
        {
            human tom = new human();
            tom.imie = "Tomek";
            tom.nazwisko = "Kocioł";
            tom.gender = "mężczyzna";
            tom.Wiek = 25;
            return tom;




        }

        public static human humanBartek()
        {
            human bart = new human();
            bart.imie = "Bartek";
            bart.nazwisko = "Rogal";
            bart.gender = "mężczyzna";
            bart.Wiek = 105;
            return bart;




        }

        public static human humanMarta()
        {
            human marta = new human();
            marta.imie = "Marta";
            marta.nazwisko = "Igła";
            marta.gender = "kobieta";
            marta.Wiek = 35;
            return marta;



        }
        public static human humanIga()
        {
            human iga = new human();
            iga.imie = "Iga";
            iga.nazwisko = "Kowalska";
            iga.gender = "kobieta";
            iga.Wiek = 20;

            return iga;
        }

        public static void Print(human h)

        {
            Console.WriteLine($"Nazywam się {h.imie} {h.nazwisko} ");
            Console.WriteLine($"Jestem  {h.gender} Mam {h.Wiek}");
        }
    }




}
