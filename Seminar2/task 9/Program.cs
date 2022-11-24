// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 99);
int digit2 = number % 10;
int digit1 = number / 10;
if (digit2<digit1)
{
    Console.Write(digit1);
}
else
{
    Console.Write(digit2);
}
Console.Write($" {number} ");

