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

void ReplaceRowsColumns(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < matr.GetLength(1); j++)
        {             // int temp = matr[i,j];    // обычное решение через временную переменную 
                      // matr[i,j] = matr[j,i];          
                      // matr[j,i] = temp;          
            (matr[i, j], matr[j, i]) = (matr[j, i], matr[i, j]); // решение через кортеж
        }
    }
}

Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matr = CreateMatrixRndInt(m, n, -5, 5);
PrintMatrix(matr);
Console.WriteLine(); 
if (m == n)
{
    ReplaceRowsColumns(matr); 
    PrintMatrix(matr);
}
else Console.WriteLine("Массив не квадратный, замена невозможна.");
