// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int[] arrayA = new int[3];
System.Console.WriteLine("Введите координату x точки А: ");
arrayA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки A: ");
arrayA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки A: ");
arrayA[2] = Convert.ToInt32(Console.ReadLine());

int[] arrayB = new int[3];
System.Console.WriteLine("Введите координату x точки B: ");
arrayB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки B: ");
arrayB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки B: ");
arrayB[2] = Convert.ToInt32(Console.ReadLine());

int distX = (int) Math.Pow(arrayB[0]-arrayA[0], 2);
int distY = (int) Math.Pow(arrayB[1]-arrayA[1], 2);
int distZ = (int) Math.Pow(arrayB[2]-arrayA[2], 2);

double distance = Math.Sqrt (distX + distY + distZ);
System.Console.WriteLine("Расстояние между двумя точками в пространстве равно: " + Math.Round(distance, 2));
