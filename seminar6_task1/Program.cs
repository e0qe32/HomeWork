// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
  System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] InputArray(int size)
{
  //System.Console.WriteLine(text);
  //return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
  int[] arr = new int[size];
  for(int i = 0; i < arr.Length; i = i + 1)
  {
    System.Console.WriteLine("Введите число: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
  }
  return arr;
  
}

int MoreThanZero(int[] array)
{
  int count = 0;
  for(int i = 0; i < array.Length; i = i + 1)
  {
    if(array[i] > 0)
    {
      count = count + 1;
    }
  }
  return count;
}

int M = 8;
int[] array = InputArray(M);
PrintArray(array);
System.Console.WriteLine($"Кол-во чисел больше нуля: {MoreThanZero(array)}");


