﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5  7   -2   -0,2
// 1   -3,3  8   -9,9
// 8   7,8  -7,1  9

int m = 3, n = 4;
double [,] array2d = new double[m, n];
for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        array2d[i,j] = new Random().NextDouble() * 20 - 10;
        array2d[i,j] = Math.Round(array2d[i,j], 1);
        Console.Write(array2d[i,j] + " ");  
    }
    Console.WriteLine();
}