// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k++] = matrix[i, j];
        }
    }
    return arr;
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

void Dictionary(int[] array)
{
    int num = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == num) count++;
        else
        {
            Console.WriteLine($"число {num} встречается {count} раз");
            num = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"число {num} встречается {count} раз");
}

int[,] matr = CreateMatrixRndInt(5, 5, 1, 9);
Console.WriteLine("Наша рандомная матрица");
PrintMatrix(matr);
Console.WriteLine();

int[] matrixToArray = MatrixToArray(matr);
Console.WriteLine("Наш одномерный массив выведенный из матрицы");
PrintArray(matrixToArray);
Console.WriteLine();
Console.WriteLine();

Array.Sort(matrixToArray);
Console.WriteLine("Наш отсортированный одномерный массив");
PrintArray(matrixToArray);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Наш частотный словарь по данному массиву:");
Dictionary(matrixToArray);
