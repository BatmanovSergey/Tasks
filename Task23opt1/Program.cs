// Задача 23. Домашняя работа
// Напишите программу, которая
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// Решение через переменную double  с использованием встроенного метода Math.Pow

Console.Write("Введите натуральное число: ");
double num = Convert.ToDouble(Console.ReadLine());

if (num <= 0) Console.WriteLine($"Некорректное число");
else Table(num);

void Table(double number) 
{ 
        double count = 1;
        while (count <= number)
        {           
           Console.WriteLine($"{count, 4} | {Math.Pow(count, 3), 4}");
           count++;
        }
}