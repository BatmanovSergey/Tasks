// Задача 18 
// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
// Решение через оператор выбора - Switch

string Range(int quarter) 
{     switch (quarter)    
 {      
        case 1:  
         return "x > 0 и y > 0"; 
        case 2:            
         return "x < 0 и y > 0";         
        case 3:             
         return "x < 0 и y < 0";         
        case 4:             
         return "x > 0 и y < 0";         
        default:            
         return "Некорректные данные";    
 } 
} 

Console.Write("Введите номер четверт: "); 
int num = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine(Range(num));