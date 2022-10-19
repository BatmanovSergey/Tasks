// задача 13.
// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Write("Введите положительное трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100) Console.WriteLine($"У числа {num} третьей цифры нет");

else if (num > 1000)
{
    int thirdDigit1 = ThirdDigit1(num);
    Console.WriteLine($"У числа {num} третья цифра это {thirdDigit1}");
}

else if (num < 1000)
{
    int thirdDigit2 = ThirdDigit2(num);
    Console.WriteLine($"У числа {num} третья цифра это {thirdDigit2}");
}

int ThirdDigit1(int number) // наш метод 1
{
    int answer = number;
    while (answer > 1000)
    {
        answer = answer / 10;
    }
    return ThirdDigit2(answer);
}

int ThirdDigit2(int number) // наш метод 2
{
    return number % 10;
}