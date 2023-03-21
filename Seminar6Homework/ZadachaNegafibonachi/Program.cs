// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте список чисел НегаФибоначчи, в том числе для отрицательных индексов.

// *Пример:*

// - для k = 9 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

void array()
{
    Console.Write("Введите количество элементов массива: ");
    int k = Convert.ToInt32(Console.ReadLine());
    int n = 2 * k - 1;
    int[] negaFibonacci = new int[n];
    negaFibonacci[k - 1] = -1;
    negaFibonacci[k] = 1;
    for (int i = k + 1; i < n; i++)
    {
        negaFibonacci[i] = negaFibonacci[i - 2] - negaFibonacci[i - 1];
    }
    for (int i = k - 2; i >= 0; i--)
    {
        negaFibonacci[i] = negaFibonacci[i + 2] - negaFibonacci[i + 1];
    }
    Console.WriteLine(string.Join(", ", negaFibonacci));
}
array();