// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19; 
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int size, int leftRange, int rightRange)
{
  int[] array = new int[size];
  Random rand = new Random();
  for (int i = 0; i < size; i = i + 1)
  {
    array[i] = rand.Next(leftRange, rightRange + 1);
  }
  return array;
}

void PrintArray(int[] array)
{  
  System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int Summa(int[] array)
{
  int summa = 0;
  for(int i = 0; i < array.Length; i = i + 1)
  {
    if(i % 2 != 0)
    {
      summa = summa + array[i];
    }
  }
  return summa;
}

const int SIZE = 17;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;  
int[] array = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE); 
PrintArray(array); 
System.Console.WriteLine($"Сумма элементов массива на нечетных позициях: {Summa(array)}");
