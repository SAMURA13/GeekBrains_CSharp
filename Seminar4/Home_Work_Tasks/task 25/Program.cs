// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());



int rez = a;
for (int i = 1; i < b; i++)
{
   
    if (i<b)
    {
        rez=a*rez;

      Console.WriteLine(rez);
    }
    
}