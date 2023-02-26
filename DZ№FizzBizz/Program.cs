// Задача необязательная FIZZ BUZZ: Напишите программу, которая выводит на экран числа от 1 до 100. При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz. Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz. Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.

int start = 1;
int finish = 100;
int tri = start % 3;
int fiv = start % 5;
while (start<=finish)
{
    tri = start % 3;
    fiv = start % 5;
    if ((tri == 0) && (fiv > 0))
    Console.Write ("Fizz ");
    else if ((tri > 0) && (fiv == 0))
    Console.Write ("Buzz ");
    else if ((tri == 0) && (fiv == 0))
    Console.Write ("FizzBuzz ");
    else
    Console.Write (start + " ");
    start++;
}

