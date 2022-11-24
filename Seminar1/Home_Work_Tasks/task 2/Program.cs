// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

 Console.WriteLine("Введите число 1 : ");
 int number = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Введите число 2 : ");
 int number2 = Convert.ToInt32(Console.ReadLine());
if (number == number2)
 {
    break;
    Console.WriteLine("Они равны");
 }
 if (number > number2)
 {
    Console.WriteLine("Первое число больше");
 }
 else
 {
    Console.WriteLine("Второе число больше");
 }