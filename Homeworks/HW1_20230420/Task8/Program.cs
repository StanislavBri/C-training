// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 2)
{
    Console.Write("Четные числа от 1 до N: ");
    int i = 2;
    while (i <= N)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " " );
            i++;
        }
        else i++;
    }
}
else Console.WriteLine("нет четных чисел от 1 до N");