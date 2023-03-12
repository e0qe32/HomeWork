// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputValues(string text)
{
  System.Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}

int AkkermanFunction(int n, int m)
{
  if(n == 0)
  {
    return (m + 1);
  }
  else if(n != 0 && m == 0)
  {
    return AkkermanFunction(n - 1, 1);
  }
  else
  {
    return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
  }
}


int n = InputValues("Введите число n: ");
int m = InputValues("Введите число m: ");
System.Console.WriteLine();
System.Console.WriteLine(AkkermanFunction(n, m));

