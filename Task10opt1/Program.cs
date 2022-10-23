// задача 10.
// Напишите программу, которая принимает на вход трёхзначное число и 
// и на выходе показывает вторую цифру этого числа.
// пример:
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Решение оптимизированное через использование 2-х методов

bool IsThreeDigit(int number) // метод 1
{
    return (number > 99 && number < 1000 || number < -99 && number > -1000);
}

int SecondNumber(int number) // метод 2
{
    if (number < 0) number = -number; // переводим отрицательные в положительные
    return number = number / 10 % 10;
}

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool digit = IsThreeDigit(num);

int secondNumber = SecondNumber(num);

Console.WriteLine(digit ? $"вторая цифра числа {num} равна {secondNumber}": $"число {num} не трехзначное");

// другой вариант записи строки выше
// if (digit) Console.WriteLine($"вторая цифра числа {num} равна {SecondNumber(num)}");
// else Console.WriteLine($"число {num} не трехзначное");