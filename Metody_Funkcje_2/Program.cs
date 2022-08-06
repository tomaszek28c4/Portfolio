namespace MetodyFunkcje
{
    class program
    {
        public static void Main(string[] args)
        {
            square s = new square();
            s.PoleKwadrata();

            triangle t = new triangle();
            t.Trojkat();
        }

        class square
        {
            public  void PoleKwadrata()
            {
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
            }
        }

        class triangle
        {

            public  void Trojkat()
            {
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
                pole = user1 * user2;
                Console.WriteLine("Pole trójkąta wynosi   :" + pole);

            }
        }






    }



}