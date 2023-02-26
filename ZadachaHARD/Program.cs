// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет

// Console.WriteLine("Введи число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string numText = Convert.ToString(num);
// if (numText.Length > 2){
//   Console.WriteLine("третья цифра -> " + numText[2]);
// }
// else {
//   Console.WriteLine("-> третьей цифры нет");
// }

Console.WriteLine("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
int third = 1;
if (num >= 100)
    {
    while (num > 999)
    {
    num = (num / 10);
    }
    third = (num % 10);
    Console.WriteLine("третья цифра = " + third);
    }
    else
    Console.WriteLine("-> третьей цифры нет");


// Console.Write("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
 
// if (num <= 99)
// {
//     Console.WriteLine("Третьей цифры нет");   
// }
// else
// {
//     while (num > 999)
// {
//     num = num / 10;  
// }
// if (num <= 999)
// {
//     int div = num % 10;
// Console.Write("Третья цифра числа - {0}", div);
// }
