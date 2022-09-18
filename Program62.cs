//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.internal static class Program
namespace laba62;
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
    static void Main(string[] args)
    {
        int[,] mas = new int[4, 4];
        int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = 4;
        for (int i = 0; i < mas.Length; i++)
        {
            mas[row, col] = i + 1;
            if (--gran == 0)
            {
                gran = 4 * (dirChanges % 2) + 4 * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                int temp = dx;
                dx = -dy;
                dy = temp;
                dirChanges++;
            }
            col += dx;
            row += dy;
        }               
        PrintArray(mas);
       
    }
}
