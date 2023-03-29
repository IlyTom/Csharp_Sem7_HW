// Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), 
// проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, 
// что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 3 -> Такой элемент есть: 3
// i = 4, j = 2 -> такого элемента в массиве нет
(int m, int n) ArraySize()
{
    System.Console.Write("Введите кол-во строк: ");
    int m = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите кол-во столбцов: ");
    int n = int.Parse(Console.ReadLine()!);
    var result = (m, n);
    return result;
}

int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] Array = new int[m, n];
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(minValue, maxValue + 1);
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

void CheckPosition(int[,] arr)
{
    System.Console.Write("Введите номер строки: ");
    int i = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите номер столбца: ");
    int j = int.Parse(Console.ReadLine()!);
    if (i < arr.GetLength(0) && j < arr.GetLength(1)) System.Console.WriteLine($"i = {i}, j = {j} -> Такой элемент есть: {arr[i, j]}");
    else System.Console.WriteLine($"i = {i}, j = {j} -> Такого элемента в массиве нет");
}


var ArrSize = ArraySize();
int m = ArrSize.m;
int n = ArrSize.n;

int[,] Array = FillArray(m, n, 0, 8);
PrintArray(Array);
CheckPosition(Array);

