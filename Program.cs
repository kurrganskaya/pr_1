// Задача 4: Найти максимальное из трёх чисел.

int num1 = 32 ;
int num2 = 21 ;
int num3 = 13 ;

int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;


Console.Write("max = ");
Console.WriteLine(max);
