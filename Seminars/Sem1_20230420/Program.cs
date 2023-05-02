// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// int a = Convert.ToInt32(Console.ReadLine());
// int result = a * a;
// Console.WriteLine(result);

// ----------------Task 1----------------------
// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.WriteLine("Введите число a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b");
// int b = Convert.ToInt32(Console.ReadLine());

// if (b*b == a)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }


// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// string a = Console.ReadLine();
// if (a=="1") Console.WriteLine("Понедельник")
// {
// else if (a=="2") Console.WriteLine("Вторник");
// else if (a=="3") Console.WriteLine("Среда");
// else if (a=="4") Console.WriteLine("Четверг");
// else if (a=="5") Console.WriteLine("Пятница");
// else if (a=="6") Console.WriteLine("Суббота");
// else if (a=="7") Console.WriteLine("Воскресенье");
// }
// else Console.WriteLine("Неверное значение");

// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// int negatN = N*(-1);

// while (negatN <= N)
// {
//     Console.Write(negatN);
//     Console.Write("");
//     negatN++;
// }





// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

// Console.Write("Введите трехзначное число ");
// int a=Convert.ToInt32(Console.ReadLine());
// if (a>99 & a<1000) 
// {
//     Console.WriteLine(a%10);    
// }
// else
//     Console.WriteLine("Вы ввели не трехзначное число");    

//=======================================================================================================
//=======================================================================================================
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3 

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Максимальное число " + a);    
}
else Console.WriteLine("Максимальное число " + b);
