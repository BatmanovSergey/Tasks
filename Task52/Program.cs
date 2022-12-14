// Задача 52. Домашняя работа
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - 0 номер измерения - строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) - 1 номер измерения - столбцы
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} |");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" |");
    }
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double[] ArithmeticColumnsElements(int[,] matrix)
{
    double[] arithmeticSum = new double[matrix.GetLength(1)];
    int count = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        arithmeticSum[count] = Math.Round(sum / matrix.GetLength(0), 1);
        count++;
    }
    return arithmeticSum;
}

Console.Write("Введите количество строк в массиве: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите число - нижняя граница диапазона: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите число - верхняя граница диапазона: ");
int num4 = Convert.ToInt32(Console.ReadLine());

int[,] arr = CreateMatrixRndInt(num1, num2, num3, num4);
Console.WriteLine($"Наш массив случайных чисел от {num3} до {num4}:");
PrintMatrix(arr);
Console.WriteLine();

double[] arithmeticColumnsElements = ArithmeticColumnsElements(arr);
Console.Write($"Среднее арифметическое каждого столбца:");
PrintArray(arithmeticColumnsElements);
