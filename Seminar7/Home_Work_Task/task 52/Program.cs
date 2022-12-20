// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] a = new double[m, n];
Random rnd = new Random();

void PrintArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}

void FillArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = Convert.ToDouble(rnd.Next(1, 10));}}}
FillArray(a);
Console.WriteLine();
PrintArray(a);
Console.WriteLine();

double[] b=new double[5];

for (int i=0,k=0;i<n;i++) 
{
    double summa=0;
    for (int j=0;j<n;j++) 
        {
            summa+=a[j,i];
        }
    b[k]=summa/n;
    Console.WriteLine("Среднее арифметическое столбца "+(i+1)+" равно: "+b[k]);
    k++;
}          


