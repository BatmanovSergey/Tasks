// задача 10.
// Напишите программу, которая принимает на вход трёхзначное число и 
// и на выходе показывает вторую цифру этого числа.
// пример:
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondNumber(int number) // наш метод
// {
//     int firstAction = number / 10;
//     int secondAction = firstAction % 10;
//     return secondAction;
// }

// Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 1000 || num < -1000) Console.WriteLine($"{num} - Не трёхзначное число");

// else if (num > 0)
// {
//     int secondNumber = SecondNumber(num);
//     Console.WriteLine($"Вторая цифра числа {num} = {secondNumber}");
// }

// else
// {
//     int num1 = num * -1;
//     int secondNumber = SecondNumber(num1);
//     Console.WriteLine($"Вторая цифра числа {num} = {secondNumber}");
// }


bool IsThreeDigit(int number)
{
    return (number > 99 && number < 1000 || number < -99 && number > -1000);
}

int SecondNumber(int number) // наш метод
{
    if (number < 0) number = -number; // переводим отрицательные в положительные
    // либо одна строка вместо трёх строк ниже: return number = number / 10 % 10;
    int firstAction = number / 10;
    int secondAction = firstAction / 10 % 10;
    return secondAction / 10 % 10;  
}

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool digit = IsThreeDigit(num);

Console.WriteLine(digit ? $"вторая цифра числа {num} равна {SecondNumber(num)}": $"число {num} не трехзначное");

// другой вариант записи строки выше
// if (digit) Console.WriteLine($"вторая цифра числа {num} равна {SecondNumber(num)}");
// else Console.WriteLine($"число {num} не трехзначное");