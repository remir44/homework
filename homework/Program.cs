﻿// Задача 2:
// Console.Write("Введите число a:");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число b:");
// int b = int.Parse(Console.ReadLine()!);
// if (a > b)
// {
//     Console.WriteLine("Число a = " + a + " максимальное.");
// }
// else
// {
//     Console.WriteLine("Число b = " + b + " максимальное.");
// }

// Задача 4:
// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число b: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число c: ");
// int c = int.Parse(Console.ReadLine()!);
// int max = a;
// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// Console.WriteLine("Максимальное число = " + max);

// Задача 6:
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num % 2 != 0)
{
    Console.WriteLine("Число " + num + " не четное.");
}
else
{
    Console.WriteLine("Число " + num + " четное.");
}