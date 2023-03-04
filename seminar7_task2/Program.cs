// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

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

int ReadInt(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
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

void ElementValue(int[,] matrix, int m, int n, int s, int c)
{
            
  if(s < m && c < n)
  {
    Console.WriteLine($"Значение элемента на указ-й позиции: {matrix[s,c]}");
  }
  else
  {
    System.Console.WriteLine("Такого элемента нет");
  }
      
}

const int m = 4;
const int n = 4;
var matrix = GenerateMatrix(m, n);
PrintMatrix(matrix);
int s = ReadInt("Введите число s: ");
int c = ReadInt("Введите число c: ");
ElementValue(matrix, m, n, s, c);

