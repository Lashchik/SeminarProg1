// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// Console.Write("Введите номер дня недели (от 1 до 7): ");

// try
// {
//   int num = Convert.ToInt32(Console.ReadLine());

//   switch (num)
//   {
//     case 1:
//       Console.WriteLine("Понедельник");
//       break;
//     case (2):
//       Console.WriteLine("Вторник");
//       break;
//     case (3):
//       Console.WriteLine("Среда");
//       break;
//     case (4):
//       Console.WriteLine("Четверг");
//       break;
//     case (5):
//       Console.WriteLine("Пятница");
//       break;
//     case (6):
//       Console.WriteLine("Суббота");
//       break;
//     case (7):
//       Console.WriteLine("Воскресенье");
//       break;
//     default:
//       Console.WriteLine("Введенное число выходит за рамки семидневной недели");
//       break;
//   }
// }
// catch (System.FormatException)
// {
//   Console.WriteLine("Введено некорректное число");
// }

Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine("Это понедельник");
        break;
    case 2:
        Console.WriteLine("Это вторник");
        break;
    case 3:
        Console.WriteLine("Это среда");
        break;
    case 4:
        Console.WriteLine("Это четверг");
        break;
    case 5:
        Console.WriteLine("Это пятница");
        break;
    case 6:
        Console.WriteLine("Это суббота");
        break;
    case 7:
        Console.WriteLine("Это воскресенье");
        break;
    default:
        Console.WriteLine("Введённое число не входит в рамки недели");
        break;
}