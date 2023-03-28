// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите N : ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbers(n);

void PrintNumbers(int n)
{
    if (n < 1) return;

    Console.Write(n);
    if (n > 1)
    {
        Console.Write(", ");
        PrintNumbers(n - 1);
    }
}
