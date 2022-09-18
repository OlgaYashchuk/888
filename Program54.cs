// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
                array[i, j] = new Random().Next(0, 100);
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
        for (int k = 0; k < m; k++)
        {
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (mas1[k, j] < mas1[k, j + 1])
                    {
                        temp = mas1[k, j + 1];
                        mas1[k, j + 1] = mas1[k, j];
                        mas1[k, j] = temp;
                    }
                }
            }
        }
        PrintArray(mas1);  
    }
}
