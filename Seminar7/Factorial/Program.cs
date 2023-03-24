// рекурсия для поиска факториала

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

double Factorial(int n)
{
    // 1! = 0
    // 0! = 0
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

Console.WriteLine(Factorial(n));