// Задача 24: Напишите программу, 
// которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

bool Validate(int number)
{

    if (number>1)
    {
        return true;
    }
    else
    {
        return false;
    }

}

int Sum1ToA(int A)
{

    int sum=0;
    for (int i = 0; i <= A; i++)
    {
       
        sum += i;
    }
    return sum;

}

int GetNumber(string mesage)
{

Console.WriteLine("Введите : ");
return Convert.ToInt32(Console.ReadLine());

}

int number = GetNumber("enter a number: ");
bool isCorrect =Validate(number);
if (isCorrect == true)
{

    int sum =Sum1ToA(number);
    Console.WriteLine($"Sum of number from 1 to A{number} = {sum}");

}
else
{

    Console.WriteLine($"Imposible to get sum from A{number}");

}
