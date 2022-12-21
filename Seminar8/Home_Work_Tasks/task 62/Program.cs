// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}  

void PrintMatrix (int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if (matr[i,j] / 10 <= 0)
      Console.Write($" {matr[i,j]} ");

      else Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
  }
}

void Spiral(int[,] sqareMatrix){

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
}


int razmer = GetNumber("Введите размер спиральной матрицы(количество строк и стобцов): ");
Console.WriteLine();
int[,] sqareMatrix = new int[razmer,razmer];
Spiral(sqareMatrix);
PrintMatrix(sqareMatrix);

