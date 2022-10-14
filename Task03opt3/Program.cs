// задача 03
// напишите программу, которая будет выдавать название дня недели
// по заданному номеру
// пример:
// 3-> Среда
// 4-> Четверг
// Оптимизация 3 Оператор switch

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
     Console.WriteLine("Понедельник");
        break;

    case 2:
     Console.WriteLine("Вторник");
        break;

    case 3:
     Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;

    case 5:
     Console.WriteLine("Пятница");
        break;

    case 6:
       Console.WriteLine("Суббота");
        break;

    case 7:
    Console.WriteLine("Воскресенье");
        break;

    default:
     Console.WriteLine("Такого дня недели не существует");
        break;
}