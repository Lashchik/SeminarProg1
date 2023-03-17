// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

static void Array()
{Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Random random = new Random();
for (int i = 0; i < length; i++) {
array[i] = random.Next(-100, 100);}
    int max = array[0];
    int maxIndex = 0;
for (int i = 1; i < length; i++) {
    if (array[i] > max) {
        max = array[i];
        maxIndex = i;}}
    int min = array[0];
    int minIndex = 0;
for (int i = 1; i < length; i++) {
    if (array[i] < min) {
        min = array[i];
        minIndex = i;}}
double sum = 0;
for (int i = 0; i < length; i++) 
{sum += array[i];}
    double average = sum / length;
    object[] results = new object[5];
results[0] = max;
results[1] = maxIndex;
results[2] = min;
results[3] = minIndex;
results[4] = average;
Console.WriteLine("Исходный массив: " + string.Join(", ", array));
Console.WriteLine("Максимальный элемент: " + results[0] + ", его индекс: " + results[1]);
Console.WriteLine("Минимальный элемент: " + results[2] + ", его индекс: " + results[3]);
Console.WriteLine("Среднее арифметическое: " + results[4]);
double median;
if (length % 2 == 0) {
    median = (array[length / 2 - 1] + array[length / 2]) / 2.0;
} else
{median = array[length / 2];}
Console.WriteLine("Медианное значение: " + median);}
Array();