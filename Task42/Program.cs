// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


System.Console.WriteLine("Введите значение b1:");
double b1 = Convert.ToUInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение k1:");
double k1 = Convert.ToUInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение b2:");
double b2 = Convert.ToUInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение k2:");
double k2 = Convert.ToUInt32(Console.ReadLine());


if (k1 == k2 && b1 == b2) System.Console.WriteLine($"\nПрямые совпадают");

else if (k1 == k2 && b1 != b2) System.Console.WriteLine($"\nПрямые паралельны");

else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = x * k1 + b1;
    System.Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} → ({x}; {y})");
}





