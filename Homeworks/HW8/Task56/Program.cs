// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void naimSum(int [,] array2d)
{
    
    int count = 0;
    int [] temp = new int[array2d.GetLength(0)];
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        int sum = array2d[i,0];
        for (int j = 0; j < array2d.GetLength(1) - 1; j++)
        {
            sum = sum + array2d[i, j+1];
            temp[i] = sum;
        }
        Console.Write($"Сумма чисел в {i+1}-й строке = {sum}");
        Console.WriteLine();
    }
    Console.Write("Массив из сумм чисел по строкам: ");
    Console.Write(string.Join(", ", temp));
    Console.WriteLine();
    int s = temp[0];
    
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        if (temp[i] < s) 
        {
            s = temp[i];
        }
    }
    Console.WriteLine($"Наименьшая сумма чисел равна {s}");   
    
    for (int i = 0; i < array2d.GetLength(0); i++)
        {
            if (temp[i] == s)
            {
            //    count++;
                Console.WriteLine($"В строке {i+1}"); 
            }
        }
}
naimSum(array2d);