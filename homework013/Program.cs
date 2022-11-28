//task13
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
 int n1 = n % 10;
if ( n >=100)
    Console.Write(n1);
else
    Console.Write("Третьей цифры нет");


