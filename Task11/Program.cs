// задача 11. 
//Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.
// Пример:
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазаона 100-1000 {num}");

//Решение простое

int first = num / 100;
int second = num % 10;
int answer = first * 10 + second;

Console.WriteLine(answer);

// Решение через создание функции (метода)

int FirstLastNumber(int number) // создаем метод
{
    int firstNumber = number / 100;
    int lastNumber = number % 10;
    return firstNumber*10 + lastNumber;
 }

int final = FirstLastNumber(num); //вызываем метод и передадаём в него нашу рандомную цифру
Console.WriteLine(final);