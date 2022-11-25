// Задача 60. Домашняя работа
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrix3D(int rows, int columns, int depth, int min, int max) // Метод создания и заполнения трёхмерного массива
{
    int[,,] matrix = new int[rows, columns, depth];
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i, j, k] = min;
                    min++;
                }
            }
        }
    }
    return matrix;
}

void PrintMatrix3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2)) Console.Write($"{matrix[i, j, k],3} ({i},{j},{k}) |");
            }
        }
    }
}

Console.Write("Введите первую размерность массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую размерность массива:: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третьюю размерность массива:: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите число - нижняя граница диапазона: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите число - верхняя граница диапазона: ");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,,] matr = CreateMatrix3D(num1, num2, num3, minimum, maximum);
if (matr.Length <= maximum - minimum)
{
    Console.WriteLine("Наш массив случайных чисел: ");
    PrintMatrix3D(matr);
    Console.WriteLine();
}
else Console.WriteLine("Размер данного массива не позволяет "
                     + "заполнить его неповторяющимися двузначными числами");



// int[,,] CreateMatrix3D(int rows, int columns, int depth, int min, int max) // Метод создания и заполнения трёхмерного массива
// {
//     int[,,] matrix = new int[rows, columns, depth];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 Random rnd = new Random();
//                 int num = rnd.Next(min, max + 1);

//             }
//         }
//     }
//     return matrix;
// }

// int[,,] matr = CreateMatrix3D(2, 2, 2, 1, 10);
// Console.WriteLine("Наш массив случайных чисел: ");
// PrintMatrix3D(matr);
// Console.WriteLine();