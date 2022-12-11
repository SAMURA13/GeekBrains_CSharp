// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
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
int[] Zamena(int[] zamena)
{
    
    for (int i = 0; i < zamena.Length; i++)
    {
     zamena[i]=zamena[i] * -1;
    }
    return zamena;
}

int[] arr =GetRandomArray(SIZE,LEFTRANGE,RIGTHRANGE);
Console.WriteLine(string.Join(",", arr));
int[] b = Zamena(arr);
Console.WriteLine(string.Join(",", b));

// for (int i = 0; i < SIZE; i++)
//     {
//      arr[i]=arr[i] * -1;
//     }
// Console.WriteLine(string.Join(",", arr));

