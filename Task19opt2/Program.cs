// задача 19. Домашняя работа
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Пример:
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Решение через разворот числа c использованием int numabs = Math.Abs(num) в начале программы

bool FiveDigit(int number) // метод 1
{
    return (number > 9999 && number < 100000);
}

bool Palindrome(int number1) // метод 2
{
    int reverse = 0;
    int temp = number1;
    while (temp > 0)
    {
        reverse = reverse * 10 + temp % 10;
        temp = temp / 10;
    }
    return (number1 == reverse);
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numabs = Math.Abs(num);

bool fiveDigit = FiveDigit(numabs);
if (fiveDigit)
{
    bool palindrom = Palindrome(numabs);
    Console.WriteLine(palindrom ? $"Число {num} пятизначное и является палиндромом"
                                : $"Число {num} пятизначное, но не является палиндромом");
}
else
{
    bool palindrom = Palindrome(numabs);
    Console.WriteLine(palindrom ? $"Число {num} не пятизначное, но является палиндромом"
                                : $"Число {num} не пятизначное и не является палиндромом");
}