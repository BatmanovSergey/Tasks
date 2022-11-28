// Задача 62. Домашняя работа
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] CreateMatrixSnail(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int count = 1;
    int startCol = 0;
    int endCol = columns - 1;
    int startRow = 0;
    int endRow = rows - 1;
    while (startCol <= endCol && startRow <= endRow)
    {
        for (int i = startCol; i <= endCol; i++)
        {
            matrix[startRow, i] = count;
            count++;
        }
        startRow++;

        for (int i = startRow; i <= endRow; i++)
        {
            matrix[i, endCol] = count;
            count++;
        }
        endCol--;

        for (int i = endCol; i >= startCol; i--)
        {
            matrix[endRow, i] = count;
            count++;
        }
        endRow--;

        for (int i = endRow; i >= startRow; i--)
        {
            matrix[i, startCol] = count;
            count++;
        }
        startCol++;
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

Console.Write("Введите количество строк в массиве: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] createMatrixSnail = CreateMatrixSnail(num1, num2);
PrintMatrix(createMatrixSnail);