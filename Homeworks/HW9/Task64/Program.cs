// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int NaturNumbers(int N)
{
    if (N == 0) 
    {
        return N; 
    }
    else if (N == 1)
    {
        Console.Write($"{N.ToString()} ");
        return NaturNumbers(N-1);
    }
    else 
    {
        Console.Write($"{N.ToString()}, ");
        return NaturNumbers(N-1);
    }
}
NaturNumbers(N);