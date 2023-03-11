// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
void Array(int [] array)
{
    for (int i =0; i<array.Length; i++)
        array[i] = new Random().Next(-9,10);
}

void PrintArray(int [] array)
{
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine();
}

void Poisk(int[] array)
{
    Console.Write("Введите ваше число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    bool find = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num || array[i] == num*(-1))
        {
            // Console.WriteLine("Ваше число есть в массиве");
            find = true;
            break;
        }
    }
    Console.WriteLine($"Результат поиска {find}");
}


int [] array  = new int [10];
Array(array);
PrintArray(array);
Poisk(array);