// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива ");
int len = Convert.ToInt32(Console.ReadLine());


int [] GetArray(int len)
{
    int [] array = new int [len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine(String.Join(",", array));
    return array;
}
int [] array = GetArray(len);

int CountChet(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    return count;
}
Console.WriteLine($"Количество положительных чисел = {CountChet(array)}");