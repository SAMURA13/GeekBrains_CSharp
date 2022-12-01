// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int sum=0;
int GetNumber(string mesage)
{

Console.WriteLine("Введите : ");
return Convert.ToInt32(Console.ReadLine());

}

int Rez(int number)
{

    while (number>0)
    {
        number= number /10;
        sum++;
    }
    return sum;

}

int vvod= GetNumber("enter number");
int rez=Rez(vvod);
Console.WriteLine(rez);