
namespace PodstawowaSkladania_Rectangle
{
    class Program
    {
        // Wykonanie programu
        static void Main(string[] args)  //główna metoda programu 
        {
            Trojkat t = new Trojkat();
            t.akceptujparametry();
            Rectangle r = new Rectangle();
            while (true)
            {



                r.AkceptujDetale();  // metody
                r.WyswietlPodusmowanie();  //metody
            }
            // W przypadku braku poniższej linijki program zostanie wykonany, konsola zostanie wyświetlona
            // na ułamki sekund, nie będziemy w stanie dostrzec efektu działania naszego programu.
            Console.ReadKey();
        }
    }
    // Definicja klasy Rectangle wraz z polami oraz metodami
    class Rectangle
    {
        // Zmienne użytkownika
        double dlugosc;
        double szerokosc;
        // Metoda ustawiająca wartości parametrów na starcie
        public void AkceptujDetale()  // metoda 
        {
            Console.WriteLine("podaj długość boku");
            string userdl = Console.ReadLine();
            Console.WriteLine("podaj szerokość");
            string usersz = Console.ReadLine();
            double.TryParse(userdl, out dlugosc);  //  TRyParse oznacza próba konwersji srting na double
            double.TryParse(usersz, out szerokosc);  //próba konwersji srting na double(liczbę z ułamkiem
            //dlugosc = 10;
            // szerokosc = 20;
        }
        // Obliczanie powierzchni
        public double ObliczPowierzechnie()  // metoda działanie
        {
            return dlugosc * szerokosc;
        }
        // Wyświetlenie wyników działania programu w konsoli
        public void WyswietlPodusmowanie()
        {
            Console.WriteLine("Długość: {0}", dlugosc);
            Console.WriteLine("Szerokość: {0}", szerokosc);
            Console.WriteLine("Powierzchnia: {0}", ObliczPowierzechnie()); //Wywołanie metody "WyświetlPodsumowanie"
        }
    }

     class Trojkat // klasa Trojkat;
    {
        double PoleTrojkata; //
        string podstawa;
        string wysokosc;
        double userp;
        double userw;
        public void akceptujparametry ()
        {
            Console.WriteLine("Podaj podstawe");
            podstawa = Console.ReadLine();
            Console.WriteLine("Podaj Wysokość");
            wysokosc = Console.ReadLine();
            double.TryParse(podstawa, out userp);   // out bierze liczbę z podstawa i wstawia do userp
            double.TryParse(wysokosc, out userw);
            double powierzchnia = userp * userw / 2;


            Console.WriteLine("Powierzchnia: " + powierzchnia );
        }
     }

}