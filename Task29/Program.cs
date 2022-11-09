// Задача 29. Домашняя работа
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// пример:
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// Решение:

int[] CreateFillArray(int amount) // метод 1
{
    int[] arr = new int[amount];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100, 101);
    }
    return arr;
}

void PrintArray(int[] array) // метод 2
{
    if (array.Length == 0) Console.WriteLine("В массиве ноль элементов");
    else
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}

Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = CreateFillArray(num);
PrintArray(array);
