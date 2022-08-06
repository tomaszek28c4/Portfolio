namespace ObwodTrojkata
{
    class Program
    {
        public static void Main(string[] args)
        {

            for (int i = 1; i <= 3; i++)
            {


                string BokA;
                string BokB;
                string BokC;
                double user1;
                double user2;
                double user3;
                double ObwodTrojkata;

                Console.WriteLine("padaj bok A");
                BokA = Console.ReadLine();

                Console.WriteLine("podaj bok B");
                BokB = Console.ReadLine();

                Console.WriteLine("podaj bok C");
                BokC = Console.ReadLine();

                double.TryParse(BokA, out user1);
                double.TryParse(BokB, out user2);
                double.TryParse(BokC, out user3);

                ObwodTrojkata = user1 + user2 + user3;

                Console.WriteLine("Obwód trójkąta wynosi   " + ObwodTrojkata);

            }
        }


    }
}