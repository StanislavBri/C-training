// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел хотите ввести?");
int count = Convert.ToInt32(Console.ReadLine());

int [] inputArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Введите {i+1}-е число ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int [] array = inputArray(count);
Console.WriteLine($"Ваш массив ");
Console.Write(String.Join(",", array));
Console.WriteLine($" ");

int schet = 0;
for (int i = 0; i < count; i++)
{
    if (array[i] > 0)
    schet++;
}
Console.WriteLine($"Чисел больше 0 = {schet} ");