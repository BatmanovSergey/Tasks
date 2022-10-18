// задача 10.
// Напишите программу, которая принимает на вход трёхзначное число и 
// и на выходе показывает вторую цифру этого числа.
// пример:
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondNumber(int number) // наш метод
{
    int firstAction = number / 10;
    int secondAction = firstAction % 10;
    return secondAction;
}

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 1000 || num < -1000) Console.WriteLine($"{num} - Недопустимое число! Введите заного трёхзначное число");

else if (num > 0)
{
    int secondNumber = SecondNumber(num);
    Console.WriteLine($"Вторая цифра числа {num} = {secondNumber}");
}

else if (num < 0)
{
    int num1 = num * -1;
    int secondNumber = SecondNumber(num1);
    Console.WriteLine($"Вторая цифра числа {num} = {secondNumber}");
}
