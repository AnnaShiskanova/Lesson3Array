// напишите программу, которая на вход принимает координаты двух точек 
//и находит расстояние между ними в 2D простарстве
// А (3,6) B(2,1) расстояние 5,09
// A (7,-5) B (1,-1) расстояние 7,21


Console.WriteLine("Enter x1");
double x1 = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Enter y1");
double y1 = Convert.ToUInt32(Console.ReadLine());
System.Console.WriteLine("Enter x2");
double x2 = Convert.ToUInt32(Console.ReadLine());
System.Console.WriteLine("Enter y2");
double y2 = Convert.ToUInt32(Console.ReadLine());
double x3 = Math.Pow(x1-x2, 2);
double y3 = Math.Pow(y1-y2, 2);
double distance = Math.Sqrt(x3 + y3);

Console.WriteLine($"{distance}");



