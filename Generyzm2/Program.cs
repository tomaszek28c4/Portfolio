namespace Generyzm2
{



    public class KlasaGeneryczna<T>
    {
        public void Dodaj(T parametr)

        {
            Console.WriteLine("Podaj wartość");
            string wartosc;
            wartosc = Console.ReadLine();
            Console.WriteLine($"Wynik metody Dodaj:  + {parametr} ");
        }
    }

    public class Generyzm<T>
    {
        public void Wartosc(T parametr)
        {
            Console.WriteLine("Podaj Wartość");
            string wartosc;
            wartosc = Console.ReadLine();
            Console.WriteLine($" wartość string + paramert = {wartosc}  " + parametr);
        }

    }

    class Program
    {

        static void Main(string[] args)
        {

             KlasaGeneryczna<int> obiektKlasyGenerycznej = new KlasaGeneryczna<int>();
             obiektKlasyGenerycznej.Dodaj(12); // 12 to wartość parametru int dla metody Dodaj w klasie generycznej

             KlasaGeneryczna<string> obiektKlasyGenerycznej1 = new KlasaGeneryczna<string>();
             obiektKlasyGenerycznej1.Dodaj("PARAMETR");


            KlasaGeneryczna<string> obiektKlasyGenerycznej2 = new KlasaGeneryczna<string>();
            obiektKlasyGenerycznej2.Dodaj("Wartość parametru dla metody Dodaj w KlasieGenerycznej");

            Generyzm<string> obiektKlasyGeneryzm = new Generyzm<string>();
            obiektKlasyGeneryzm.Wartosc ("Zawsze MUSI BYĆ podany PARAMETR");
            Console.ReadKey();
        }

    }

}