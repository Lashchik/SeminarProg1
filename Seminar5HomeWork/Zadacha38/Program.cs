// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void Array() {
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < n; i++) {
Console.Write($"Элемент {i + 1}: ");
array[i] = double.Parse(Console.ReadLine());}
double max = array[0], min = array[0];
for (int i = 1; i < n; i++) {
if (array[i] > max) 
{max = array[i];}
if (array[i] < min) 
{min = array[i];}}
double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");}
Array();






