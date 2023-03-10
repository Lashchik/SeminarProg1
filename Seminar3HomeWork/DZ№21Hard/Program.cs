// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.


    Console.WriteLine("введите размерность пространства");
    int num = Convert.ToInt32(Console.ReadLine());

    double[] kordX = new double[num];
    double[] kordY = new double[num];

    Console.WriteLine("Введите координаты первой точки:");
    for (int index = 0; index < num; index++)
    {
        Console.Write($"Координата {index + 1}: ");
        kordX[index] = double.Parse(Console.ReadLine());
    }
    Console.WriteLine("Введите координаты второй точки:");
    for (int index = 0; index < num; index++)
    {
        Console.Write($"Координата {index + 1}: ");
        kordY[index] = double.Parse(Console.ReadLine());
    }
    double distance = Distance(kordX, kordY);
    Console.WriteLine($"Расстояние между двумя точками: {distance}");

static double Distance(double[] kordX, double[] kordY)
{
    double sum = 0.0;
    for (int index = 0; index < kordX.Length; index++)
    {
        double diff = kordX[index] - kordY[index];
        sum += diff * diff;
    }
    return Math.Sqrt(sum);
}