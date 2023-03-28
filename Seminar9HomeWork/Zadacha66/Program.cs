﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = Sum(m, n);
Console.WriteLine($"Сумма чисел от {m} до {n} равна {sum}");

int Sum(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else
    {
        return m + Sum(m + 1, n);
    }
}