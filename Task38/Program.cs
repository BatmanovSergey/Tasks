// Задача 38. Домашняя работа
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Пример
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max) // Метод создания массива из вещественных чисел
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double number = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(number, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}| ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double MaxElementArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinElementArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double DiffMaxMin (double[] array)
{
    double maximum = MaxElementArray(array);
    double minimum = MinElementArray(array);
    double res = maximum - minimum;
    double result = Math.Round(res, 1);
    return result;
}

Console.Write("Введите размер массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите число - нижняя граница диапазона: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите число - верхняя граница диапазона: ");
int num3 = Convert.ToInt32(Console.ReadLine());

double[] arr = CreateArrayRndDouble(num1, num2, num2);
PrintArray(arr);

double diffMaxMin = DiffMaxMin (arr);
Console.Write($"Разница между максимальным и минимальным элементами массива = {diffMaxMin}");