// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Factorial(int n){
  int rst = 1;
  for (int i = 1; i <= n; i++){
    rst = rst * i;
  }
  return rst;
}

Console.WriteLine(Factorial(5));

// Решение с рекурсией
// int Factorial(int n){ 
//   int rst = 1; 
//   for (int i = 1; i <= n; i++){ 
//     rst = rst * i; 
//   } 
//   return rst; 
// } 
 
// int FactorialRec(int n){ 
//   if (n == 1) return 1; 
//   return n * (FactorialRec(n-1)); 
// } 
 
// Console.WriteLine(FactorialRec(5)); 
// Console.WriteLine(Factorial(5));

