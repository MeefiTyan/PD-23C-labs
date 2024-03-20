using System;

class Program
{
    static void Main(string[] args)
    {
        Point A = new Point(0, 1, "A");
        Point B = new Point(3, 0, "B");
        Point C = new Point(5, 4, "C");

        Figure figure = new Figure(A, B, C);

        figure.PerimeterCalculator();

        Console.ReadKey();
    }
}
