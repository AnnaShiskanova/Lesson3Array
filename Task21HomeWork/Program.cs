// напишите программу, которая на входе принимает координаты двух точек, а на выходе
// выдает расстояние между ними в 3D пространстве
// A (3,6,8); B(2,1,-7)->15,84
// A (7,-5,0); B(1,-1,9)->11,53
// distanse=Math.Sqrt((x2-x1)^2+(y2-y1)^2+(z2-z1)^2)

double[] A = new double[3];
System.Console.WriteLine("Enter x from A: ");
A[0] = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter y from A: ");
A[1] = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter z from A: ");
A[1] = Convert.ToDouble(Console.ReadLine());

double[] B = new double[3];
System.Console.WriteLine("Enter x from B: ");
B[0] = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter y from B: ");
B[1] = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter z from B: ");
B[1] = Convert.ToDouble(Console.ReadLine());

double difX = B[0]-A[0];
double difY = B[1]-A[1];
double difZ = B[2]-A[2];

double distance = Math.Sqrt(Math.Pow(difX, 2) + Math.Pow(difY, 2) + Math.Pow(difZ, 2));
System.Console.WriteLine($"Distance between A and B: {Math.Round(distance, 2)}");



