int number = int.Parse(Console.ReadLine());

decimal result = 0;

for (int i = 1; i <= number; i++)
{
    decimal n = decimal.Parse(Console.ReadLine());
    result += n;
}

Console.WriteLine(result);