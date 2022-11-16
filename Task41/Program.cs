// Задача 41: Домашняя работа
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int PositiveElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Write("Введите количество чисел для проверки: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(m);
int positiveElements = PositiveElements (arr);

Console.Write("Введёные числа для проверки: ");
PrintArray(arr);
Console.Write($"Количество введёных положительнх чисел равно {positiveElements}");
