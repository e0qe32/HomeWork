// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве. 
// [345, 897, 568, 234] -> 2


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

int EvenNumbers(int[] array)
{
  int count = 0;
  for(int i = 0; i < array.Length; i = i + 1)
  {
    if(array[i] % 2 == 0)
    {
      count = count + 1;
    }
    
  }
  return count;

}
const int SIZE = 20;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 999;  
int[] array = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE); 
PrintArray(array); 
System.Console.WriteLine($"Кол-во четных элементов в массиве: {EvenNumbers(array)}");


