﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
Console.WriteLine("Введите 8 целых чисел:");
for (int i = 0; i < array.Length; i++) 
{
Console.Write($"Число {i + 1}: ");
array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Массив:");
Console.WriteLine(string.Join(" ", array));