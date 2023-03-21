// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый элемент гарантированно и только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций. То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m * n % 2 != 0)
 {Console.WriteLine("Ошибка: количество элементов должно быть четным");
    return;}

int[,] array = new int[m, n];
FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
ShuffleArray(array, m, n);
Console.WriteLine("Перемешанный массив:");
PrintArray(array);

static void FillArray(int[,] array)
 {
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {for (int j = 0; j < array.GetLength(1); j++)
        {array[i, j] = random.Next(1, 101);}}}

static void PrintArray(int[,] array)
    {for (int i = 0; i < array.GetLength(0); i++)
        {for (int j = 0; j < array.GetLength(1); j++)
        {Console.Write("{0,4}", array[i, j]);}
    Console.WriteLine();}}

    static void ShuffleArray(int[,] array, int m, int n)
    {Random random = new Random();
        int swaps = m * n / 2;
        for (int k = 0; k < swaps; k++)
        {
            int i1 = random.Next(m);
            int j1 = random.Next(n);
            int i2 = random.Next(m);
            int j2 = random.Next(n);
            int temp = array[i1, j1];
            array[i1, j1] = array[i2, j2];
            array[i2, j2] = temp}}