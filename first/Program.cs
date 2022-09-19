// int num = 12;
// Console.WriteLine("Месяцев в году " + num + num);

// Console.WriteLine("How old are you?");
// int age = int.Parse(Console.ReadLine());
// Console.WriteLine("You are " + age + " years old");

// Console.WriteLine("Введите число a");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число b");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine(a + b);

Console.WriteLine("Вы попали в игру угадай число");
int secret_number = new Random().Next(1, 11);
int attempt = 5;
bool win = false;
while (attempt > 0)
{
    Console.Write("Введите число от 1 до 10: ");
    int number = int.Parse(Console.ReadLine()!);
    if (number > secret_number)
    {
        Console.WriteLine("Секретное число меньше");
        attempt--;
    }
    else if (number < secret_number)
    {
        Console.WriteLine("Секретное число больше");
        attempt--;
    }
    else if (number == secret_number)
    {
        Console.WriteLine("Вы угадали!!");
        win = true;
        break;
    }
    Console.WriteLine("  Осталось попыток " + attempt);
}
if (win)
{
    Console.WriteLine("  Вы победили, увидимся в следующий раз!");
}
else
{
    System.Console.WriteLine("  Вы проиграли, секретное число - " + secret_number);
    System.Console.WriteLine("  Попробуйте еще раз :)");
}