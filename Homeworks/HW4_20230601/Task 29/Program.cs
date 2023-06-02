// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите длину массива");
int Lenght = Convert.ToInt32(Console.ReadLine());

int [] generateArr(int L) // генерируем массив 
{
    int [] array = new int[Lenght];
    for (int i = 0; i < Lenght; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void printArr(int [] array) // печатаем массив
{
    Console.Write("[ ");
    for (int i = 0; i < Lenght-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]} ]");
}
int [] array = generateArr(Lenght);
printArr(array);