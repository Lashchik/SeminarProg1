// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
int third = 1;
if (num >= 100)
    {
    while (num > 999)
    {
    num = (num / 10);
    }
    third = (num % 10);
    Console.WriteLine("третья цифра = " + third);
    }
    else
    Console.WriteLine("-> третьей цифры нет");