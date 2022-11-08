// Задача 30: 
// Напишите программу, которая выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// Пример: [1,0,1,1,0,1,0,0]

// Решение оптимизированное: создание и заполнение массива внутри метода

int[] CreateFillArray(int amount) // Метод создания и запролнения массива
{
    int[] arr = new int[amount];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Введите размер массива ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = CreateFillArray(num);
PrintArray(array);
