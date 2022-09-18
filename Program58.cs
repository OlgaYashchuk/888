// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
  static int[,] result(int[,] mas1, int[,] mas2)
  {
    int[,] resmas = new int[mas1.GetLength(0), mas2.GetLength(0)];
    for (var i = 0; i < mas1.GetLength(0); i++)
    {
       for (var j = 0; j < mas2.GetLength(0); j++)
        {
         resmas[i, j] = 0;
          for (int k = 0; k < mas1.GetLength(0); k++)
           {
             resmas[i, j] += mas1[i, k] * mas2[k, j];
           }
        }
    }
     return resmas;
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
    int[,] mas2 = FillArray(m, n);
    PrintArray(mas2);
      if (m != n)
       {
        Console.WriteLine("Перемножить  немагчыма");
       }
      else
       {
        int[,] resultmas = result(mas1, mas2);
        PrintArray(resultmas);
       }
   }
  }

