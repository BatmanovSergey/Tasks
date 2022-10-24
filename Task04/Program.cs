// задача 04 Домашняя работа
// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное их этих чисел

Console.Write("Введите целое число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine($"Max = {max}");