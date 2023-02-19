// Напишите программу, которая на вход принимает пятизначное число и проверяет, является ли оно палиндромом
// 14212 -> no
// 23432 -> yes
// 12821 -> yes

System.Console.WriteLine("Enter a five-digit number");
int n = Convert.ToInt32(Console.ReadLine());
if (n / 10000 == 0 || n / 100000 > 9)
{
    Console.WriteLine("Incorrect number");
}
else
{
    string str = n.ToString();
    int[] N = new int[str.Length];
    for (int i=0; i<str.Length; i++)
    {
        N[i]=int.Parse(str[i].ToString());
    }
if (N[0] == N[4] && N[1] == N[3])
    System.Console.WriteLine($"{n} is palindrome");
else
    System.Console.WriteLine($"{n} isn't palindrome");
}

//     string str = a.ToString();
// int[] b = new int[str.Length];
// for( int i=0; i< str.Length; i++)
// {
//      b[i] = int.Parse(str[i].ToString());
// }
//


