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
int secret_number = 4;
while (true)
{
    Console.WriteLine("Введите число от 1 до 10: ");
    int number = int.Parse(Console.ReadLine());
    if(number > secret_number)
    {
        Console.WriteLine("Секретное число меньше");
    }
    else if(number < secret_number)
    {
        Console.WriteLine("Секретное число больше");
    }
    else if(number == secret_number)
    {
        Console.WriteLine("Вы угадали!!");
    }
}
