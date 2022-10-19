// задача 13.
// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Write("Введите положительное трёхзначное число: ");
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
    int answer = number;
    while (answer > 1000)
    {
        answer = answer / 10;
    }
    return ThirdDigitRem(answer);
}

int ThirdDigitRem(int number) // наш метод 2
{
    return number % 10;
}