// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array=new int[8];

void FillArray(int[] test)
{
    int length = test.Length;
    int index = 0;

    while (index<length)
    {
        test[index] = new Random().Next(1,10);
    }
}

void PrintArray(int[] col)
{

    int count = col.Length;
    int pos = 0;

    while (pos<count)
    {
        Console.WriteLine(col[pos]);
        pos++;
    }
}

FillArray(array);
PrintArray(array);