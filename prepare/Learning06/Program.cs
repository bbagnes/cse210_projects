using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("red", 5);
        Console.WriteLine(sq.GetColor());
        Console.WriteLine(sq.GetArea());
    }
}