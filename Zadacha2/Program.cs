// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 == num1/num2)
// {
// Console.WriteLine("Первое число - это квадрат второго числа!");
// }
// else 
// Console.WriteLine("Первое число - это не квадрат второго числа!");

Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
if (numB == numA / numB)
{
    Console.WriteLine("Первое число это квадрат второго");
    }
else
Console.WriteLine("Первое число это не квадрат второго");