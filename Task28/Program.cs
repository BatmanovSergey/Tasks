// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int Production(int number)
{
    int prod = 1;
    for (int i = 1; i <= number; i++)
    {
        prod = prod*i;
    }
    return prod;
}

Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int production = Production(num);
Console.Write($"произведение чисел от 1 до {num} = {production}");

// Console.Write("введите число:");
// int a = Convert.ToInt32(Console.ReadLine());

// int Factorial(int num)
// {
//     int com = 1;

//     for (int i = 1; i <= num; i++)
//     {
//          com*= i;  
//     }
//     return com ;
// }

// int factorials = Factorial(a);
// Console.WriteLine($"Произведение чисел от 1 до {a} = {factorials}");
