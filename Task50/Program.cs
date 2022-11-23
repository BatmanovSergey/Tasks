// Задача 50. Домашняя работа
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrix(int rows, int columns, int min, int max)
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

Console.Write("Укажите число - нижняя граница диапазона заполнения массива: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите число - верхняя граница диапазона заполнения массива: ");
int maximum = Convert.ToInt32(Console.ReadLine());

Random rnd1 = new Random();
int rndRows = rnd1.Next(1, 11);
Random rnd2 = new Random();
int rndColumns = new Random().Next(1, 11);
int[,] createMatrix = CreateMatrix(rndRows, rndColumns, minimum, maximum);
Console.WriteLine();

Console.WriteLine("Случайный двумерный массив создан");
Console.WriteLine();

Console.Write("Укажите номер строки искомого элемента: ");
int findrow = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите номер столбца искомого элемента: ");
int findcolumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// Решение через условие

Console.WriteLine("Решение через условие");

if (findrow - 1 >= 0 && findrow - 1 < createMatrix.GetLength(0) &&
    findcolumn - 1 >= 0 && findcolumn - 1 < createMatrix.GetLength(1))
{
    Console.WriteLine($"Да, в массиве такой элемент есть "
                    + $"и это {createMatrix[findrow - 1, findcolumn - 1]}");
}
else Console.WriteLine("Такого элемента в массиве нет");
Console.WriteLine();

// Решение моё первоначальное избыточное, с использованием метода, но без проверки на ввод отрицальных чисел

Console.WriteLine("Решение через избыточный метод");

bool FindElement(int[,] matrix, int numrow, int numcolunm)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == numrow - 1 && j == numcolunm - 1) return true;
        }
    }
    return false;
}

bool findElement = FindElement(createMatrix, findrow, findcolumn);
Console.WriteLine(findElement ? "Да, в массиве такой элемент есть "
                            + $"и это {createMatrix[findrow - 1, findcolumn - 1]}"
                            : "Такого элемента в массиве нет");
Console.WriteLine();

Console.WriteLine("Вывод массива для проверки:");
PrintMatrix(createMatrix);
