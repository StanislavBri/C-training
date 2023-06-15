// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
// В итоге получается вот такой массив:
//  7 4 2 1
//  9 5 3 2
//  8 4 4 2

Console.WriteLine("Введите количество строк двумерного массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] Getarray2d(int m, int n)
{
    int [,] array2d = new int[m,n];
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = new Random().Next(1, 11);
            Console.Write(array2d[i,j] + "  ");
        }
        Console.WriteLine();
    }
    return array2d;
}
int [,] array2d = Getarray2d(m,n);
Console.WriteLine();

void uporyadArray(int [,] array2d)
{
    int [] temp = new int[array2d.GetLength(1)];
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            temp[j] = array2d[i,j];
        }
        Array.Sort(temp);
        Array.Reverse(temp);
        Console.Write(string.Join(", ", temp));
        
        
        Console.WriteLine();
    }
}
uporyadArray(array2d);