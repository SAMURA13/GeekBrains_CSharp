// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

const int SIZE =5;
const int LEFTRANGE=1;
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
Console.WriteLine();

void Revers(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp =array[i];
        array[i]=array[array.Length-i-1];
        array[array.Length-i-1]=temp;
    }

}

Revers(arr);
Console.WriteLine(string.Join(",", arr));
Console.WriteLine();

