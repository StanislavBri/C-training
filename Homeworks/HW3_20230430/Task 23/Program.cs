// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());


void main(int N)
{   
    int i = 1;
    while (i < N)
    {
        int result = i * i * i;
        Console.Write($"{result}, ");
        i = i + 1;
    }
    if (i == N)
    {
        Console.Write(i * i * i);
    }
}
if (N > 0)
{
    main(N);
}
else Console.WriteLine($"{N} некорректное число");
