// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 1000 & a > 99)
{
    int result = a % 100 / 10;
    Console.WriteLine("Вторая цифра " + result);
}
else if (a > -1000 & a < -99)
{
    int result = a % 100 / -10;
    Console.WriteLine("Вторая цифра " + result);
}
else Console.WriteLine("Некорректное число");

