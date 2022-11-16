// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями: 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// Пример:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Решение

double[] CoordinatesPoint(double n1, double m1, double n2, double m2)
{
    double[] array = new double[2];
    double x = (n2 - n1) / (m1 - m2);
    double y = (m1 * x) + n1;
    array[0] = x;
    array[1] = y;
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


Console.WriteLine("Введите значения для первой прямой: ");
Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значения для второй прямой: ");
Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (b1 != b2 && k1 == k2) Console.WriteLine("Заданные прямые не имеют общих точек. Они параллельны друг другу");
else if (b1 == b2 && k1 == k2) Console.WriteLine("Заданные прямые коллинеарны");
else
{
    double[] arr = CoordinatesPoint(b1, k1, b2, k2);
    Console.Write($"Координаты общей точки заданных прямых: ");
    PrintArray(arr);
}

