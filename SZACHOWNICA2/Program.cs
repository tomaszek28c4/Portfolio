namespace Szachownica2
{
    abstract public class Rectangel
    {
       virtual public void Rect(int a, int b, char borderCh, char fillCh)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i == 0 || i == a - 1 || j == 0 || j == b - 1)
                    {
                        Console.Write(borderCh);
                    }
                    else
                        Console.Write(fillCh);
                }
                Console.WriteLine();
            }

        }
        char borderCh;
        char fillCh;


    }

    class Rectangel1 : Rectangel
    {
        public override void Rect(int a, int b, char borderCh, char fillCh)
        {

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i == 0 || i == a - 1 || j == 0 || j == b - 1)
                    {
                        Console.Write(borderCh);
                    }
                    else
                        Console.Write(fillCh);
                }
                Console.WriteLine();
            }
        }
    }

    class Chess<T>
    {
        public void Ches(T parametr)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Console.Write((i + x) % 2);
                }

                Console.WriteLine();

            }

        }
    }

    public class Mix
    {
        public static void SetMix(int a, int b, char borderCh, char fillCh)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i == 0 || i == a - 1 || j == 0 || j == b - 1)
                    {
                        Console.Write(borderCh);

                    }
                    else
                        Console.Write(fillCh);

                }
                Console.WriteLine();

            }
            Console.WriteLine();
            for (int k = 0; k < 5; k++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write((k + x) % 2);
                }

                Console.WriteLine();

            }
        }

    }

    class program
    {
        public static void Main(string[] args)
        {
            // Rectangel.Rect(5, 100, '#', '*');
            // Console.WriteLine();
            // Chess.Ches();
            // Console.WriteLine();
            // Mix.SetMix(5 , 5 , '0' , '1');
            // Console.WriteLine();
            //Console.ReadKey();

            // Chess<int> chess1 = new Chess<int>();
            // chess1.Ches(1);
            List<Rectangel> rect1 = new List<Rectangel>()
            {
                new Rectangel1()
            };


            foreach( Rectangel rectangel in rect1)
            {
                rectangel.Rect(10,10,'#','*');
            }
        }

    }
}