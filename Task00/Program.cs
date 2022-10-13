// Напишите программу, которая на вход
// 1.на вход принимает число
// 2.выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

// string str = Console.ReadLine();
// int n = Convert.ToInt32(str)

int square = num * num;
Console.WriteLine($"квадрат числа {num} = {square}");