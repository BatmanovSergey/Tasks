// задача 09. Напишите программу, которая выводит
// 1. случайное число из отрезка [10, 99] и показывает
// 2. наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100);

Console.WriteLine($"Случайное число из диапазаона 10-99 {num}");

int first = num / 10; //78 / 10 = 7
int second = num % 10; //78 % 10 = 8

if (first > second) Console.WriteLine($"наибольшая цифра числа {num} = {first}");
else Console.WriteLine($"наибольшая цифра числа {num} = {second}");

// int num = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {num}");

// int firstDigit = num / 10; // 78 / 10 = 7
// int secondDigit = num % 10; // 78 % 10 = 8

// int res = firstDigit;
// if(secondDigit > firstDigit) res = secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {num} = {res}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {num} = {result}");

// Console.Write($"Наибольшая цифра числа {num} = ");
// Console.Write(firstDigit > secondDigit ? firstDigit : secondDigit);

int MaxDigit(int number)
{
    int firstDigit = number / 10; // 78 / 10 = 7
    int secondDigit = number % 10; // 78 % 10 = 8
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {num}");

int maxDigit = MaxDigit(num);
Console.WriteLine($"Наибольшая цифра числа {num} = {maxDigit}");
