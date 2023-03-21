// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array, rows, cols);
PrintArray(array);
AvgArray(array);


void FillArray(int[,] array, int rows, int cols)
{
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = rnd.Next(1, 100);
        }}}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();}}

void AvgArray(int[,] array)
{for (int j = 0; j < cols; j++)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += array[i, j];
    }
    double avg = (double) sum / rows;
    Console.WriteLine($"Среднее арифметическое элементов {j+1}-го столбца: {avg}");
}}
