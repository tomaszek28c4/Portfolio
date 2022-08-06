namespace Lekcje
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++) 
            {

               
                
                string podstawa;
                string wysokosc;
                double user1;
                double user2;
                double pole;



                Console.WriteLine("Podaj podstawe");
                podstawa = Console.ReadLine();
                Console.WriteLine("Podaj wysokosc");
                wysokosc = Console.ReadLine();
                double.TryParse(podstawa, out user1);
                double.TryParse(wysokosc, out user2);
                //działanie
                pole = user1 * user2;
                Console.WriteLine( "Pole wynosi    " + pole );

                

            }

            

        }
    }
}

