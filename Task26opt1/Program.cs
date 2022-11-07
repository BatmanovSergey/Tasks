// Задача 26: 
// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// решение с использованием модуля числа Math.Abs

int Digits(int number)
{
    int count = 0;
    int numberAbs = Math.Abs(number);
    while (numberAbs>0)
    {
        numberAbs = numberAbs/10;
        count++;
    }
    return count>0 ? count : 1; // тернарный оператор (если count>0 тогда возвращаем count иначе возвращаем 1)
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int digits = Digits(num);
Console.WriteLine($"количество цифр в числе {num} = {digits}");
