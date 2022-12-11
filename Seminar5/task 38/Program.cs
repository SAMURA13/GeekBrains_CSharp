// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

const int SIZE =6;
const int LEFTRANGE=-10;
const int RIGTHRANGE=100;
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
int max=arr[0];
int min=arr[0];
for (int i = 0; i < SIZE; i++)
{
    if (arr[i]>max)
    {
        max=arr[i];
    }
}
for (int i = 0; i < SIZE; i++)
{
    if (arr[i]<min)
    {
        min=arr[i];
    }
}

Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(max-min);


