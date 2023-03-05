// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.WriteLine("введите размерность пространства");
int num = Convert.ToInt32(Console.ReadLine());
double [] kordX = new double [num];
double [] kordY = new double [num];
int index = 0;
while (index < num)
{Console.WriteLine("введите координату точки X" + (index+1));
kordX [index] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координату точки Y" + (index+1));
kordY [index] = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt((kordX[index]) - (kordY[index])*(kordX[index]) - (kordY[index]));
Console.WriteLine(result);
index++;}
