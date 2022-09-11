using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Shape
{
    public abstract void Draw(); //zamiast "virtual" jest "abstract"
  
}

public class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw Square");
    }
}

public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw Triangle");
    }
}


public class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>()
        {
            new Square(),
            new Triangle()
        };

        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}