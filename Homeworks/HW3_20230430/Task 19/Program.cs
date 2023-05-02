// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int a = 0, b = 0, c = 0, d = 0;
if (number > 9999 && number < 100000)
{

    a = number / 10000;
    b = number / 1000 % 10;
    c = number % 100 / 10;
    d = number % 10;
}  
else Console.WriteLine("некорректное число");
if (a == d && b == c)
   Console.WriteLine($"{number} - число палиндром");
else Console.WriteLine($"{number} - не палиндром");