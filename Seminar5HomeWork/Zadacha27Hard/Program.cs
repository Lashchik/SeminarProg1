// Задача 27. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.

// 452 -> 3

// 82 -> 2

// 9,012 ->4

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (number > 0) 
{
number /= 10;
count++;
}
Console.WriteLine($"Колличество цифр в числе: {count}");