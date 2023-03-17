// Задача 27. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.

// 452 -> 3

// 82 -> 2

// 9,012 ->4

Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
int count = 0;
while (num != 0) 
{count++;
num = Math.Floor(num / 10);}
Console.WriteLine($"Количество цифр в числе: {count}");