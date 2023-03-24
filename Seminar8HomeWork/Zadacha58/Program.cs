// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк первой матрицы: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 != m2)
    {Console.WriteLine("Ошибка: матрицы разной размерности. Умножение не возможно");
    return;}
int[,] matrix1 = new int[m1, n1];
int[,] matrix2 = new int[m2, n2];
int[,] resultMatrix = new int[m1, n2];

FillMatrix(matrix1);
FillMatrix(matrix2);
Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);
Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);
Console.WriteLine("Результат умножения:");
MultiplyMatrix(matrix1, matrix2, resultMatrix);
PrintMatrix(resultMatrix);

void FillMatrix(int[,] matrix)
    {Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {for (int j = 0; j < matrix.GetLength(1); j++)
        {matrix[i, j] = rnd.Next(10);}}}

void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
    {for (int i = 0; i < matrix1.GetLength(0); i++)
        {for (int j = 0; j < matrix2.GetLength(1); j++)
            {int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {sum += matrix1[i, k] * matrix2[k, j];}
            resultMatrix[i, j] = sum;}}}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {for (int j = 0; j < matrix.GetLength(1); j++)
        {Console.Write(matrix[i, j] + "\t");}
        Console.WriteLine();}
    Console.WriteLine();}