// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
while (a > 999 || a < -999)
{   
   a = a / 10;
}
if (a > 99)
{
    int result = a % 10;
    Console.WriteLine(result);
}
else if (a < -99)
{
    int result = a % 10 * -1;
    Console.WriteLine(result);
}
else Console.WriteLine("Третьей цифры нет");

// var number = 1234567;
// var digitArray = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();


// Console.WriteLine(digitArray[2]);