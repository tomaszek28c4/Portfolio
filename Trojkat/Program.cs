namespace program
{

    class program
    {

        static void Main(string[] arg)
        {
            for (int i = 1; i <= 3; i++)
            {


                Trojkat t = new Trojkat();
                t.akceptujparametry();


                if (i == 3)
                {
                    break;
                }

            }
        }


       
        
        
        class Trojkat
        {  // klasa Trojkat;




            double PoleTrojkata; //
            string podstawa;
            string wysokosc;
            double userp;
            double userw;
            public void akceptujparametry()
            {
                Console.WriteLine("Podaj podstawe");
                podstawa = Console.ReadLine();
                Console.WriteLine("Podaj Wysokość");
                wysokosc = Console.ReadLine();
                double.TryParse(podstawa, out userp);   // out bierze liczbę z podstawa i wstawia do userp
                double.TryParse(wysokosc, out userw);
                double powierzchnia = userp * userw / 2;


                Console.WriteLine("Powierzchnia: " + powierzchnia);
            }
        }

    }
}







