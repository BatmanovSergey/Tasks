// Задача 24.
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number) // формальный параметр 
{
    int sum = 0;
    for (int i = 1; i <= number; i++) // цикл
    {
        sum = sum + i; // sum+=i 
    }
    return sum;
}

if (num > 0) // условный оператор
{
    int sumNumbers = SumNumbers(num); // фактический параметр
    Console.WriteLine($"сумма чисел от 1 до {num} = {sumNumbers}");
}
else Console.WriteLine($"Введено некорректное число. Требуется ввести целое положительное число");