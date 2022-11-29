// Задача №17 Напишите программу которая примимает на вход кординаты (Х и У) причем Х не равен 0 и у не равен 0. 
// В какой четверти плоскости находится данная точка
Console.WriteLine("Введите кординату х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату у: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
{
    Console.WriteLine("1");
}
else if (x<0 && y>0)
{
    Console.WriteLine("2");
}
else if (x<0 && y<0)
{
    Console.WriteLine("3");
}
else if (x>0 && y<0)
{
    Console.WriteLine("4");
}