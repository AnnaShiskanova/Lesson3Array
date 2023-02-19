// напишите программу, которая на входе принимает координаты точки X и Y, при чем Х не равно  0 и
// Y не равно 0 и выдает номер четверти, в которой находится эта точка

int[] points = new int[2];
for (int i = 0; i < points.Length; i++)
{
    while (true)
    {
    points[i] = Convert.ToInt32(Console.ReadLine());
    if (points[i] != 0)
        break;
    else
    Console.WriteLine("Incorrect input");
    }
}
if (points[0] > 0 && points[1] > 0)//x>0 and y>0,
    Console.WriteLine("1");
else if (points[0] < 0 && points[1] > 0)//x<0 and y>0
    Console.WriteLine("2");
else if (points[0] < 0 && points[1] < 0)//x<0 and y<0
    Console.WriteLine("3");
else Console.WriteLine("4");   //x>0 and y<0 



