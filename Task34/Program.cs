// Задача 34. Домашняя работа
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример: [345, 897, 568, 234] -> 2

// Решение.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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

int EvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write("Введите размер массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите положительное трёхзначное число - нижняя граница диапазона: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите положительное трёхзначное число - верхняя граница диапазона: ");
int num3 = Convert.ToInt32(Console.ReadLine());

// вариант условий при неверном вводе данных пользователем
if (num1 > 0)
{
    if (num2 <= num3)
    {
        if (num2 > 99 && num2 < 1000 && num3 > 99 && num3 < 1000)
        {
            int[] arr = CreateArrayRndInt(num1, num2, num3);
            PrintArray(arr);
            int evenElements = EvenElements(arr);
            Console.WriteLine($"количество чётных чисел в массиве = {evenElements}");
        }
        else Console.WriteLine("Неверный диапазон. Введите в диапазон трёхзначные положительные числа");
    }
    else Console.WriteLine("Неверный диапазон. Верхняя граница диапазона не может быть меньше нижней границы");
}
else Console.WriteLine("Неверный размер массива");