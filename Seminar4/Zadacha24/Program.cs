﻿// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Summa(int num)
{
    int sum=0;
    for (int i =1; i<=num;i++)
        sum+=i; // sum = sum + i;
    return sum;
}


Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {Summa(num)}");