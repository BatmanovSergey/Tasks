// задача17. 
// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта точка.


Console.WriteLine("Введите координаты точки: ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("X: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quater(int xc, int yc)

{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

int quater = Quater(x, y);
string result = quater > 0
                      ? $"Указанные координаты соответсвуют четверти -> {quater}"
                      : "Введенынекорректные координты";

Console.Write(result);
