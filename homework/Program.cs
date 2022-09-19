// Задача 2:
Console.WriteLine("  Задача на большее число из двух. ");
Console.Write("Введите число d: ");
int d= int.Parse(Console.ReadLine()!);
Console.Write("Введите число e: ");
int e = int.Parse(Console.ReadLine()!);
if (d > e)
{
    Console.WriteLine("Число d = " + d + " максимальное.");
}
else
{
    Console.WriteLine("Число e = " + e + " максимальное.");
}

// Задача 4:
Console.WriteLine("  Задача на большее число из трех. ");
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("Максимальное число = " + max);

// Задача 6:
Console.WriteLine("  Задача на проверку четности/нечетности числа. ");
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

// Задача 8:
Console.WriteLine("  Задача на вывод всех четных чисел от 1 до N. ");
Console.Write("Введите длину N: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (N > i)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    i++;
}