// // Напишите программу, которая на вход принимает пятизначное число и проверяет, является ли оно палиндромом
// 14212 -> no
// 23432 -> yes
// 12821 -> yes

System.Console.WriteLine("Enter a five-digit number");
int n = Convert.ToInt32(Console.ReadLine());
if (n / 10000 == 0 || n / 10000 > 9)
{
    Console.WriteLine("Incorrect number");
}
else
{
    string y = Convert.ToString(n);
    for (int i = 0; i < y.Length; i++)
{
    char d = y[i];  
}
    if (y[0] == y[4] && y[1] == y[3])
    Console.WriteLine($"{n} is palindrome");
else
    Console.WriteLine($"{n} isn't palindrome");
}

