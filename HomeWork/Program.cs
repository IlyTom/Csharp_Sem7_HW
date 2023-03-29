// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillArray(int minValue, int maxValue)
{
    System.Console.Write("Введите кол-во строк: ");
    int m = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите кол-во столбцов: ");
    int n = int.Parse(Console.ReadLine()!);
    int[,] Array = new int[m, n];
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(minValue, maxValue);
        }
    return Array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void MeanElColumn(int[,] arr)
{
    double[] ColumnMean = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int Sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Sum += arr[i, j];
        }
        ColumnMean[j] = Math.Round((double)Sum / arr.GetLength(0), 1);
    }
    System.Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", ColumnMean)}");
}
int[,] Array = FillArray(0, 10);
PrintArray(Array);
MeanElColumn(Array);
