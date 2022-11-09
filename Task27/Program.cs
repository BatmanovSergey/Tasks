// Задача 27. Домашняя работа.
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// Пример:
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) Console.Write("Некорректное число, введите положительное число: ");
else
{
    int sumdigits = SumDigits(num);
    Console.WriteLine($"Сумма цифр числа {num} = {sumdigits}");
}