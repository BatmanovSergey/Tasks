// Задача 42:
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите десятичное число: ");
int numberDec = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// Решение 1: через string с конвертацией внутри метода

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

string convertDecToBinary = ConvertDecToBinary(numberDec);
Console.WriteLine($"Решение 1: через string с конвертацией внутри метода");
Console.WriteLine($"Десятичное число {numberDec} в двоичном "
                + $"представлении будет выглядеть как {convertDecToBinary}");
Console.WriteLine();

// Решение 2: через int с разворотом числа

int DecToBin(int number)
{
    int binNumber = 0;
    int d10 = 1;
    while (number > 0)
    {
        binNumber = binNumber + number % 2 * d10;
        number /= 2;
        d10 *= 10;
    }
    return binNumber;
}

int decToBin = DecToBin(numberDec);
Console.WriteLine($"Решение 2: через int с разворотом числа");
Console.WriteLine($"Число {numberDec} в двоичной системе = {decToBin}");
Console.WriteLine();

// Решение 3: через string простое, без конвертации

string СonverterDigit(int num)
{
    string res = "";
    while (num > 0)
    {
        res = $"{(num % 2)}{res}";
        num /= 2;
    }
    return res;
}
string converterDigit = СonverterDigit(numberDec);
Console.WriteLine("Решение 3: через string простое, без конвертации"); 
Console.WriteLine($"Число {numberDec} в двоичном виде = {converterDigit}");
Console.WriteLine();

// Решение 4: через рекурсию

int ConvertDecToBinaryRecurtion(int dec)
 {     
    if (dec == 0) return 0;    
    if (dec == 1) return 1;     
    return ConvertDecToBinaryRecurtion(dec/2) * 10 + dec % 2; 
} 

int convertDecToBinaryRecurtion = ConvertDecToBinaryRecurtion(numberDec); 
Console.WriteLine("Решение 4: через рекурсию"); 
Console.WriteLine($"Десятичное число {numberDec} в двоичном "
                + $"представлении будет выглядеть как {convertDecToBinaryRecurtion}");
Console.WriteLine();