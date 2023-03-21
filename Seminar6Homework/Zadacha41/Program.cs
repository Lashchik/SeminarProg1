// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void Array() {
nConsole.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Cosole.ReadLine());
int[] array = new int[n];
int count = 0;
Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < n; i++) {
Console.Write($"Элемент {i + 1}: ");
int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) 
    {count++;}}
Console.WriteLine($"Количество чисел, больших нуля: {count}");}
Array();
