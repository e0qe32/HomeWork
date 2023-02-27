// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PrintArray(double[] array)
{
  System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double[] InputArray(int size)
{
  //System.Console.WriteLine(text);
  //return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
  double[] arr = new double[size];
  for(int i = 0; i < arr.Length; i = i + 1)
  {
    System.Console.WriteLine("Введите число: ");
    arr[i] = Convert.ToDouble(Console.ReadLine());
  }
  return arr;
  
}

double CoordinateX(double[] arr)
{
  //double[] point = new double[2];
  //double b1 = arr[0];
  //double k1 = arr[1];
  //double b2 = arr[2];
  //double k2 = arr[3];
  double x = (arr[2] - arr[0]) / (arr[1] - arr[3]);
  //point[0] = x;
  //point[1] = y;
  return x;
}
//return point;

double CoordinateY(double[] arr)
{
  //double[] point = new double[2];
  //double b1 = arr[0];
  //double k1 = arr[1];
  //double b2 = arr[2];
  //double k2 = arr[3];
  double y = ((arr[1] * (arr[2] - arr[0])/(arr[1] - arr[3]) ) + arr[0]);
  return y;
}



int M = 4;
double[] array = InputArray(M);
PrintArray(array);
//double[] point = PointCrossing(array);
//PrintArray(point);
System.Console.WriteLine($"Координата X точки: {CoordinateX(array)}");
System.Console.WriteLine($"Координата Y точки: {CoordinateY(array)}");
