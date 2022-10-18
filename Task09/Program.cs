// задача 09. 
// 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// 2. и показывает наибольшую цифру числа.
// пример:
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100); // выдаёт случайные числа в диапазаоне 10-99 (100 не берётся)
Console.WriteLine($"Случайное число из диапазаона 10-99 -> {num}");

int firstDigit = num / 10; //78 / 10 = 7
int secondDigit = num % 10; //78 % 10 = 8

//Простое решение-1:

if (firstDigit > secondDigit) Console.WriteLine($"Решение-1: наибольшая цифра числа {num} = {firstDigit}");
else Console.WriteLine($"Решение-1: наибольшая цифра числа {num} = {secondDigit}");

// Решение-2 через встроенный метод определения максимального значения в C#, не проверяет на равенство чисел

int max = Math.Max(firstDigit, secondDigit);
Console.WriteLine($"Решение-2: наибольшая цифра числа {num} = {max}");

// Решение-3 с использованием тернарного оператора:
// если firstDigit больше secondDigit,(?) означает "тогда" в переменную result запишем firstDigit,
// (:) означает "иначе" в переменную result запишем secondDigit

int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Решение-3: Наибольшая цифра числа {num} = {result}");

// Решение-4: распишем работу тернарного оператора
int res = default; // default - показывает, что у нас будет какое-то значение, которое мы ещё не определили
                   // также можно использовать int res = 0
if (firstDigit > secondDigit) res = firstDigit;
else res = secondDigit;
Console.WriteLine($"Решение-4: Наибольшая цифра числа {num} = {res}");

// Решение-5 оптимизируем решение-4:
int res1 = firstDigit;
if (secondDigit > firstDigit) res1 = secondDigit;
Console.WriteLine($"Решение-5: Наибольшая цифра числа {num} = {res1}");

// Решение-6 с использованием тернарного оператора, но без добавления новой переменной:
Console.Write($"Решение-6: Наибольшая цифра числа {num} = ");
Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

// Решение-7 через создание функции

int MaxDigit(int number) // наш метод возвращает целое число int и называется MaxDigit
                         // в метод мы отправляем также целое число (int number)
{
    int firstDigit = number / 10; // 78 / 10 = 7
    int secondDigit = number % 10; // 78 % 10 = 8
    //используем здесь тернарный опреатор сразу в return
    return firstDigit > secondDigit ? firstDigit : secondDigit; // return возвращает значение
}

// вызов метода
int maxDigit = MaxDigit(num); 
                              
Console.WriteLine($"Решение-7: Наибольшая цифра числа {num} = {maxDigit}");
