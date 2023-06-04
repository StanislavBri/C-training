// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Диапазон [-10, 10]. Обратите внимание на вещественных чисел
// Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива ");
int len = Convert.ToInt32(Console.ReadLine());

double [] GetArray(int len)
{
    double [] array = new double [len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().NextDouble() * 20 - 10;
        array[i] = Math.Round(array[i], 2);
    }
    Console.WriteLine(String.Join("  ", array));
    return array;
}
double [] array = GetArray(len);

double difference(double [] arr)
{
    double dif = 0;
    double max = array[1];
    double min = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    dif = max - min;
    return Math.Round(dif, 2);
}
Console.WriteLine($"Разница макс. и мин. элементов массива = {difference(array)}");