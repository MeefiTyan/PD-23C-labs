using System;

class Program
{
    static void Main(string[] args)
    {
        double side1, side2, side3;

        Console.WriteLine("Введiть першу сторону: ");
        side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введiть другу сторону: ");
        side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введiть третю сторону: ");
        side3 = Convert.ToDouble(Console.ReadLine());

        if (IsValidTriangle(side1, side2, side3))
        {
            double perimeter = CalculatePerimeter(side1, side2, side3);
            Console.WriteLine($"Периметр: {perimeter}");

            double area = CalculateArea(side1, side2, side3);
            Console.WriteLine($"Площа: {area}");

            string triangleType = DetermineTriangleType(side1, side2, side3);
            Console.WriteLine($"Вид трикутника {triangleType}");
        }
        else
        {
            Console.WriteLine("Трикутника не iснуе");
        }

        Console.ReadLine();
    }

    static bool IsValidTriangle(double side1, double side2, double side3)
    {
        return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
    }

    static double CalculatePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }

    static double CalculateArea(double side1, double side2, double side3)
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    static string DetermineTriangleType(double side1, double side2, double side3)
    {
        if (side1 == side2 && side2 == side3)
        {
            return "Рiвнобедренний";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            return "Рiвностороннiй";
        }
        else
        {
            return "Рiзностороннiй";
        }
    }
}