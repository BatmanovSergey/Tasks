// Задача 18 
// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

string Quater(int number)
{
    if (number == 1) return "x > 0 и y > 0";
    if (number == 2) return "x < 0 и y > 0";
    if (number == 3) return "x < 0 и y < 0";
    if (number == 4) return "x > 0 и y < 0";
    return null;
}

string quater = Quater(num);

Console.WriteLine(quater == null
? "Некорректный номер четверти"
: $"Диапазон возможных координат точек в этой четверти: {quater}");
