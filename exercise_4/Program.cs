﻿// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int i = a;
while (i >=1 && i <= a)
{ 
    if (i % 2 == 0)
{
    Console.WriteLine($"{i}");
    i = i - 1;
}
    else
{
    i = i - 1;
}
}