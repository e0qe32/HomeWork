// Задача 60. ...Сформируйте трёхмерный массив двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.

int[ , , ] GenerateMatrix(int m, int n, int k)
{
  int[ , , ] matrix = new int[m, n, k];
  Random rand = new Random();
  for (int x = 0; x < m; x = x + 1)
  {
    for (int y = 0; y < n; y = y + 1)
    {
      for (int z = 0; z < k; z = z + 1)
      {
        matrix[x, y, z] = rand.Next(10, 100);
      }
      
    }
  }
  return matrix;
}

void PrintMatrix(int[ , , ] matr)
{
  for (int x = 0; x < matr.GetLength(0); x = x + 1)
  {
    for (int y = 0; y < matr.GetLength(1); y = y + 1)
    {
      for (int z = 0; z < matr.GetLength(2); z = z + 1)
      {
        System.Console.Write(" " + matr[x, y, z] + "(" + x + "," + y + "," + z +")");
      }
    }
    
    System.Console.WriteLine();
  }
}


const int m = 2;
const int n = 2;
const int k = 2;
var matrix = GenerateMatrix(m, n, k);
PrintMatrix(matrix);
System.Console.WriteLine();
