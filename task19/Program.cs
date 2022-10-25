// задача 19. Домашняя работа
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Пример:
// 14212 -> нет
// 23432 -> да
// 12821 -> да

bool FiveDigit(int number) // метод 1
{
    return (number > 9999 || number < -9999);
}

bool Palindrom(int number) // метод 2
{
    int first = number / 10000;
    int fifth = number % 10;
    int fourth = number % 10 % 10;
    int second = number % 10 % 10 % 10 % 10;
    return (first == fifth && second == fourth);
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool fiveDigit = FiveDigit(num);
if (fiveDigit)
{
    bool palindrom = Palindrom(num);
    Console.WriteLine(palindrom ? $"Да, число {num} является палиндромом"
                                : $"нет, число {num} не является палиндромом");
}
else Console.WriteLine($"Число {num} не является пятизначным");
