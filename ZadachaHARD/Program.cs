// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет

Console.WriteLine("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);
if (numText.Length > 2){
  Console.WriteLine("третья цифра -> " + numText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
