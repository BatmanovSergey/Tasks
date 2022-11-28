// Задача 54: Домашняя работа
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void OrderingRowsArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int maxrow = i;
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int maxcol = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[maxrow, maxcol]) maxcol = k;
            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[maxrow, maxcol];
            matrix[maxrow, maxcol] = temp;
        }
    }
}


int[,] matr = CreateMatrixRndInt(3, 4, -10, 10);
Console.WriteLine("Наш массив случайных чисел: ");
PrintMatrix(matr);
Console.WriteLine();
Console.WriteLine("Массив с упорядочением элементов по убыванию в каждой строке: ");
OrderingRowsArray(matr);
PrintMatrix(matr);

// void MatrixSort(int[,] matrix)
// {
//     for (int row = 0; row < matrix.GetLength(0); row++)
//     {
//         for (int column = matrix.GetLength(1) - 1; column > 0; column--)
//         {
//             int minIndex = column;
//             for (int j = 0; j < column; j++)
//             {
//                 if (matrix[row, j] < matrix[row, minIndex])
//                     minIndex = j;
//             }
//             if (minIndex != column)
//             {
//                 (matrix[row, minIndex], matrix[row, column]) = (matrix[row, column], matrix[row, minIndex]);
//             }
//         }
//     }
// }