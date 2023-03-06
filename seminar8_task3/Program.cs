// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.

int[,] GenerateMatrix1(int m1, int n1)
{
  int[,] matrix1 = new int[m1, n1];
  Random rand = new Random();
  for (int i = 0; i < m1; i = i + 1)
  {
    for (int j = 0; j < n1; j = j + 1)
    {
      matrix1[i, j] = rand.Next(0, 10);
    }
  }
  return matrix1;
}

void PrintMatrix1(int[,] matr1)
{
  for (int i = 0; i < matr1.GetLength(0); i = i + 1)
  {
    for (int j = 0; j < matr1.GetLength(1); j = j + 1)
    {
      System.Console.Write(matr1[i, j] + " ");
    }
    System.Console.WriteLine();
  }
}

int[,] GenerateMatrix2(int m2, int n2)
{
  int[,] matrix2 = new int[m2, n2];
  Random rand = new Random();
  for (int i = 0; i < m2; i = i + 1)
  {
    for (int j = 0; j < n2; j = j + 1)
    {
      matrix2[i, j] = rand.Next(0, 10);
    }
  }
  return matrix2;
}

void PrintMatrix2(int[,] matr2)
{
  for (int i = 0; i < matr2.GetLength(0); i = i + 1)
  {
    for (int j = 0; j < matr2.GetLength(1); j = j + 1)
    {
      System.Console.Write(matr2[i, j] + " ");
    }
    System.Console.WriteLine();
  }
}

int[,] MultiplicationResult(int[,] matr1, int[,] matr2)
{
  int[,] matrix3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
  for (int i = 0; i < matr1.GetLength(0); i = i + 1)
  {
    for (int j = 0; j < matr2.GetLength(1); j = j + 1)
    {
      int sum = 0;
      for (int k = 0; k < matr1.GetLength(1); k = k + 1)
      {
        sum = (sum + (matr1[i, k] * matr2[k, j]));
      }
      matrix3[i, j] = sum;
       
    }
  }
  return matrix3;
      
}

void PrintMatrix3(int[,] matr3, int[,] matr1, int[,] matr2)
{
  for (int i = 0; i < matr1.GetLength(0); i = i + 1)
  {
    for (int j = 0; j < matr2.GetLength(1); j = j + 1)
    {
      System.Console.Write(matr3[i, j] + " ");
    }
    System.Console.WriteLine();
  }

}


const int m1 = 2;
const int n1 = 3;
var matrix1 = GenerateMatrix1(m1, n1);
PrintMatrix1(matrix1);
System.Console.WriteLine();
const int m2 = 3;
const int n2 = 2;
var matrix2 = GenerateMatrix2(m2, n2);
PrintMatrix2(matrix2);
System.Console.WriteLine();
var matrix3 = MultiplicationResult(matrix1, matrix2);
PrintMatrix3(matrix3, matrix1, matrix2);


