// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int res = num * num;
Console.WriteLine("Квадрат введённого числа равен "+res);

if (num == 5)
{
Console.WriteLine("это пятёрочка");
}
else if (num==3)
Console.WriteLine("это троечка");
else
Console.WriteLine("это не пятёрочка и не троечка");
