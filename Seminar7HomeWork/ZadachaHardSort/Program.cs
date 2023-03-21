// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
SortArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 100);
        }}}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} ");}
        Console.WriteLine();}
    Console.WriteLine();}

void SortArray(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0) * array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0) * array.GetLength(1) - 1; j++)
        {
            if (array[j / array.GetLength(1), j % array.GetLength(1)] > array[(j + 1) / array.GetLength(1), (j + 1) % array.GetLength(1)])
            {
                temp = array[j / array.GetLength(1), j % array.GetLength(1)];
                array[j / array.GetLength(1), j % array.GetLength(1)] = array[(j + 1) / array.GetLength(1), (j + 1) % array.GetLength(1)];
                array[(j + 1) / array.GetLength(1), (j + 1) % array.GetLength(1)] = temp;
            }}}}