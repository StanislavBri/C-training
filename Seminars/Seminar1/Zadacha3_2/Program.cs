string[]days = new String[]{"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
Console.Write ("номер дня недели ");
int day = int.Parse(Console.ReadLine());
Console.WriteLine(days[day-1]);