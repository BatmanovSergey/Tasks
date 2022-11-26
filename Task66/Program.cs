// Задача 66: Домашняя работа
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// Пример:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalElements(int num1, int num2)
{
    if (num1 == num2) return num2;
    return num1 + SumNaturalElements(num1 + 1, num2);
}

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > M)
{
    int sumNaturalElements = SumNaturalElements(M, N);
    Console.Write($"сумму натуральных элементов в промежутке от {M} до {N} = {sumNaturalElements}");
}
else if (M > N)
{
    int sumNaturalElements = SumNaturalElements(N, M);
    Console.Write($"сумму натуральных элементов в промежутке от {N} до {M} = {sumNaturalElements}");
}
else Console.Write("Введёные числа равны");
Console.WriteLine();
