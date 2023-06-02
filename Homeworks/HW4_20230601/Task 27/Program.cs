// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Vvedite chislo");
int number = Convert.ToInt32(Console.ReadLine());

int digit (int number)
{
    int sum = 0;
    int result = 0;
    while (number > 0) 
    {
        result = number % 10;
        sum = sum + result;
        number = number / 10;
    }
    return sum;
}
Console.WriteLine($"summa chisel {number} = {digit(number)}");