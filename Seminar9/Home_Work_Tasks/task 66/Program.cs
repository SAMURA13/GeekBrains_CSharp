﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

int sum=0;
void SumNumbers(int m, int n)
{
    
    sum += n;
    if (n <= m)
    {
    Console.Write($"Сумма = {sum}");
    return;
    } 
    SumNumbers(m, n - 1);
}

SumNumbers(m,n);
