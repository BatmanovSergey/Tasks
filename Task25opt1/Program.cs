// Задача 25. Домашняя работа
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Пример: 
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Решение для всех чисел

double Degree(int num1, int num2)
{
    int count = 1;
    int index = -1;
    double deg = 1;
    while (count <= num2)
    {
        deg = deg * num1;
        count++;
    }
    while (index >= num2)
    {
        deg = deg* (1/(double)num1);
        index--;
    }
    return deg;
}

Console.Write("Введите число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == 0 && number2 < 0) Console.Write($"Решений нет");
else
{
    double degree = Degree(number1, number2);
    Console.Write($"число {number1} возведённое в степень {number2} = {degree}");
}