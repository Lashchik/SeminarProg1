﻿// Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.
// Решение задачи аналогично задаче 19. Переворачиваем число и сравниваем

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int pal = 0, num = number;
while (number > 0) 
{pal = pal * 10 + number % 10; number /= 10;}
Console.WriteLine(num == pal ? "палиндром" : "не палиндром");