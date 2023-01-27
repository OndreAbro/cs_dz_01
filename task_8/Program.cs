Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 0)
{
    Console.Write("Чётные числа от -1 до N: ");
    for (int i = 2; i <= -N; i += 2)
        Console.Write("-" + i + " ");
}
else
{
    Console.Write("Чётные числа от 1 до N: ");
    for (int i = 2; i <= N; i += 2)
    {
        Console.Write(i + " ");
    }
}