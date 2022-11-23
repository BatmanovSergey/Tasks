// Задача 56: Домашняя работа
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} |");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");
    }
}

int[] SumElementsInRow(int[,] matrix)
{
    int[] Sum = new int[matrix.GetLength(0)];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[i, j];
        }
        Sum[count] = sum;
        count++;
    }
    return Sum;
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

void RowPosition(int[] array)
{
    int minimum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minimum]) minimum = i;
    }
    Console.WriteLine($"Позиция строки с наименьшей суммой элементов: {minimum + 1}");
}

int[,] matr = CreateMatrixRndInt(5, 5, -10, 10);
Console.WriteLine("Наш массив случайных чисел: ");
PrintMatrix(matr);
Console.WriteLine();

int[] sumElementsInRow = SumElementsInRow(matr);
Console.WriteLine("Суммы элементов по строчкам: ");
PrintArray(sumElementsInRow);
Console.WriteLine();

RowPosition(sumElementsInRow);
