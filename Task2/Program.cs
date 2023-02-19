// Напишите программу, которая по заданному номеру четверти, показывает 
//диапазон возможных координат точек в этой четверти

Console.WriteLine("Enter a number from 1 to 4");
int i = Convert.ToInt32(Console.ReadLine());
if (i == 1)
    Console.WriteLine("x > 0 and y > 0");
else if (i == 2)
    Console.WriteLine("x < 0 and y > 0");
else if (i == 3)
    Console.WriteLine("x < 0 and y < 0");
else
    Console.WriteLine("x > 0 and y < 0");
 
