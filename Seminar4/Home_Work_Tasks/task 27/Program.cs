// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите a: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int Result(int tempN)
{
  int a = Convert.ToString(tempN).Length;
  int b = 0;
  int c = 0;
  for (int i = 0; i < a; i++)
  {
    b = tempN - tempN % 10;
    c = c + (tempN - b);
    tempN = tempN / 10;
  }
  return c;
}
int sum = Result(userNum);
Console.WriteLine(" --> " + sum);