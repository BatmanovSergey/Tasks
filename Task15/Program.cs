﻿// задача 15
// Напишите программу, которая принимает на вход цифру, обозначающую день недели
// и проверяет, является ли этот день выходным
// пример:
// 6-> Да
// 7-> Да
// 1-> Нет

// Решение первое, с использованием метода bool оператор

Console.Write("Введите число, соответствующее дню недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 8 && num > 0)
{
    bool day = Day(num);
    Console.WriteLine(day ? "Да-Выходной" : "Нет-Будний день");
}

else Console.WriteLine("Такого дня недели не существует");

bool Day(int number) // наш метод
{
    return (number == 6 || number == 7);
}

// Решение второе - простое без использования метода

if (num > 0 && num < 6) Console.WriteLine("Нет-Будний день");
else if (num >= 6 && num < 8) Console.WriteLine("Да-Выходной");
else Console.WriteLine("Такого дня недели не существует");
