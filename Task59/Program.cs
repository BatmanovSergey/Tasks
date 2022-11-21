//Задача 59: Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец, на
//пересечении которых расположен наименьший элемент
//массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }
}

int[] MinElementMatrix(int[,] matrix)
{
    int min = matrix[0, 0];
    int row = 0;
    int column = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                row = i;
                column = j;
            }
        }
    }
    return new int[] { row, column };
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (i < array.Length - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
        }
    }
    Console.Write("] ");
}

int[,] RemoveRowColumnMin(int[,] matrix, int[] arr)
{
    int rowdel = arr[0];
    int columndel = arr[1];
    int[,] newmatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {

        }
    }
}

int[,] array = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array);
Console.WriteLine();

int[] minElementMatrix = MinElementMatrix(array);
PrintArray(minElementMatrix);