// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
MinSumRow(array);

void FillArray(int[,] array)
 {
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {for (int j = 0; j < array.GetLength(1); j++)
        {array[i, j] = random.Next(1, 101);}}}

void MinSumRow(int[,] array)
 {int minSumRow = 0;
    int minSum = int.MaxValue;
    for (int i = 0; i < m; i++)
    {int sum = 0;
        for (int j = 0; j < n; j++)
        {sum += array[i, j];}
        if (sum < minSum)
        {minSum = sum;
            minSumRow = i;}}
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");}

void PrintArray(int[,] array)
{for (int i = 0; i < array.GetLength(0); i++)
    {for (int j = 0; j < array.GetLength(1); j++)
        {Console.Write(array[i, j] + " ");}
        Console.WriteLine();}}
Console.WriteLine();
