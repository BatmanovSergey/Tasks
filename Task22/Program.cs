// Задача 22
// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


void Table(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count}   {count*count}");
        count++;
    }
}

 Table(num);