// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        int result = n + 1;
        return result;
    }

    else if (m > 0 && n == 0)
    { 
        Console.WriteLine("выполнилось среднее условие");
        return Akkerman(m-1, 1);
        
    }

    else if (m > 0 && n > 0)
    {
        Console.WriteLine("выполнилось нижнее условие");
        return Akkerman(m-1, Akkerman(m,n-1));
    }
    else 
    {
        Console.WriteLine("вы ввели некорректные числа");
        return 0;
}
}
Console.WriteLine($"Функция Аккермана возвращает значение {Akkerman(m, n)}");
