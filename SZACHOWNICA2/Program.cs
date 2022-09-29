namespace Szachownica2
{
    public abstract class Rectangel<T>
    {

        virtual public void Rect(int a, int b, char borderCh, char fillCh)
        {
            Console.WriteLine("Metoda Rect w klasie Rectangel");

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

    public class rectangel1<T> : Rectangel<Task>

    {
        public override void Rect(int a, int b, char borderCh, char fillCh)
        {
            Console.WriteLine("Naspisana metoda Rect w klasie rectangel1");
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


    public class Rectangel5
    {
        public void ReCT(int a, int b, char borderCh, char fillCh)
        {
            Console.WriteLine("Metoda ReCT w kalsie Rectangel5");
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
            Console.WriteLine("Metoda Ches w klasie Chess");
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
            Console.WriteLine("metoda SetMix w klasie Mix");
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
            // rectangel1.Rect(50, 50, '#', '*');
            // Console.WriteLine();
            // Chess.Ches();
            // Console.WriteLine();
            // Mix.SetMix(5 , 5 , '0' , '1');
            // Console.WriteLine();
            //Console.ReadKey();

            Chess<int> chess1 = new Chess<int>();
            chess1.Ches(1);
            Console.WriteLine();

            List<Rectangel> rect1 = new List<Rectangel>()
            {
                 new Rectangel(),

             };

            foreach (Rectangel rectangel in rect1)
            {
                rectangel.Rect(3, 15, '#', '*');
            }

            Console.WriteLine();
            Console.WriteLine("generyczny typ <string>");
            rectangel1<string> rect2 = new rectangel1<string>();
            rect2.Rect(3, 12, '*', '#');
            
            Console.WriteLine();
            Console.WriteLine("generyczny typ <int>");
            rectangel1<int> rect3 = new rectangel1<int>();
            rect3.Rect(3, 10, '*', '#');

            Rectangel5 rec = new Rectangel5();
            rec.ReCT(3, 7, '#', '*');

            Mix.SetMix(3 , 30 , '#' , '*');
        }


    }
}