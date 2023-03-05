﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int pal = 0, num = number;
while (number > 0) {pal = pal * 10 + number % 10; number /= 10;}
Console.WriteLine(num == pal ? "палиндром" : "не палиндром");