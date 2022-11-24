// Задача 65: 
// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 8; N = 4 -> "8, 7, 6, 5, 4"

Console.Write("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

// Решение 1:

void NaturNumbers(int num1, int num2)
{
    if(num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturNumbers(num1 + 1, num2);
    }
    if(num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturNumbers(num1 - 1, num2);
        
    }
    if(num1 == num2) Console.Write($"{num1} ");
}

Console.Write("Решение методом 1: ");
NaturNumbers(m,n);
Console.WriteLine();

// Решение 2: тернарный оператор

void NaturalNumbersMN(int numM, int numN)
{
    if (numM == numN)
    {
        Console.Write($"{numM} ");
        return;
    }
    Console.Write($"{numM} ");
    NaturalNumbersMN(numM > numN ? numM - 1 : numM + 1, numN);
}

Console.Write("Решение методом 2: ");
NaturalNumbersMN(m, n);
Console.WriteLine();


