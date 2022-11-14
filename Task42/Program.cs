// Задача 42:
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Решение через string

string ConvertDecToBinary(int dec)
{
    string binary = string.Empty;
    while (dec > 0)
    {
        binary = Convert.ToString(dec % 2) + binary;
        dec /= 2;
    }
    return binary;
}

Console.Write("Введите десятичное число: ");
int numberDec = Convert.ToInt32(Console.ReadLine());
string numberBinary = ConvertDecToBinary(numberDec);
Console.WriteLine($"Десятичное число {numberDec} в двоичном представлении будет выглядеть как: {numberBinary}.");


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int DecToBin(int number)
// {
//     int binNumber = 0;
//     int d10 = 1;
//     while (number > 0)
//     {
//         binNumber = binNumber + number % 2 * d10;
//         number /= 2;
//         d10 *= 10;
//     }
//     return binNumber;
// }

// int decToBin = DecToBin(num);

// Console.WriteLine($"Число {num} в двоичной системе = {decToBin}");
