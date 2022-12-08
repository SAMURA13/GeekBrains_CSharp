// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите : ");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;

int number1=number; // запоминает число, иначе цикл его затирает

while (number > 0) 
{
    result *= 10;
    result += number % 10;
    number /= 10;
}
if (number1==result)
{
    Console.WriteLine("Да, число является палиндромом");
}
else
{
    Console.WriteLine("Нет, это число не палиндром!");
}

// Вариант к которму я пришел первый раз

// if (number/10000 == number%10 && (number/1000)%10 == (number%100)/10)
// {
//     Console.WriteLine("Да, число является палиндромом");
// }
// else if (number/1000 == number%10 && (number/100)%10 == (number%100)/10)
// {
//     Console.WriteLine("Да, число является палиндромом");
// }
// else if (number/100 == number%10)
// {
//     Console.WriteLine("Да, число является палиндромом");
// }
// else if (number/10 == number%10)
// {
//     Console.WriteLine("Да, число является палиндромом");
// }
// else
// {
//     Console.WriteLine("Нет, это число не палиндром!");
// }

