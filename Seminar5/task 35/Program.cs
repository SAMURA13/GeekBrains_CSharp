// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
const int SIZE =12;
const int LEFTRANGE=0;
const int RIGTHRANGE=150;
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

// int[] FindOtr(int[] a,int rez=0)
// {
    
//     for (int i = 0; i < a.Length; i++)
// {
    
//     if (a[i]>=10 && a[i]<=99)
//     {
//         rez=rez+1;
//     }
    
// }
//     return rez;
// }

// int[] a2= FindOtr(arr);
// Console.WriteLine(string.Join(",", a2));

int rez=0;
for (int i = 0; i < SIZE; i++)
{
    
    if (arr[i]>=10 && arr[i]<=99)
    {
        rez=rez+1;
    }
    
}
Console.WriteLine(rez);