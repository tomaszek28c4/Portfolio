
namespace PodstawowaSkladania_Rectangle
{
    class Program
    {
        // Wykonanie programu
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            while (true)
            {



                r.AkceptujDetale();
                r.WyswietlPodusmowanie();
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
        public void AkceptujDetale()
        {
            Console.WriteLine("podaj długość boku");
            string userdl = Console.ReadLine();
            Console.WriteLine("podaj szerokość");
            string usersz = Console.ReadLine();
            double.TryParse(userdl, out dlugosc);
            double.TryParse(usersz, out szerokosc);
            //dlugosc = 10;
           // szerokosc = 20;
        }
        // Obliczanie powierzchni
        public double ObliczPowierzechnie()
        {
            return dlugosc * szerokosc;
        }
        // Wyświetlenie wyników działania programu w konsoli
        public void WyswietlPodusmowanie()
        {
            Console.WriteLine("Długość: {0}", dlugosc);
            Console.WriteLine("Szerokość: {0}", szerokosc);
            Console.WriteLine("Powierzchnia: {0}", ObliczPowierzechnie());
        }
    }
}