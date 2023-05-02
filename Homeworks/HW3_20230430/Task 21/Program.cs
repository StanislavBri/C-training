// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A в 3D пространстве:");
Console.WriteLine("Координата x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата z1:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Координаты точки A: ({x1},{y1},{z1})");

Console.WriteLine("Введите координаты точки B в 3D пространстве:");
Console.WriteLine("Координата x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата z3:");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Координаты точки B: ({x2},{y2},{z2})");

int Kvadrat1(int x1, int x2)
{
    int arg1 = (x2-x1) * (x2-x1);
    return arg1;
}
int arg1 = Kvadrat1(x1, x2);
// Console.WriteLine($"arg1 = {arg1}");

int Kvadrat2(int y1, int y2)
{   
    int arg2 = (y2-y1) * (y2-y1);
    return arg2;
}
int arg2 = Kvadrat2(y1, y2);
// Console.WriteLine($"arg2 = {arg2}");

int Kvadrat3(int z1, int z2)
{
    int arg3 = (z2-z1) * (z2-z1);
    return arg3;
}
int arg3 = Kvadrat3(z1, z2);
// Console.WriteLine($"arg3 = {arg3}");

double Vector(int arg1, int arg2, int arg3)
{
    double result = Math.Sqrt(arg1 + arg2 + arg3);
    return result;
}

double result = Vector(arg1, arg2, arg3);
Console.WriteLine($"Результат = {Math.Round(result, 2)}");

