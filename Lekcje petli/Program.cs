namespace liczbypierwsze
{
    class Program
    {
        public static void Main(string[] args)
        {

            for (; ; )
            {


                Console.WriteLine("Podaj liczbę");
                string liczba;
                double userl;
                liczba = Console.ReadLine();

                double.TryParse(liczba, out userl);





                if (((userl) % 2) == 0)
                {
                    Console.WriteLine("Liczba parzysta");
                }

                else
                {
                    Console.WriteLine("Liczba nieparzysta");

                }

            }
        }





    }
}