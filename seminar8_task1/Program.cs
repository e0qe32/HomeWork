// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GenerateMatrix(int m, int n)
{
  int[,] matrix = new int [m, n];
  Random rand = new Random();
  for(int i = 0; i < m; i = i + 1)
  {
    for(int j = 0; j < n; j = j + 1)
    {
      matrix[i,j] = rand.Next(0, 10);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matr)
{
  for(int i = 0; i < matr.GetLength(0); i = i + 1)
  {
    for(int j = 0; j < matr.GetLength(1); j = j + 1)
    {
      System.Console.Write(matr[i,j] + " ");
    }
    System.Console.WriteLine();
  }
}

void StreamlineArray(int[,] matr)
{
  for(int i = 0; i < matr.GetLength(0); i = i + 1)
  {
    for(int j = 0; j < matr.GetLength(1); j = j + 1)
    {
      for (int k = 0; k < matr.GetLength(1) - 1; k = k + 1)
      {
        if (matr[i, k] < matr[i, k + 1])
        {
          int temp = matr[i, k];
          matr[i, k] = matr[i, k + 1];
          matr[i, k + 1] = temp;
        }
      }
    
    }
  }

}




const int m = 4;
const int n = 4;
var matrix = GenerateMatrix(m, n);
PrintMatrix(matrix);
System.Console.WriteLine();
StreamlineArray(matrix);
PrintMatrix(matrix);



