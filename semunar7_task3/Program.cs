// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

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

void ColumnAverage(int[,] matr, int m, int n)
{
  
  for(int j = 0; j < n; j = j + 1)
  {
    double sum = 0;
    for(int i = 0; i < m; i = i + 1)
    {
      sum = sum + matr[i, j];
          
    }
    double average = (sum / m);
    System.Console.WriteLine(average);
    
  }
    
}

const int m = 4;
const int n = 4;
var matrix = GenerateMatrix(m, n);
PrintMatrix(matrix);
//System.Console.WriteLine(ColumnAverage(matrix));
ColumnAverage(matrix, m, n);
