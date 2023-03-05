// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Index(int num)


{
int count = 0;
while (num > 0)
{ num = (num / 10);
 count ++;}
return count;
}

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("количество цифр в числе = " + Index(num));