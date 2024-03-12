using System;

class Point
{
    public int X { get; }
    public int Y { get; }
    public string Name { get; }

    public Point(int x, int y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}

class Figure
{
    private Point[] points;

    public Figure(Point A, Point B, Point C)
    {
        points = new Point[] { A, B, C };
    }

    public Figure(Point A, Point B, Point C, Point D)
    {
        points = new Point[] { A, B, C, D };
    }

    public Figure(Point A, Point B, Point C, Point D, Point E)
    {
        points = new Point[] { A, B, C, D, E };
    }

    private double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += LengthSide(points[i], points[i + 1]);
        }
        perimeter += LengthSide(points[points.Length - 1], points[0]);
        Console.WriteLine($"Perimeter: {perimeter}");
    }
}

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