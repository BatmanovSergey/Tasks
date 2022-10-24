// задача 19.
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

int Palindrom(int number) // метод 2
{
    int first = number / 10000;
    int fifth = number % 10;
    int fourth = number % 10 % 10;
    int second = number % 10 % 10 % 10 % 10;
    if (first == fifth && second == fourth) return number;
    else return -1;
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool fiveDigit = FiveDigit(num);
if (fiveDigit)
{
    int palindrom = Palindrom(num);
    Console.WriteLine(palindrom == num ? $"Да, число {num} является палиндромом"
                                       : $"нет, число {num} не является палиндромом");
}
else Console.WriteLine($"Нет, число {num} не является пятизначным");
