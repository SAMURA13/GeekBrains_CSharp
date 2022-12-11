// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

const int SIZE =6;
const int LEFTRANGE=100;
const int RIGTHRANGE=999;
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

int rez=0;
for (int i = 0; i < SIZE; i++)
{
    
    if (arr[i]%2==0)
    {
        rez=rez+1;
    }
    
}
Console.WriteLine(rez);