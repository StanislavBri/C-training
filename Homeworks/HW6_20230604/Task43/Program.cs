// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// 1) Ввести коэффициенты для 2х прямых
// 2) написать функцию, вычисляющую общую точку
// 3) вывод

Console.WriteLine("Введите коэффициент k1 для первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1 для первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2 для второй прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2 для второй прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Уравнение первой прямой y = {k1}*x + {b1} ");
Console.WriteLine($"Уравнение второй прямой y = {k2}*x + {b2} ");
void ComPoint(double k1, double b1, double k2, double b2)
{
    double x = 0; // координата X общей точки
    double y = 0; // координата Y общей точки
    x = (b2-b1)/(k1-k2);
    y = k1 * x + b1; 
    if (k1 * x + b1 == k2 * x + b2 && k1 != k2)
    {
        Console.WriteLine($"Прямые пересекаются в точке ({x};{y})");
    }
    else  Console.WriteLine("Прямые не пересекаются");
}
ComPoint(k1, b1, k2, b2);
