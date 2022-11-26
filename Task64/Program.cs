// Задача 64: Домашняя работа
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumbers1(int num)
{ 
    if (num > 1)
    {
    Console.Write($"{num}, "); 
    NaturalNumbers1(num - 1);
    }
    if (num == 1) Console.Write($"{num}");  
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {number} -> \"");
NaturalNumbers1(number);
Console.Write("\"");
