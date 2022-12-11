// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
const int SIZE =12;
const int LEFTRANGE=-9;
const int RIGTHRANGE=9;
int[] GetRandomArray(int size, int leftRange, int rigthRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i]= rand.Next(leftRange,rigthRange +1);
    }

    return array;
}
int[] arr =GetRandomArray(SIZE,LEFTRANGE,RIGTHRANGE);
Console.WriteLine(string.Join(",", arr));

Console.WriteLine("Введите : ");
int number = Convert.ToInt32(Console.ReadLine());

bool Result(int[] a)
{
    bool rez=false;
    for (int i = 0; i < a.Length; i++)
    {
        if (number==a[i])
        {
            rez=true;
            break;
        }
    }
    return rez;
}

bool result = Result(arr);
if (result==true)
{
    Console.WriteLine("da");
}
else
{
    Console.WriteLine("net");
}