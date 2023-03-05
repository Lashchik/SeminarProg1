// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


void CheckKoord(int x, int y)
{

    if (x>0 && y>0)
        Console.WriteLine("четверть № 1");
    else if (x>0 && y<0)
        Console.WriteLine("четверть № 4");
    else if (x<0 && y<0)
        Console.WriteLine("четверть № 3");
    else if (x<0 && y>0)
        Console.WriteLine("четверть № 2");
    else
        Console.WriteLine("Точка находится на координатной оси");
}

int CheckKoord2(int x, int y)
{
    int res = 0;
    if (x>0 && y>0)
        res =1;
    else if (x>0 && y<0)
        res=4;
    else if (x<0 && y<0)
        res=3;
    else if (x<0 && y>0)
        res=2;
    return res;
}


Console.WriteLine("Введите координату X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());
// CheckKoord(x,y);
// CheckKoord(8, -8);
int vivod = CheckKoord2(x,y);
Console.WriteLine($"Точка находится в четверти № {vivod}");
