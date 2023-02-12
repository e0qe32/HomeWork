// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите цифру, которая соответствует дню недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
  System.Console.WriteLine("День недели является выходным");
}
else
{
  System.Console.WriteLine("День не выходной");
}
