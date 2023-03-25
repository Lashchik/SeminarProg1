// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// На входе - натуральное число от пользователя, например 4.
// Тогда на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
FillSpiralArray(array, 0, 0, m, 1);
PrintArray(array);

void FillArray(int[,] array)
 {
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {for (int j = 0; j < array.GetLength(1); j++)
        {array[i, j] = random.Next(1, 101);}}}

void PrintArray(int[,] array)
{for (int i = 0; i < array.GetLength(0); i++)
    {for (int j = 0; j < array.GetLength(1); j++)
        {Console.Write(array[i, j] + " ");}
        Console.WriteLine();}}
Console.WriteLine();

void FillSpiralArray(int[,] array, int x, int y, int size, int num)
    {if (size <= 0) return;

    if (size == 1)
    {array[x, y] = num;
        return;}

    for (int i = 0; i < size - 1; i++)
    {array[x, y + i] = num++;}

    for (int i = 0; i < size - 1; i++)
    {array[x + i, y + size - 1] = num++;}

    for (int i = size - 1; i > 0; i--)
    {array[x + size - 1, y + i] = num++;}

    for (int i = size - 1; i > 0; i--)
    {array[x + i, y] = num++;}

    FillSpiralArray(array, x + 1, y + 1, size - 2, num);
}