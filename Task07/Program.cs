﻿
// задача 07. 
// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает последнюю цифру этого числа. 
// пример:
// 456 -> 6
// 782 -> 2
// 918 -> 8 

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"{num % 10}");