// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (0 < num && num < 6)
Console.WriteLine("Это будний день");
else if (5 < num && num < 8)
Console.WriteLine("Это выходной день");
else
Console.WriteLine("В неделе бывает не больше 7ми дней)");