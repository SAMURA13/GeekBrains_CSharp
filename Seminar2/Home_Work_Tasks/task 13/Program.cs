
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// ​
// 645 -> 5
// ​
// 78 -> третьей цифры нет
// ​
// 32679 -> 6

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int rez= 0;
 if (number<=99)
 {
    Console.WriteLine("No third digit");
 }
 if (number>99 && number<1000)
 {
   rez=number%10;
 }
 if (number>999)
{
  while (number>999)
    {
        number=number/10;
    }
    rez=number%10;
}
Console.WriteLine(rez);

 