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
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[,] RemoveRowColumnMin(int[,] matrix, int[] arr)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int row = 0; // индекс строки исходной матрицы
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (row == arr[0]) row++;
        int column = 0; // индекс столбца исходной матрицы
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (column == arr[1]) column++;
            newMatrix[i, j] = matrix[row, column];
            column++;
        }
        row++;
    }
    return newMatrix;
}


int[,] matr = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matr);
Console.WriteLine();

int[] minElementMatrix = MinElementMatrix(matr);
PrintArray(minElementMatrix);
Console.WriteLine();
Console.WriteLine($"Минимальный элемент в строке с индексом {minElementMatrix[0]},"
                + $"столбце с индексом {minElementMatrix[1]}"); 
Console.WriteLine(); 
int[,] removeRowColumnMin = RemoveRowColumnMin(matr, minElementMatrix);
PrintMatrix(removeRowColumnMin);
