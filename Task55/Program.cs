// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] ChangeArray(int[,] matrix)
{
    int[,] newmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < newmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newmatrix.GetLength(1); j++)
        {
            newmatrix[i, j] = matrix[j, i];
        }
    }
    return newmatrix;
}

int[,] matr = CreateMatrixRndInt(3, 3, -5, 5);
PrintMatrix(matr);
Console.WriteLine();

if (matr.GetLength(0) == matr.GetLength(1))
{
    int[,] changeArray = ChangeArray(matr);
    PrintMatrix(changeArray);
}
else Console.WriteLine("Массив не квадратный, замена невозможна.");

// void ReplaceRowsColumns(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0) - 1; i++)
//     {
//         for (int j = i + 1; j < matr.GetLength(1); j++)
//         {             // int temp = matr[i,j];     
//                       // matr[i,j] = matr[j,i];          
//                       // matr[j,i] = temp;          
//             (matr[i, j], matr[j, i]) = (matr[j, i], matr[i, j]);
//         }
//     }
// }

// Console.Write("Введите количество строк массива: m=");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: n=");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateMatrixRndInt(m, n, -5, 5);
// PrintMatrix(matrix);
// Console.WriteLine(); 
// if (m == n)
// {
//     ReplaceRowsColumns(matrix); 
//     PrintMatrix(matrix);
// }
// else Console.WriteLine("Массив не квадратный, замена невозможна.");
