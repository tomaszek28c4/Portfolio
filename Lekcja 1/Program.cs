namespace kwadrat
{
    class Program
    {
        public static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {

                
                    {
                        string wysokosc;
                        string podstawa;
                        double user1;
                        double user2;


                        //podaj wysokość
                        Console.WriteLine("Podaj Wysokość");
                        wysokosc = Console.ReadLine();
                        //podaj podstawe
                        Console.WriteLine("Podaj podstawe");
                        podstawa = Console.ReadLine();
                        double.TryParse(wysokosc, out user1);
                        double.TryParse(podstawa, out user2);
                        //działanie
                        double pole = user1 * user2;

                        Console.WriteLine("Pole powierzchni to    " + pole);
                    }

                if (i == 5)
                {
                    break;

                }

            }



        }

    }

}