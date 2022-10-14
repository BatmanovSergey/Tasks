// задача 03
// напишите программу, которая будет выдавать название дня недели
// по заданному номеру
// пример:
// 3-> Среда
// 4-> Четверг
// Оптимизация 2

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 8 && num > 0)
{
    if (num == 1) Console.WriteLine("Понедельник");
    else if (num == 2) Console.WriteLine("Вторник");
    else if (num == 3) Console.WriteLine("Среда");
    else if (num == 4) Console.WriteLine("Четверг");
    else if (num == 5) Console.WriteLine("Пятница");
    else if (num == 6) Console.WriteLine("Суббота");
    else Console.WriteLine("Воскресенье");
}
else Console.WriteLine("Такого дня недели не существует");