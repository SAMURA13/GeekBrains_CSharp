// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

 Console.WriteLine("Введите число : ");
 int number = Convert.ToInt32(Console.ReadLine());
 
  Console.WriteLine("Введите число : ");
 int number2 = Convert.ToInt32(Console.ReadLine());
int mod = number%number2;
if (mod==0)
{
    Console.WriteLine("Kratno");
}else
{
    Console.WriteLine($"Ne kratno ostatoc {mod}");
}