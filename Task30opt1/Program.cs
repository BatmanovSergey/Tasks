// Задача 30: 
// Напишите программу, которая выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// Пример: [1,0,1,1,0,1,0,0]

// Решение оптимизированное: создание и заполнение массива внутри метода

int[] CreateFillArray(int amount) // Метод создания и заполнения массива
{
    int[] arr = new int[amount]; // создаем массив с количеством элементов, которые задаёт пользователь

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2); // берутся случайные числа от 0 до 1, число 2 не входит
    }
    return arr;
}

void PrintArray(int[] array) // метод вывода массива на печать
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); // через добавления "+" можем прибавлять необходимые данные на выдачу
    }
}

Console.Write("Введите размер массива ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = CreateFillArray(num);
PrintArray(array);


// Ещё один вариант решения

// int[] CreateArray(int len)
// {
//     int[] arr = new int[len];
// // Тип данных Random и переменная rnd
//     Random rnd = new Random(); //выносим генератор случайных чисел из цикла, 
//                                //чтобы гарантированно получать случайные числа                                
//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = rnd.Next(0, 2);
//     }
//     return arr;
// }

// void PrintArray (int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i<arr.Length; i++)
//     {
//         Console.Write(arr[i]);
//         if (i<arr.Length-1) Console.Write(",");
//     }
//     Console.WriteLine("]");
// }

// Console.Write("Введите количество элементов массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(length);
// PrintArray(array);
