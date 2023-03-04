// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

double[,] GenerateMatrix(int m, int n, int leftRange, int rightRange)
{
  double[,] matrix = new double[m, n];
  Random rand = new Random();
  for(int i = 0; i < m; i = i + 1)
  {
    for(int j = 0; j < n; j = j + 1)
    {
      matrix[i,j] = rand.Next(leftRange, rightRange) + rand.NextDouble();
    }
  }
  return matrix;
}

void PrintMatrix(double[,] matr)
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

const int m = 4;
const int n = 4;
const int leftRange = -5;
const int rightRange = 5;
var matrix = GenerateMatrix(m, n, leftRange, rightRange);
PrintMatrix(matrix);
