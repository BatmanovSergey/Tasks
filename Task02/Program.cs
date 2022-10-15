// задача 02
// Напишите программу, которая на вход принимает два числа и выдаёт
// какое число большее и какое меньшее

Console.Write("Введите целое число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)

    Console.Write($"MAX = {num1} и MIN = {num2}");
else
    Console.Write($"MAX = {num2} и MIN = {num1}");
