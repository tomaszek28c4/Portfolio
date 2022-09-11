namespace MetodyFunkcje2
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            square s = new square();
            s.PoleKwadrata();
            triangle t = new triangle();
            t.Trojkat();
            t.ObwodTrk();
        }

        class square
        {
            public void PoleKwadrata()
            {
                Console.WriteLine();
                Console.WriteLine("Pole kwadratu");
                string bokA;
                string bokB;
                double user1;
                double user2;
                double pole;
                Console.WriteLine("Podaj bok a");
                bokA = Console.ReadLine();
                Console.WriteLine("Podaj bok b");
                bokB = Console.ReadLine();
                double.TryParse(bokA, out user1);
                double.TryParse(bokB, out user2);
                pole = user1 * user2;
                
                Console.WriteLine("Pole Kwadratu wynosi   :" + pole);
               
                Console.WriteLine();
            }
        }

        class triangle
        {

            public void Trojkat()
            {
                Console.WriteLine();
                Console.WriteLine("Pole trójkąta");
                string wysokosc;
                string podstawa;
                double user1;
                double user2;
                double pole;
                Console.WriteLine("Podaj wysokość");
                wysokosc = Console.ReadLine();
                Console.WriteLine("Podaj podstawe");
                podstawa = Console.ReadLine();
                double.TryParse(wysokosc, out user1);
                double.TryParse(podstawa, out user2);
                pole = (user1 / 2) * user2;
                Console.WriteLine("Pole trójkąta wynosi   :" + pole);
                Console.WriteLine();

            }
            public void ObwodTrk()
            {
                Console.WriteLine();
                Console.WriteLine("Obwód trójkąta");
                string bokA;
                string bokB;
                string bokC;
                double user1;
                double user2;
                double user3;
                double obwod;
                Console.WriteLine("Podaj długość boku a");
                bokA = Console.ReadLine();
                Console.WriteLine("Podaj długość boku b");
                bokB = Console.ReadLine();
                Console.WriteLine("Podaj długość boku c");
                bokC = Console.ReadLine();
                double.TryParse(bokA, out user1);
                double.TryParse(bokB, out user2);
                double.TryParse(bokC, out user3);
                obwod = user1 + user2 + user3;
                Console.WriteLine("obwod trojkąta wynosi    :" + obwod);
                Console.WriteLine();
            }
        }






    }



}