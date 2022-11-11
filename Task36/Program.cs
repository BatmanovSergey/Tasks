// Задача 36. Домашняя работа
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Пример:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumElementsOddPosition(int[] array)
{
    // int sum = 0;
    // for (int i = 1; i < array.Length; i = i + 2)
    // {
    //     sum = sum + array[i];
    // }
    // return sum;

    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2==1) sum = sum + array[i];
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите число - нижняя граница диапазона: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите число - верхняя граница диапазона: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(num1, num2, num3);
PrintArray(arr);
int sumElementsOddPosition = SumElementsOddPosition(arr);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {sumElementsOddPosition}");


// int num = 0%2;
// Console.WriteLine(num);
