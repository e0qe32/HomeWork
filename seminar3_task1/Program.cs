// Задача 19 Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да, 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();
if(number.Length <=4 || number.Length>5)
{
  System.Console.WriteLine("Число не пятизначное");
}
else
{
  if( number [0] ==  number [4] &&  number [1] ==  number [3])
  {
    System.Console.WriteLine($"Число {number} является палиндромом");
  }
  else
  {
    System.Console.WriteLine($"Число {number} не является палиндромом");
  }
}

