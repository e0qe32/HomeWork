// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <= 99)
{
  System.Console.WriteLine("Третьей цифры нет");
}
else if (num >= 100 && num <= 999)
{
  System.Console.WriteLine("Третья цифра равна: " + num % 10);
}
else if (num >= 1000 && num <= 9999)
{
  System.Console.WriteLine("Третья цифра равна: " + ((num % 100 - num %10)/10));
}
else if (num >= 10000 && num <= 99999)
{
  System.Console.WriteLine("Третья цифра равна: " + ((num % 1000 - num %100)/100));
}
