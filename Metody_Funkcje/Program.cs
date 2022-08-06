namespace MetodyFunkcje
{
    class program
    {
        public static void Main(string[] args)
        {
           PoleKwadrata();
           Triangle();

        }
          public static void PoleKwadrata()
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

        public static void Triangle()
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