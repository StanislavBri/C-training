// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива ");
int len = Convert.ToInt32(Console.ReadLine());


int [] GetArray(int len)
{
    int [] array = new int [len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    Console.WriteLine(String.Join(",", array));
    return array;
}
int [] array = GetArray(len);

int sum(int [] arr)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}
Console.WriteLine($"Сумма элементов,стоящих на нечетных позициях' = {sum(array)}");