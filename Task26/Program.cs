// Задача 26: 
// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Number(int number)
{
    int count = 0;
    int number1 = Math.Abs(number);
    while (number1>0)
    {
        number1 = number1/10;
        count++;
    }
    return count>0 ? count : 1;
}

Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = Number(num);
Console.WriteLine($"количество цифр в числе {num} = {num1}");


// // Задача 26: Напишите программу, которая принимает
// // на вход число и выдаёт количество цифр в числе.

// // 456 -> 3
// // 78 -> 2
// // 89126 -> 5

// int CountDigits(int num)
// {
//     int count=0;
//     while (num!=0)
//     {
//         count++; // count = count + 1
//         num/=10; // num = num / 10;
//     }
//     if (count==0) count = 1; 
//     return count;
// }


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int countDigits = CountDigits(number);
// Console.WriteLine($"В числе {number} - {countDigits} цифр(а).");


