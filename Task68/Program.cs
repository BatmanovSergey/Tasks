// Задача 68: Домашняя работа
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int num1, int num2)
{
    if (num1 == 0) return (num2 + 1);
    if (num1 > 0 && num2 == 0) return Ackermann(num1 - 1, 1);
    if (num1 > 0 && num2 > 0) return Ackermann(num1 - 1, Ackermann(num1, num2 - 1));
    return Ackermann(num1, num2);
}


Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int ackermann = Ackermann(M, N);
Console.Write($"Функция Аккермана для чисел {M} и {N} = {ackermann}");