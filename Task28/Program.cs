// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int Factorial(int number)
{
    int fact = 1;
    for (int i = 1; i <= number; i++)
    {
        fact = fact*i;
    }
    return fact;
}

Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(num);
Console.Write($"произведение чисел от 1 до {num} = {factorial}");
