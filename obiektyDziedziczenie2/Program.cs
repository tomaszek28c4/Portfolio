using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using obiektyDziedziczenie2;

namespace obiektyDziedziczenie2
{
    abstract class CialoNiebieskie
    {
        public string Nazwa { get; set; }
        private void RuchObrotowy()
        {
            Console.WriteLine(" Ciało Niebieskie");
            Console.WriteLine("Każde Ciało Niebieskie ma Ruch Obrotowy");
            Console.WriteLine(" METODA KALSY PRIVATE");

        }

        public void Orbita()
        {
            RuchObrotowy();
            Console.WriteLine("Posiada własną orbitę");
        }
    }

    abstract class Planeta : CialoNiebieskie
    {
        protected void PoraDniaINocy()
        {
            Console.WriteLine("Metoda PROTECTED");
            Console.WriteLine("Wscód i zachód Słońca");
            Console.WriteLine("Pora dnia i nocy");
            Console.WriteLine("Pory roku");
            Console.WriteLine("Planeta - klasa abstrakcyjna");
        }
    }

    class Ziemia : Planeta
    {

        public void Atmosfera()
        {
            PoraDniaINocy();
            Console.WriteLine("Atmosfera Ziemska");
            Console.WriteLine("Morza i lądy");
            Console.WriteLine("Posiada flore i Faune");
        }
    }
    class Mars : Planeta
    {

        public void Atmosfera()

        {
            PoraDniaINocy();
            Console.WriteLine("Rozrzedzona atmosfera");
        }
    }

    sealed class Ksiezyc : CialoNiebieskie
    {
        public void Atmosfera()
        {

            Console.WriteLine("Brak atmosfery");
            Console.WriteLine("Wscód i zachód Słońca");

        }
    }

    sealed class Ksiezyc1 : Planeta
    {
        public void Krater()
        {
            PoraDniaINocy();
            Console.WriteLine("Posiada liczne kratery");
        }

    }

    class program
    {
        public static void Main(string[] arg)
        {
            @object[] element = new[]
           {
                new @object() { body = "Ziemia ", },
                new @object() { body = "Mars   "},
                new @object() { body = "Księżyc "}
            };

            foreach (@object objects in element)
            {
                Print(objects);   //wywołanie metody print 
            }

            static void Print(@object o)  // utworzenie metody Print

            {
                Console.WriteLine($"Ciało {o.body} ");

                Console.WriteLine();
            }



            Ziemia ziemia = new Ziemia();
            Console.WriteLine();
            Console.WriteLine("Ziemia");
            ziemia.Orbita();
            ziemia.Atmosfera();

            

            Mars mars = new Mars();
            Console.WriteLine();
            Console.WriteLine("Mars");
            mars.Orbita();
            mars.Atmosfera();


            Ksiezyc ksiezyc = new Ksiezyc();
            Console.WriteLine();
            Console.WriteLine("Ksieżyc");
            Ksiezyc1 ksiezyc1 = new Ksiezyc1();
            ksiezyc.Orbita();
            ksiezyc.Atmosfera();
            ksiezyc1.Krater();

            Console.ReadKey();
           
        }

    }

}