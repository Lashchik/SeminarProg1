// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

void Array(int [] array)
{
    for (int i =0; i<array.Length; i++)
        array[i] = new Random().Next(-9,10);
}

void Reverse(int [] array)
{
    for (int i =0; i<array.Length; i++)
        array[i] = -array[i];
}

void PrintArray(int [] array)
{
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine();
}

int [] array  = new int [4];
Array(array);
PrintArray(array);
Reverse(array);
PrintArray(array);