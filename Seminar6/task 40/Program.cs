// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


Console.WriteLine("Введите A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите C: ");
int C = Convert.ToInt32(Console.ReadLine());

if (A<B+C && B<A+C && C<B+A)
{
    Console.WriteLine("Mozet");
}
else
{
    Console.WriteLine("Ne mozet");
}