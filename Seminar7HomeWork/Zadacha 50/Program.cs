// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

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
Console.Write("Введите элемент, позицию которого вы хотите найти: ");
int element = Convert.ToInt32(Console.ReadLine());
FoundArray(array, rows, cols, element);

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
void FoundArray(int[,] array, int rows, int cols, int element)
{
    bool found = false;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (array[i, j] == element)
            {
                Console.WriteLine($"Позиция элемента: [{i}, {j}]");
                found = true;
                break; } }
        if (found) break;}
    if (!found) Console.WriteLine("Элемент не найден.");}