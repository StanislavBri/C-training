// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк первой матрицы m1: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы n1: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк второй матрицы матрицы m2: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы n2: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 == m2)
{
    int [,] matrix1 = Get1Matrix(m1,n1);
    int [,] Get1Matrix(int m1, int n1)
    {
        int [,] matrix1 = new int[m1,n1];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrix1[i, j] = new Random().Next(1, 6);
                Console.Write(matrix1[i,j] + "  ");
            }
            Console.WriteLine();
        }
    return matrix1;
    }
    Console.WriteLine();

    int [,] matrix2 = Get2Matrix(m2,n2);
    int [,] Get2Matrix(int m2, int n2)
    {
        int [,] matrix2 = new int[m2,n2];
        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                matrix2[i, j] = new Random().Next(1, 6);
                Console.Write(matrix2[i,j] + "  ");
            }
            Console.WriteLine();
    }
    return matrix2;
    }

    
    int [,] multipMatrix = GetMultipMatrix(matrix1, matrix2);
    int [,] GetMultipMatrix(int [,] matrix1, int [,] matrix2)
    {
        int[,] multipMatrix = new int[m1,n2];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    //multipMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
                    multipMatrix[i,j] = multipMatrix[i,j] + (matrix1[i,k] * matrix2[k,j]);
                }
            }
        }
        return multipMatrix;
    }
    void PrintArray2d(int [,] array2d)
    {
        for (int i = 0; i < array2d.GetLength(0); i++)
        {
            for (int j = 0; j < array2d.GetLength(1); j++)
            {
                Console.Write(array2d[i,j] + "  ");
            }
            Console.WriteLine();
        }
}
    PrintArray2d(multipMatrix);
}
else Console.WriteLine(" Произведение матриц невозможно тк число столбцов"
+ " первой матрицы не соответствует числу строк второй ");

