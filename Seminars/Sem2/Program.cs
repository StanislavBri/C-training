// Напишите программу, которая выводит случайное число из отрезка 10-99 и показывает
// наибольшую цифру числа.


// Random rand = new Random();
// int number = rand.Next(10, 100);
// int a = number / 10;
// int b = number % 10;
// if (a > b)
// {
//     Console.WriteLine($"Our number is {number}. First digit > Second digit, result {a}");
// }
// else if (a < b)
// {
//     Console.WriteLine($"Our number is {number}. Second digit > First digit, result {b}");
// }
// else {
//     Console.WriteLine($"Our number is {number}. First digit = Second digit");
// }



// // Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// Random rand = new Random();
// int number = rand.Next(100, 1000);
// int a = number / 100;
// int b = number % 10;

// Console.WriteLine($"Our number is {number}. Result is {a}{b}");



// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// Console.WriteLine("Vvedite pervoe chislo");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Vvedite vtoroe chislo");
// int b = Convert.ToInt32(Console.ReadLine());

// if (b == a*a || a == b*b)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }



// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Random rand = new Random();
// int a = rand.Next(10, 100);
// int b = rand.Next(10, 100);

// if (a % b == 0 || b % a ==0)
// {
//     Console.WriteLine($"Число {a} и {b} кратны");
// }
// else if (a > b)
// {
//     Console.WriteLine($"Числа {a} и {b}. остаток {a % b}");        
// } 
// else if (a < b)
// {
//     Console.WriteLine($"Числа {a} и {b}. Остаток {b % a}");  
// }
// else 
// {
//     Console.WriteLine("Числа {a} и {b}. Числа равны");      
// }




// Задача №14.
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.WriteLine("Vvedite chislo");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a % 7 == 0 & a % 23 == 0)
// {
//     Console.WriteLine("Число кратно и 7 и 23");
// }
// else
// {
//     Console.WriteLine("число НЕ кратно и 7 и 23");
// }