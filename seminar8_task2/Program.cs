// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

int[,] GenerateMatrix(int m, int n)
{
  int[,] matrix = new int[m, n];
  Random rand = new Random();
  for (int i = 0; i < m; i = i + 1)
  {
    for (int j = 0; j < n; j = j + 1)
    {
      matrix[i, j] = rand.Next(0, 10);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i = i + 1)
  {
    for (int j = 0; j < matr.GetLength(1); j = j + 1)
    {
      System.Console.Write(matr[i, j] + " ");
    }
    System.Console.WriteLine();
  }
}

int[] SumStringArray(int[,] matr)
{
  int[] array = new int[matr.GetLength(0)];

  //for(int k = 0; k < matr.GetLength(0); k = k + 1)
  {

    for (int i = 0; i < matr.GetLength(0); i = i + 1)
    {
      int sum = 0;
      for (int j = 0; j < matr.GetLength(1); j = j + 1)
      {
        sum = sum + matr[i, j];
        array[i] = sum;


      }

    }

  }
  return array;
}

void PrintArray(int[] array)
{
  System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


void IndexMin(int[] array)
{
  int min = array[0];
  int index = 0;
  for(int i = 0; i < array.Length; i = i + 1)
  {
    if(min > array[i])
    {
      min = array[i];
      index = i;
    }
    
  }
  Console.WriteLine("Номер строки с наименьшей суммой: " + index);
}

const int m = 4;
const int n = 4;
var matrix = GenerateMatrix(m, n);
PrintMatrix(matrix);
System.Console.WriteLine();
var array = SumStringArray(matrix);
PrintArray(array);
System.Console.WriteLine();
IndexMin(array);





