using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arrayX = new int[18] { 1, -3, 2, 0, -5, 6, -4, 7, -1, 6, 0, 0, 2, 3, -4, 7, 8, 0 };

        Console.WriteLine("Масив X:");
        PrintArray(arrayX);

        Console.WriteLine("Введiть модуль M:");
        int M = Convert.ToInt32(Console.ReadLine());

        int[] arrayY = GenerateArrayY(arrayX, M);
        Console.WriteLine($"Модуль M: {M}");
        Console.WriteLine("Новий масив Y:");
        PrintArray(arrayY);

        Console.ReadLine();
    }

    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }


    static int[] GenerateArrayY(int[] arrX, int M)
    {
        int[] arrY = new int[arrX.Length];
        int yIndex = 0;

        foreach (int element in arrX)
        {
            if (Math.Abs(element) > M)
            {
                arrY[yIndex++] = element;
            }
        }

        Array.Resize(ref arrY, yIndex);

        return arrY;
    }
}