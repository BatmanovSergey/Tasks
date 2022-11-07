// Задача 26: 
// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountDigits(int num)
{
    int count = 0;
    while (num != 0) // пока num неравно 0
    {
        count++; // count = count + 1
        num /= 10; // num = num / 10;
    }
    if (count == 0) count = 1;
    return count;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int countDigits = CountDigits(number);
Console.WriteLine($"В числе {number} - {countDigits} цифр(а).");