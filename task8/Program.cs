 /*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

for (int x = 2; x < 101; x++)
if (x % 2 == 0)
Console.WriteLine (x);