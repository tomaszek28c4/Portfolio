namespace cosnapisałem  //męczyłem się w chuj i dalej nie rozumiem
{
    class program
    {
        static void Main(string[] arg) // metoda wykonania programu
        {
            Trojkat t = new Trojkat();
            t.akceptujparametry();
        }

        class Trojkat // klasa Trojkat
        {
            double PoleTrojkata; // liczba z ułamkiem
            string podstawa;
            string wysokosc;
            double userp;  // zmienna liczbowa z ułamkiem
            double userw;
            public void akceptujparametry()

            {
                Console.WriteLine("Podaj podstawe");
                podstawa = Console.ReadLine();
                Console.WriteLine("Podaj Wysokość");
                wysokosc = Console.ReadLine();
                double.TryParse(podstawa, out userp);   // out bierze liczbę z podstawa i wstawia do userp
                double.TryParse(wysokosc, out userw);
                double powierzchnia = userp * userw / 2;  // wykonanie działania


                Console.WriteLine("Powierzchnia: " + powierzchnia); // Podanie wyniku działania
            }
        }



    }
 }
