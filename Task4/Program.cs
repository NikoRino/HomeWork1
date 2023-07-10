Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
n = Math.Abs(n);

Console.WriteLine("Четные числа", n);

for (int i = 2; i < n - 1; i = i + 2)
{
    Console.Write(i + ", ");
}

if (n % 2 == 0)
    Console.Write(n);
else
    Console.Write(n - 1);