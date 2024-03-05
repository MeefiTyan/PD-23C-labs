using System;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2, num3;


        Console.WriteLine("Введiть перше число: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введiть друге число: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введiть трете число: ");
        num3 = Convert.ToInt32(Console.ReadLine());


        SelectNumbersInInterval(num1, num2, num3);

        Console.ReadLine();
    }

    static void SelectNumbersInInterval(int num1, int num2, int num3)
    {

        if (num1 >= 1 && num1 <= 18)
        {
            Console.WriteLine($"Число {num1} знаходиться в [1, 18]");
        }

        if (num2 >= 1 && num2 <= 18)
        {
            Console.WriteLine($"Число {num2} знаходиться в [1, 18]");
        }

        if (num3 >= 1 && num3 <= 18)
        {
            Console.WriteLine($"Число {num3} знаходиться в [1, 18]");
        }
    }
}
