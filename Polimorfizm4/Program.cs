using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Polimorfizm4


{


    class abstract Shape
    {

        public int x { get; set; }
        public int y { get; set; }

        public virtual void  Draw()

        {
            Console.WriteLine("Drawing All Shapes");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
           Console.WriteLine("Draw Circle");
          // base.Draw();
        }
    }

    class Rectangel : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Rectangel");
           // base.Draw();
        }

    }

    class Triangel : Shape
    {
        public override void Draw()
        {
           Console.WriteLine("Draw Triangel");
          // base.Draw();
        }
    }

    class program
    {
        public static void Main(string[] args)
        {
           // Console.WriteLine("Wywołanie metody 1 po drugiej");
           // Shape shape1 = new Shape();
           // shape1.Draw();

          //  Shape shape2 = new Circle();
          //  shape2.Draw();

           // Shape shape3 = new Rectangel();
           // shape3.Draw();

           // Shape shape4 = new Triangel();
           // shape4.Draw();
           // Console.WriteLine(); 
            
            Console.WriteLine("Wywołanie metod w sposób polimorficzny");
            Shape[] shapes = { new Circle(), new Rectangel(), new Triangel() };
            shapes.Where(m => m.x > 5); //skladnia linq
            foreach (Shape shape in shapes)
            {
                //Console.WriteLine(shape);
                shape.Draw();
               
            }
            shapes[0].Draw();

            // Console.Write($"Ponowne wywołanie z klasy Rectangel  "); { shape3.Draw(); }
            // Console.Write($"Ponowne wywołanie z klasy Shape  ");
            // { shape1.Draw(); }




        }

    }
};