// Задача 22 
// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0) Console.WriteLine($"Некорректное число");
else Table(num);

void Table(int number) // Метод void - не будет возвращать никакого значения
{ 
        int count = 1;
        while (count <= number)
        {           
           Console.WriteLine($"{count, 4} || {count*count, 4}");
// Дополнительное форматирование строки: после count ставим число, оно показывает длину строки для вывода, 
// в которой у нас будет сожержаться значение
           count++;
        }
}