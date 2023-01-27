Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1;

if (number2 >= result)
{
    result = number2;
}

System.Console.WriteLine($"max = {result}");
