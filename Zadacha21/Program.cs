﻿// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// программа х, у

// Console.WriteLine ("Введите номер четверти " );
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CheckKoord2(x));


// string CheckKoord2(int x)
// {
//     string res = "Введены некорректные значения";
//     if (x ==1)
//         res = "x>0, y>0" ;
//     else if (x ==4)
//         res = "x>0, y<0" ;
//     else if (x ==3)
//         res = "x<0, y<0" ;
//     else if (x ==2)
//         res = "x<0, y>0" ;
//     return res;
// }

// программа х, у

Console.WriteLine ("Введите номер четверти " );
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckKoord2(x));


string CheckKoord2(int x)
{
    string res = "Введены некорректные значения";
    if (x ==1)
        res = "x>0, y>0" ;
    else if (x ==4)
        res = "x>0, y<0" ;
    else if (x ==3)
        res = "x<0, y<0" ;
    else if (x ==2)
        res = "x<0, y>0" ;
    return res;
}