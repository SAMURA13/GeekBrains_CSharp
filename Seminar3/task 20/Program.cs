// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите кординату х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату у: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату х: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату у: ");
int y1 = Convert.ToInt32(Console.ReadLine());

double ab = Math.Sqrt(Math.Pow(y-x, 2)+ Math.Pow(y1-x1, 2));
Console.WriteLine(ab);

