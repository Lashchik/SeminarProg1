﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [rows, cols];
FillArray(array);
PrintArray(array);



void FillArray(double[,] array)
{
    Random random = new Random();
    for (int i=0; i<array.GetLength(0);i++)
        for (int j=0; j<array.GetLength(1);j++)
            array[i,j] = random.NextDouble() * 100;
}

void PrintArray(double[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
        for (int j=0; j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3} \t");
        Console.WriteLine();
        }
}