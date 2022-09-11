using ObiektyTABLICE;

namespace LekcjaObiekty
{
    class program
    {
        public static void Main(string[] args)
        {
            human[] ludzie = new[] //tablica typu human 
            {
                new human() { gender="man", imie="Tom", nazwisko="Smart", Wiek=40  },        /*składnia szybkiej
                                                                                         inicjalizacji w tabeli*/               new human() { gender="man", imie="Bartek", nazwisko="Kocioł", Wiek=30  },
                new human() { gender="woman", imie="Iga", nazwisko="Swiat", Wiek=25  },
                new human() { gender="woman", imie="Ewa", nazwisko="Ładna", Wiek=20  },
                new human() { gender="man", imie="Seba", nazwisko="Franc", Wiek=65  },
                new human() { gender="man", imie="Wojtek", nazwisko="Bar", Wiek=35  },
                new human() { gender="man", imie="Rysiek", nazwisko="Mop", Wiek=95  },
                new human() { gender="trans", imie="Krzys", nazwisko="Zap", Wiek=125  } 
            };

            foreach (human human in ludzie)
            {
                Print(human);   //wywołanie metody print 
            }

            Console.WriteLine();
            filtr Rok = new filtr();
            Rok.Rocznik(ludzie);


        }
        public static void Print(human h)  // utworzenie metody Print

        {
            Console.WriteLine($"Nazywam się {h.imie}  {h.nazwisko} ");
            Console.WriteLine($"Jestem  {h.gender}  Mam {h.Wiek}  lat");
            Console.WriteLine();
        }
    }




}
