// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день 
// недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1) { Console.WriteLine($"{1} - Понедельник, день тяжелый");}
else if (a == 2) { Console.WriteLine($"{2} - Вторник, настроение еще норм");}
else if (a == 3) { Console.WriteLine($"{3} - Настал средец - неделе звездец");}
else if (a == 4) { Console.WriteLine($"{4} - Четверг, уже считай конец недели");}
else if (a == 5) { Console.WriteLine($"{5} - Пятница - все мысли о приятном вечере");}
else if (a == 6) { Console.WriteLine($"{6} - Суббота - УРА ВЫХОДНОЙ!");}
else if (a == 7) { Console.WriteLine($"{7} - Воскресенье - Ура, отсыпной");}

else Console.WriteLine($"Число {a} не соответствует дню недели");