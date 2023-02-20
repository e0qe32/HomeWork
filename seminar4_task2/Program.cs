// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
// цифр в числе. 452 -> 11; 82 -> 10; 012 -> 12

int ReadInt(string text)
{
  System.Console.WriteLine(text);
  return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Summa(int number)
{
  int sum = 0;
  while(number > 0)
  {
    sum = sum + (number % 10);
    number = number / 10;
  }
  return sum;
}


int number = ReadInt("Введите число: ");
System.Console.WriteLine(($"Сумма цифр = {Summa(number)}"));




