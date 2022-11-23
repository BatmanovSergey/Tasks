// Задача 58: Домашняя работа
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newmatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;
            for (int r = 0; r < matrix1.GetLength(1); r++)
            {
                sum = sum + (matrix1[i, r] * matrix2[r, j]);
            }
            newmatrix[i, j] = sum;
        }
    }
    return newmatrix;
}

Console.Write("Введите количество строк в первой матрице: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в первой матрице: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк во второй матрице: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов во второй матрице: ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matr1 = CreateMatrixRndInt(num1, num2, 1, 10);
int[,] matr2 = CreateMatrixRndInt(num3, num4, 1, 10);

if (matr1.GetLength(1) != matr2.GetLength(0))
{
    Console.WriteLine("Введены недопустимые размеры матриц, перемножение невозможно");
}
else
{
    Console.WriteLine("матрица 1:");
    PrintMatrix(matr1);
    Console.WriteLine();
    Console.WriteLine("матрица 2:");
    PrintMatrix(matr2);
    Console.WriteLine();

    int[,] multiplicationMatrix = MultiplicationMatrix(matr1, matr2);
    Console.WriteLine("Результирующая матрица, полученная произведением двух матриц:");
    PrintMatrix(multiplicationMatrix);
}