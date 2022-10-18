// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// ввод данных

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

// решение-1

bool Multipul(int number)
{
    return number % 7 ==0 && number % 23 == 0; // если число кратно делится на 7 и 23, 
                                               //то функция возвращает True, иначе возвращает False
}

bool multipul = Multipul(num);
Console.Write("Решение 1: ");
Console.WriteLine(multipul?"Кратно":"Не кратно");

// решение-2

bool Multipul1(int first, int second)
{
    return first % second ==0;

}
Console.Write("Решение 2: ");
Console.WriteLine(Multipul1 (num, 7) && Multipul1 (num, 23)?"Кратно":"Не кратно");
