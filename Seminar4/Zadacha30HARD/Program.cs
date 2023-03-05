// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// возвращает значение true, если единиц больше нулей

int[] CreateArr(){
  int[] tempArr = new int[8];
  for (int i = 0; i < tempArr.Length; i++){
    int randomNum = new Random().Next(0, 2);
    tempArr[i] = randomNum;
  }
  return tempArr;
}

void PrintArr(int[] tempArr){
  foreach (int i in tempArr){
      Console.Write(i + " ");
  }
}

bool NumCheck(int[] tempArr){
  int countOne = 0;
  int countZero = 0;

  for (int i = 0; i < tempArr.Length; i++){
    if(tempArr[i] == 0) countZero++;
    else countOne++;
  }
  return countOne > countZero ? true: false;
}

int[] arr = CreateArr();
PrintArr(arr);
Console.WriteLine();
Console.WriteLine(NumCheck(arr));
