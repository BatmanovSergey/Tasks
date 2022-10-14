// задача 05
// Напишите программу, которая на вход принимает 
// одно число (N), а на выходе показывает все целые числа в промежутке от -N до N. 
// например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2" 

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1)
    Console.WriteLine("Недопустимое число");
else
{
    int count = -num;
    while (count <= num)
    {
        Console.Write($"{count} ");
        count = count + 1;
    }
}


