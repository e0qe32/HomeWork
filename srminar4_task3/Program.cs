// Задача 29: Напишите программу, которая задаёт массив из n элементов и 
// выводит их на экран.

int ReadInt(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}


void FillArray(int[] arr, int n)
{
    for(int i = 0; i < arr.Length; i = i + 1)
  {
    arr[i] = new Random().Next(1, 100);
  }

}

void PrintArray(int[] arr, int n)
{
  for(int i = 0; i < arr.Length; i = i + 1)
  {
    System.Console.Write(arr[i] + " ");
  }
  
}

int n = ReadInt("Введите число n: ");
int[] array = new int[n];
FillArray(array, n);
PrintArray(array, n);

