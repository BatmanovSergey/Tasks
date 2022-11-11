// Задача 31: 
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, 
// в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Решение.

int[] CreateArrayRndInt(int size, int min, int max) // Метод создания массива
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array) // Метод вывода массива на печать
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int[] GetSumPositiveNegativeElem(int[] array) // Метод нахождения сумму отрицательных 
                                              // и положительных элементов массива
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositive += array[i];
        else sumNegative += array[i];
    }
    // return new int[] { sumPositive, sumNegative }; Другой вид записи строк ниже
    // без создания дополнительной переменной
    int[] result = { sumPositive, sumNegative };
    return result;
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);

int[] getSumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов массива= {getSumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов массива= {getSumPositiveNegativeElem[1]}");
