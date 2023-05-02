// 3.
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.WriteLine("Write first number");
// int.TryParse(Console.ReadLine(), out int first);

// Console.WriteLine("Write second number");
// int.TryParse(Console.ReadLine(), out int second);

// if (first == 0 || second == 0 )
//     {
//         Console.WriteLine("Делить на ноль нельзя");
//     }


// else if (first > second)
// {
//     int compare = first % second;
//     if (compare == 0) Console.WriteLine($"{first} кратно {second}");
//     else Console.WriteLine($"Остаток от деления {compare}");
// }
// else
// {
//     int compare = second % first;
//     if (compare == 0) Console.WriteLine($"{second} кратно {first}");
//     else Console.WriteLine($"Остаток от деления = {compare}");



// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// C    onsole.WriteLine("Напишите число");
// int a = int.Parse(Console.ReadLine());
// if ((a % 7 == 0) && (a % 23 == 0))
// {
//     Console.WriteLine("Число кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine("Число не кратно 7 и 23");



// 5. есть 2 числа: ДВА и ТРИ. Взять первые пять числел, которые кратны и 2,и 3 и получить сумму их.

// int count = 0;
// int sum = 0;
// int a = 1;

// while (count < 5)
// {
//     if ((a % 2 == 0) && (a % 3 == 0))
//     {
//         count++;
//         sum = sum + a;
//     }
//     a++;
// }
// Console.WriteLine(sum);



// 6. Есть два числа. Напишите программу, которая будет сравнивать является ли одно число квадратом другого.

// Console.WriteLine("Write first number");
// Console.WriteLine("Write second number");
// int first = 0;
// int second = 0;
// bool isnumber = int.TryParse(Console.ReadLine(), out first) && int.TryParse(Console.ReadLine(), out second);
// if (isnumber)
// {
    // 1й способ:

    // if (first > second)
    // {
    //     if (Math.Sqrt(first) == Math.Abs(second))
    //     {
    //         Console.WriteLine("одно число является квадратом другого");
    //     }
    //     else 
    //     {
    //         Console.WriteLine("не является");
    //     }
    // }
    // else
    // {
    //     if (Math.Sqrt(second) == Math.Abs(first))
    //     {
    //         Console.WriteLine("одно число является квадратом другого");
    //     }
    //     else 
    //     {
    //         Console.WriteLine("ложь");
    //     }
    // }

    // 2й способ:

//     if (Math.Abs(first) == Math.Sqrt(second) || Math.Abs(second) == Math.Sqrt(first))
//     {
//         Console.WriteLine("Yes");
//     }
//     else
//     {
//         Console.WriteLine("No");
//     }
// }
// else
// {
//     Console.WriteLine("Вы ввели не число");
// }





// 7. Вывести в консоль звездочками квадратик

// Console.WriteLine(@"* * * * *");
// Console.WriteLine(@"*       *");
// Console.WriteLine(@"*       *");
// Console.WriteLine(@"*       *");
// Console.WriteLine(@"* * * * *");
