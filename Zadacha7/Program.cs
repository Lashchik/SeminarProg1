﻿// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.WriteLine("Введите целое трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int res = num % 10;
Console.WriteLine("Последняя цифра трёхзначного числа " + res);
