// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число : ");
 int number = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число : ");
 int number2 = Convert.ToInt32(Console.ReadLine());

 if (number*number==number2 || number2*number2==number)
 {
    Console.Write("Da");
 }else
 {
    Console.Write("net");
 }