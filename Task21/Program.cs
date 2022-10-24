// Задача 21. Домашняя работа
// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// Пример:
// A (3,6,8); B (2,1,-7) -> 15,84
// A (7,-5,0); B (1,-1,9) -> 11,53

Console.WriteLine("Введите координаты точки A: ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double d = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));
    return d;
}

double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.Write($"Расстояние между точками A и B = {Math.Round(distance, 2, MidpointRounding.ToZero)}");