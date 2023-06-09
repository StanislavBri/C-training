// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            array2d[i, j] = new Random().Next(-10, 11);
            Console.Write(array2d[i,j] + "  ");
        }
        Console.WriteLine();
    }
    return array2d;
}
int [,] array2d = Getarray2d(m,n);


void SrArif(int [,] array2d)
{
    //double SrArif = 0;
    double [] sum = new double[n];
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            sum[j] = 0;
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                // Console.WriteLine($" sum[k] = array2d[i,j] {sum[k]}");
                sum[j] = sum[j] + array2d[i,j];
            }
            sum[j] = sum[j] / 2;
        }    
    Console.Write("Среднее арифметические столбцов = ");
    Console.WriteLine(String.Join("; ", sum));
}
SrArif(array2d);