// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void Array()
{Console.WriteLine("Введите количество чисел в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random rnd = new Random();
for (int i = 0; i < n; i++) 
{array[i] = rnd.Next(100, 1000);
Console.Write(array[i] + " ");}
Console.WriteLine();
int count = 0;
for (int i = 0; i < n; i++) 
{if (array[i] % 2 == 0)
    {count++;}}
Console.WriteLine($"Количество чётных чисел в массиве: {count}");}
Array();