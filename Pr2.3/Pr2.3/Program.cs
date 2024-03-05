using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arrayX = new int[18] { 7, 8, 2, 4, 5, 6, 7, 8, 9, 5, 10, 11, 4, 18, 2, 5, 7, 9 };

        Console.WriteLine("Массив X:");
        PrintArray(arrayX);

        int minValue = FindMinValue(arrayX);
        Console.WriteLine($"Мiнiмальне число: {minValue}");

        int maxValue = FindMaxValue(arrayX);
        Console.WriteLine($"Максимальне число: {maxValue}");

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

    static int FindMinValue(int[] arr)
    {
        int minValue = arr[0];
        foreach (int element in arr)
        {
            if (element < minValue)
            {
                minValue = element;
            }
        }
        return minValue;
    }

    static int FindMaxValue(int[] arr)
    {
        int maxValue = arr[0];
        foreach (int element in arr)
        {
            if (element > maxValue)
            {
                maxValue = element;
            }
        }
        return maxValue;
    }
}