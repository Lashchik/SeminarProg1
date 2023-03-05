// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. В том числе для вещ>ственных чисел

int Index(double num)


{
int count = 0;
while ((num % 1) > 0)
{
     num = (num * 10);
     Console.WriteLine(num);
}
while (num > 0)
{ num = (num / 10);
 count = count + 1;}
return count;
}
Console.WriteLine("Введите число");
double num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Index(num));