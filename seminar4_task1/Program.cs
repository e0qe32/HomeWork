// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵); 2, 4 -> 16

int ReadIntA(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}
int ReadIntB(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

int Degree(int numberA, int numberB)
{
  int result = 1;
  for(int i = 1; i <= numberB; i = i + 1)
  {
    result = result * numberA;
  }
  return result;
}
int numberA = ReadIntA("Введите число A: ");
int numberB = ReadIntB("Введите число B: ");
System.Console.WriteLine($"Результат возведения числа A в степень числа B равно {Degree(numberA, numberB)}");

