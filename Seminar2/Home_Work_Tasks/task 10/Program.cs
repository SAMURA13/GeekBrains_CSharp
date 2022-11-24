// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// ​
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<100 || number>1000)
{
    Console.Write("Uncorrect number");
}
else
{
    int rez = (number / 10);
    rez= rez%10;
    Console.WriteLine($"Number in midle: {rez}");
    Console.WriteLine($"Your number: {number}");
}