// Задача 29. Домашняя работа
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// пример:
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// Решение:

int[] CreateFillArray(int amount) // метод 1
{
    int[] arr = new int[amount];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 101);
    }
    return arr;
}

void PrintArray(int[] array) // метод 2
{
    Console.Write($"[{array[0]},");
    for (int i = 1; i < array.Length-1; i++)
    {
        Console.Write($" {array[i]},");
    }
    Console.WriteLine($" {array.Length-1}]");
}

Console.Write("Введите размер массива ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = CreateFillArray(num);
PrintArray(array);
