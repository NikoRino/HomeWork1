Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    if (num1 > num3)
        Console.WriteLine($"Первое число больше: {num1}");
    else
        Console.WriteLine($"Третье число больше: {num3}");
else if (num2 > num1)
    if (num2 > num3)
        Console.WriteLine($"Второе число больше: {num2}");
    else
        Console.WriteLine($"Третье число больше: {num3}");
