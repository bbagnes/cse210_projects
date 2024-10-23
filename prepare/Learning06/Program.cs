using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("red", 5);
        Console.WriteLine(sq.GetColor());
        Console.WriteLine(sq.GetArea());

        Circle cc = new Circle("blue", 5);
        Console.WriteLine(cc.GetColor());
        Console.WriteLine(cc.GetArea());

        Rectangle rc = new Rectangle("green", 5, 7);
        Console.WriteLine(rc.GetColor());
        Console.WriteLine(rc.GetArea());

        List<Shape> shapes = new List<Shape>() {sq, cc, rc};
        
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("");
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine("");
        }
    }
}