// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки X1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки Y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки X2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки Y2");
int y2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
Console.WriteLine(result);

