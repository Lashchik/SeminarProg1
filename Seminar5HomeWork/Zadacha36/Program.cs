// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void Array()
{Console.WriteLine("Введите количество чисел в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random rnd = new Random();
for (int i = 0; i < n; i++) 
{array[i] = rnd.Next(-999, 1000);
Console.Write(array[i] + " ");}
Console.WriteLine();
int sum = 0;
for (int i = 1; i < array.Length; i += 2) 
{sum += array[i];}
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");}
Array();