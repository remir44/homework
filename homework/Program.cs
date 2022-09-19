// Первая задача
Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b:");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine("Число a = " + a + " максимальное.");
}
else
{
    Console.WriteLine("Число b = " + b + " максимальное.");
}