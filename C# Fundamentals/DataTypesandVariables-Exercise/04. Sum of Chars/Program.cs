int num = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= num; i++)
{
    char symbol = char.Parse(Console.ReadLine());
    sum += symbol;
}

Console.WriteLine($"The sum equals: {sum}");