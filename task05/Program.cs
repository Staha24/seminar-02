// task16
Console.Write ("Введите 1-ое чмсло: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите 2-ое чмсло: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n * n == m)
    Console.Write ("yes");
else
{
    if (m * m == n)
        Console.Write ("yes");
    else 
        Console.Write ("no");
}
