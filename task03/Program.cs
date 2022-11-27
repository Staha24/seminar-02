// task12
Console.Write("Введите первое число: ");
int n =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m =Convert.ToInt32(Console.ReadLine());

if (n % m == 0)
    Console.Write ("Кратно");
else
    Console.Write ($"Не кратно, остаток {n % m}");
    
