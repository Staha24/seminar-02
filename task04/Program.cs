﻿// task14
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 ==0)
{
    if (n % 23 ==0)
        Console.Write("yes");
    else
        Console.Write("no");    
}
else
    Console.Write("no");
    
