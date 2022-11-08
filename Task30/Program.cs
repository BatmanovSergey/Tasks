// Задача 30: 
// Напишите программу, которая выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// Пример: [1,0,1,1,0,1,0,0]

// Простое решение

int[] FillArray(int[] size) // метод заполнения массива
{
    for (int i = 0; i < size.Length; i++)
    {
        size[i] = new Random().Next(0, 2); // берутся случайные числа от 0 до 1, число 2 не входит
    }
    return size;
}

void PrintArray(int[] arr) // метод вывода массива на печать
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " "); // через добавления "+" можем прибавлять необходимые данные на выдачу
    }
}

int[] array = new int[8]; // создаем массив, по умолчанию он заполнен нулями
FillArray(array); // вызываем метод заполнения массива и рандомно заполняем его 0 и 1
PrintArray(array); // выводим массив на печать

// Ещё один вариант решения:

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i]= new Random().Next(0,2);
//     }
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i!=arr.Length -1 )Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }

// int[] array =new int [8];
// FillArray(array);
// PrintArray(array);


