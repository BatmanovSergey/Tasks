// Задача 44: 
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int[] CreateArrayFib(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        if (i < 2) array[i] = i;
        else array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int [] fib = CreateArrayFib(num);
Console.Write($"Первые {num} чисел Фибоначчи: ");
PrintArray(fib);
