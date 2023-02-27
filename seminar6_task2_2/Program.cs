/// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,  
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2  
//задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 
 
void PrintArray(double[] array) 
{ 
  System.Console.WriteLine("[" + string.Join(", ", array) + "]"); 
} 
 
// Размер массива это целое число, поэтому тип будет int. У массива может быть тип double, но его размер только целый.  
/// Мы же не можем объявить массив на два с половиной элемента) 
double[] InputArray(int size) 
{ 
    double[] arr = new double[size]; 
 
    for (int i = 0; i < arr.Length; i = i + 1) 
    { 
      System.Console.WriteLine("Введите число: "); 
      arr[i] = Convert.ToDouble(Console.ReadLine()); 
    } 
 
    return arr; 
} 
 
// В типе функции вы указываете, что возвращаете переменную типа double, но в коде вы возвращаете массив 
// Чтобы вернуть массив, нужно прописывать double[] 
// Также возврат массив должен быть ВНУТРИ функции, а не снаружи 
// Вы перезаписываете значения в отдельные переменные, тогда от массива толку мало 
// Используете лишнюю память, лучше обращайтесь напрямую к массиву 
// Когда вы посчитаете х, то нет смысла считать его еще раз в формуле у, сразу подставляйте туда х 
 
double[] PointCrossing(double[] arr) 
{ 
    double[] point = new double[2]; 
    point[0] = (arr[2] - arr[0]) / (arr[1] - arr[3]); 
    point[1] = arr[1] * point[0] + arr[0]; 
 
    return point; 
} 
 
// Опять же, размер массива это целое число 
int M = 4; 
double[] array = InputArray(M); 
PrintArray(array); 
double[] point = PointCrossing(array); 
PrintArray(point);
