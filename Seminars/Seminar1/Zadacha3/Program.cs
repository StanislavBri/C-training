﻿Console.WriteLine("Введите число от 1 до 7");
if (int.TryParse(Console.ReadLine(), out int i)) 
{
    if (i == 1) Console.WriteLine("Понедельник");
    else if (i == 2) Console.WriteLine("Вторник");
    else if (i == 3) Console.WriteLine("Среда");
    else if (i == 4) Console.WriteLine("Четверг");
    else if (i == 5) Console.WriteLine("Пятница");
    else if (i == 6) Console.WriteLine("Суббота");
    else if (i == 7) Console.WriteLine("Воскресенье");
}
else Console.WriteLine("Вы ввели неверное число");
    

