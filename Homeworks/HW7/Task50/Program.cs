// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк двумерного массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк двумерного массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] Getarray2d(int m, int n)
{
    int [,] array2d = new int[m,n];
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = new Random().Next(-10, 11);
            Console.Write(array2d[i,j] + "  ");
        }
        Console.WriteLine();
    }
    return array2d;
}
int [,] array2d = Getarray2d(m,n);

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void FindNumber(int [,] array2d, int N)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (N == array2d[i,j])
            Console.WriteLine($"Число находится на позиции {i},{j}");
        }
    }
}
FindNumber(array2d, N);