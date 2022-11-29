// Задача 18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите четверть: ");
int diap = Convert.ToInt32(Console.ReadLine());

if (diap==1)
{
    Console.WriteLine("Первая четверть x>0 и y>0");
}
else if (diap==2)
{
    Console.WriteLine("Вторая четверть x<0 и y>0");
}
else if (diap==3)
{
    Console.WriteLine("Третья четверть x<0 и y<0");
}
else if (diap==4)
{
    Console.WriteLine("Четвертая четверть x>0 и y<0");
}
else if (diap<=0 || diap >=5)
{
    Console.WriteLine("Hевозможно найти четверть");
}
