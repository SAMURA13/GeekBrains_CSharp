// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// ​
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<=0 || number>=8)
{
    Console.Write("Uncorrect number of week");
}
    else
{
    if (number >=1 && number<= 5)
{
    Console.Write("WorkDay");
}
    else
{
    Console.Write("Weekend!");
}
}
