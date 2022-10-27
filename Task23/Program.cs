// Задача 23. Домашняя работа
// Напишите программу, которая
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// Простое решение

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0) Console.WriteLine($"Некорректное число");
else Console.WriteLine($"Таблица кубов чисел от 1 до {num}:");
Table(num);

void Table(int number) // Метод
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count,4} || {count * count * count,4}");
        count++;
    }
}
