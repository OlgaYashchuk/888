// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
internal static class Program
{
    static void PrintArray(int[,] table)
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                Console.Write(table[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static int[,] FillArray(int m, int n)
    {
        int[,] array = new int [m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
        return array;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк двумерного массива :");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов двумерного массива : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        int[,] mas1 = FillArray(m, n);
        PrintArray(mas1);
        int minSum = Int32.MaxValue;
        int minStr = 0;
        for (int k = 0; k < m; k++)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + mas1[k, i];
            }

            if (minSum>sum)
            {
                minSum = sum;
                minStr = k;
            }
        }
        Console.WriteLine(minSum+" строка "+(minStr+1));  
    }
}