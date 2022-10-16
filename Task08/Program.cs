// Задача 08
// Напишите программу, которая на вход принимает число N,
// а на выходе показывает всё чётные числа от 1 до N.


Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1)
    Console.WriteLine("Недопустимое число");
else
{
    int count = 2;
    while (count <= num)
    {
        Console.Write($"{count} ");
        count = count + 2;
    }
}