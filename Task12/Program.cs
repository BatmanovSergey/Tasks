//12.

Console.Write("Введите целое число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, остаток {num1 % num2}");

//решение 2 через метод

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// bool Multiple(int number1, int number2)
// {
//     return number1 % number2 == 0;
// }

// bool multiple = Multiple(num1,num2);
// Console.WriteLine(multiple? "Кратно" : $"не кратно, остаток {num1 % num2}");

//решение 3 через метод

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int Multiple(int number1, int number2)
// {
//     return number1 % number2;
// }

// int rest = Multiple(num1,num2);
// Console.WriteLine(rest == 0? "Кратно" : $"не кратно, остаток {rest}");
