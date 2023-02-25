// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76

double[] GenerateArray(int size)
{
  double[] array = new double[size];
  Random rand = new Random();
  for (int i = 0; i < size; i = i + 1)
  {
    //array[i] = rand.NextDouble() * 10 - 5; // от -5 до 5
    array[i] = rand.Next(0, 3) + rand.NextDouble();
  }
  return array;
}

void PrintArray(double[] array)
{  
  System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double MaxArray(double[] array)
{
  double max = array[0];
  for(int i = 1; i < array.Length; i = i + 1)
  {
    if(array[i] > max)
    {
      max = array[i];
    }
  }
  return max;
}

double MinArray(double[] array)
{
  double min = array[0];
  for(int i = 1; i < array.Length; i = i + 1)
  {
    if(array[i] < min)
    {
      min = array[i];
    }
  }
  return min;
}


const int SIZE = 10;
double[] array = GenerateArray(SIZE); 
PrintArray(array);
System.Console.WriteLine($"Разность между макс-м и мин-м значениями массива: {MaxArray(array) - MinArray(array)}");


