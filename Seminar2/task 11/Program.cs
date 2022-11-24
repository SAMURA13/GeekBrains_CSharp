// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int digit2 = number % 10;
int digit1  = 10 * (number / 100);
int rez = digit1+digit2;

Console.WriteLine(number);
Console.WriteLine(digit1);
Console.WriteLine(digit2);
Console.WriteLine(rez);