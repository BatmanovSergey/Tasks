// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите натуральное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Метод 1:

int Degree(int number1, int number2)
{
    if (number2 == 0) return 1;
    return number1 * Degree(number1, number2 - 1);
}

Console.Write("Решение методом 1: ");

if (num2 >= 0)
{
    int degree = Degree(num1, num2);
    Console.Write($"Число {num1} в степени {num2} равно: {degree}");
}
else Console.Write("Введите натуральную степень числа");
Console.WriteLine();
// Метод 2: тернарный оператор

int Pow(int numA, int numB)
{
    return numB == 0 ? 1 : numA * Pow(numA, numB - 1);
}

Console.Write("Решение методом 2: ");

if (num2 >= 0)
{
    int pow = Pow(num1, num2);
    Console.Write($"Число {num1} в степени {num2} равно: {pow}");
}
else Console.Write("Введите натуральную степень числа");
Console.WriteLine();


