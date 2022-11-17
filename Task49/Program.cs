// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} |");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");
    }

}

void ChangeMatrix(int[,] matrix)
{
    //первый вариант цикла проходит по всем элементам
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
        }
    }

    // // Второй вариант цикла проходит только по чётным элементам и не нужна отдельная проверка на чётность
    // for (int i = 0; i < matrix.GetLength(0); i+=2)
    // {
    //     for (int j = 0; j < matrix.GetLength(1); j+=2)
    //     {
    //         matrix[i, j] *= matrix[i, j];
    //     }
    // }
}

int[,] array = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array);
ChangeMatrix(array);
Console.WriteLine();
PrintMatrix(array);
