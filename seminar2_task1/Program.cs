// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
  System.Console.WriteLine("Вторая цифра трехзначного числа равна: " + ((number / 10) - (number / 100)*10));
}
else
{
  System.Console.WriteLine($"Число {number} не трехзначное");
}
