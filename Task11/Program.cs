// 11. Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого числа.
// Пример:
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число из диапазаона 100-1000 {num}");

// int first = num / 100; 
// int second = num % 10;
// int number = first*10+second;

// Console.WriteLine(number);

int FirstLastNumber(int number)
{
    int firstNumber = number / 100;
    int lastNumber = number % 10;
    return firstNumber*10 + lastNumber;
 }

int num = new Random().Next(100, 1000);

Console.WriteLine(num);
int final = FirstLastNumber(num); //я дописывал
Console.WriteLine(final);