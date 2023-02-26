// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB == numA * numA)
Console.WriteLine("Второе число квадрат первого");
else if (numA == numB * numB)
Console.WriteLine("Первое число квадрат второго");
else 
Console.WriteLine("Числа не являются квадратами друг друга");
