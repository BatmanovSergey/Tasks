// Задача 20
// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве (на плоскости).
// Пример:
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// пример оператора Math.Sqrt:
// double d = Math.Sqrt(45); встроенный оператор возвращает тип double (вещественное число)
// записываем туда значение квадратного корня числа

// пример округления:
// double s = 5.099965343; наше число
//     оператор округления    кол-во знаков после запятой
// double res = Math.Round(s,         2,                   MidpointRounding.ToZero);
//        аргументы   =   наше число                         стратегия округления
// System.Console.WriteLine(res); выдаст результат 5,09

Console.WriteLine("Введите координаты точки A: ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int xb, int yb)
{
double d = Math.Sqrt((xa-xb)*(xa-xb) + (ya-yb)*(ya-yb));
return d;
}

double distance = Distance(x1, y1, x2, y2);
Console.Write($"Расстояние между точками A и B = {Math.Round(distance, 2, MidpointRounding.ToZero )}");
