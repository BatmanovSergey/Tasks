// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Метод 1

void NaturalNumbers1(int num)
{
    if (num == 0) return;
    NaturalNumbers1(num - 1); // хвостовая рекурсия, если эта строка будет стоять перед Console.Write($"{num}");
    Console.Write($"{num} "); // значения будут выводиться от больлшего к меньшему
}

Console.Write("Решение методом 1: ");
NaturalNumbers1(number);
Console.WriteLine();

//  метод 2

void NaturalNumbers2(int num)
{
    if (num > 0)
    {
        NaturalNumbers2(num - 1);
        Console.Write($"{num} ");
    }
}

Console.Write("Решение методом 2: ");
NaturalNumbers2(number);
Console.WriteLine();
