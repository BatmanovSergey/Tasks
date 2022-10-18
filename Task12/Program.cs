// задача 12.
// Напишите программу, которая будет принимать на вход два числа и
// выводить, является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления
// пример:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// решение 1 простое
Console.Write("Введите целое число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0) Console.WriteLine("Решение-1: Кратно");
else Console.WriteLine($"Решение-1: Не кратно, остаток {num1 % num2}");

// решение 2 через метод, в котором используется булевый оператор (выдаёт "да" или "нет")

bool Multiple(int number1, int number2) // создаем метод
{
    return number1 % number2 == 0;
}

bool multiple = Multiple(num1,num2);

Console.WriteLine(multiple? "Решение-2: Кратно" : $"Решение-2: не кратно, остаток {num1 % num2}");

// решение 3 через метод, в котором используем оператор, который возвращает целые числа int
// и в rest сохраняем остаток от деления

int Multiplicity(int number1, int number2) // создаем метод
{
    return number1 % number2;
}

int rest = Multiplicity(num1,num2);
Console.WriteLine(rest == 0? "Решение-3: Кратно" : $"Решение-3: не кратно, остаток {rest}");
