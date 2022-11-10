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
    int modul = Math.Abs(number);
    while (modul > 0)
    {
        sum = sum + modul % 10;
        modul = modul / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sumdigits = SumDigits(num);
Console.WriteLine($"Сумма цифр числа {num} = {sumdigits}");