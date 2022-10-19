// задача 13.
// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645-> 5
// 78 -> третьей цифры нет
// 32679-> 6

Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100) Console.WriteLine($"У числа {num} третьей цифры нет");

else if (num > 1000)
{
    int thirdDigit = ThirdDigitInt(num);
    Console.WriteLine($"У числа {num} третья цифра это {thirdDigit}");
}

else if (num < 1000)
{
    int thirdDigit = ThirdDigitRem(num);
    Console.WriteLine($"У числа {num} третья цифра это {thirdDigit}");
}

int ThirdDigitInt(int number) // наш метод 1
{
    while (number > 1000)
    {
        number = number / 10;
    }
    return ThirdDigitRem(number);
}

int ThirdDigitRem(int number1) // наш метод 2
{
    return number1 % 10;
}