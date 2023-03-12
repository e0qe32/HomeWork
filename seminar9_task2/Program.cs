// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. M = 1; N = 15 -> 120; 
//M = 4; N = 8. -> 30

int InputValues(string text)
{
  System.Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}

int SumOfNumbers(int m, int n)
{
  int sum = m;
  if(m == n)
  {
    return 0;
  }
  else
  {
    m = m + 1;
    sum = m + SumOfNumbers(m, n);
    return sum;
  }
  
}

int m = InputValues("Введите число m: ");
int n = InputValues("Введите число n: ");
System.Console.WriteLine();
System.Console.WriteLine(SumOfNumbers(m-1, n));


