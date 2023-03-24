// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array = new int[10, 10, 10];
// FillArray(array);
// PrintArray(array);
// bool contains = ArrayContains(array, 42);
// Console.WriteLine("Массив содержит значение 42: {0}", contains);
// PrintArray(array);

// void FillArray(int[,,] array)
// {Random random = new Random();
//     for (int i = 0; i < 10; i++)
//     {for (int j = 0; j < 10; j++)
//         {for (int k = 0; k < 10; k++)
//             {int value;
//                 do
//                 {value = random.Next(10, 1000);}
//                 while (ArrayContains(array, value));
//                 array[i, j, k] = value;}}}}

// bool ArrayContains(int[,,] array, int value)
// {for (int i = 0; i < array.GetLength(0); i++)
//     {for (int j = 0; j < array.GetLength(1); j++)
//         {for (int k = 0; k < array.GetLength(2); k++)
//             {if (array[i, j, k] == value)
//                 {return true;}}}}
//         return false;}

// void PrintArray(int[,,] array)
// {for (int i = 0; i < array.GetLength(0); i++)
//     {for (int j = 0; j < array.GetLength(1); j++)
//          {for (int k = 0; k < array.GetLength(2); k++)
//             {Console.Write("{0}[{1},{2},{3}] ", array[i, j, k], i, j, k);}
//             Console.WriteLine();}
//         Console.WriteLine();}}

int[,,] array;
FillArray(out array);
PrintArray(array);
bool contains = ArrayContains(array, 42);
Console.WriteLine("Массив содержит значение 42: {0}", contains);
PrintArray(array);

void FillArray(out int[,,] array)
{
    array = new int[10, 10, 10];
    Random random = new Random();
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            for (int k = 0; k < 10; k++)
            {
                int value;
                do
                {
                    value = random.Next(10, 1000);
                } while (ArrayContains(array, value));
                array[i, j, k] = value;
            }
        }
    }
}

bool ArrayContains(int[,,] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == value)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("{0}[{1},{2},{3}] ", array[i, j, k], i, j, k);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}