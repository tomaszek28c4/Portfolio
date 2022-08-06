namespace Lekcja
{
    class Program
    {
        public static void Main(string[] arg)
        {

            for (int i = 1; i <= 3; i++)
            {


                string wysokosc;
                string podstawa;
                double user1;
                double user2;


                //podaj wysokosc
                Console.WriteLine("Podaj wysokość");
                wysokosc = Console.ReadLine();
                Console.WriteLine("Podaj podstawę");
                podstawa = Console.ReadLine();
                double.TryParse(wysokosc, out user1);
                double.TryParse(podstawa, out user2);
                double pole = user1 * user2;

                Console.WriteLine("Pole wynosi  " + pole);

                if (i == 3)
                {
                    break;
                }

            }

        }


    }
}