// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

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

int[] arr = CreateArr();
PrintArr(arr);