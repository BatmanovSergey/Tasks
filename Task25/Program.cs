// Задача 25. Домашняя работа
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Пример: 
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int num1, int num2)
{
    int count = 1;
    int deg = 1;
    while (count <= num2)
    {
        deg = deg * num1;
        count++;
    }
    return deg;
}

Console.Write("Введите число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 <0) Console.Write($"{number2} некорректное число, введите положительное число2");
else
{
int degree = Degree(number1, number2);
Console.Write($"число {number1} возведённое в степень {number2} = {degree}");
}
