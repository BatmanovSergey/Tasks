// Задача 68: Домашняя работа
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int num1, int num2)
{
    if (num1 == 0) return (num2 + 1);
    if (num1 > 0 && num2 == 0) return Ackermann(num1 - 1, 1);
    return Ackermann(num1 - 1, Ackermann(num1, num2 - 1));
}


Console.Write("Введите положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= 0 && n >= 0)
{
    int ackermann = Ackermann(m, n);
    Console.Write($"Функция Аккермана для чисел {m} и {n} = {ackermann}");
}
else Console.Write("Введены отрицательные числа!!! Введите положительные числа!!!");

