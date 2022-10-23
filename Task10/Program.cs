// задача 10.
// Напишите программу, которая принимает на вход трёхзначное число и 
// и на выходе показывает вторую цифру этого числа.
// пример:
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Простое решение с длинным условием, через метод

int SecondNumber(int number) // наш метод
{
    if (number < 0) number = -number; // переводим отрицательные в положительные
    int firstAction = number / 10;
    int secondAction = firstAction % 10;
    return secondAction;
}

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1000 || num <= -1000 || num < 99 && num > -99) Console.WriteLine($"{num} - Не трёхзначное число");

else
{
    int secondNumber = SecondNumber(num);
    Console.WriteLine($"Вторая цифра числа {num} = {secondNumber}");
}