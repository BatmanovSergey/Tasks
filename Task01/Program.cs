﻿// Напишите программу, которая на вход принимает два числа и 
// проверяет является ли первое чсило квадратом второго
// Например:
// a=25, b=5 -> да
// a=2, b=10 -> нет
// a=9, b=-3 -> да
// a=-3, b= 9-> нет

Console.Write("Введите целое число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}