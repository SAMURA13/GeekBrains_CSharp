// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите кординату хa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату уb: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату za: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату zb: ");
int zb = Convert.ToInt32(Console.ReadLine());


double ab = Math.Sqrt(Math.Pow(xb-xa, 2)+ Math.Pow(yb-ya, 2)+ Math.Pow(zb-za, 2));
Console.WriteLine(ab);

// d = √(xb - xa)2 + (yb - ya)2 + (zb - za)2 =