int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int counter = 1;
int longest = 0;
int elements = 0;

for (int i = 0; i < numbers.Length - 1; i++)
{
    if (numbers[i] == numbers[i + 1])
    {
        counter++;
    }
    else
    {
        counter = 1;
    }
    if (counter > longest)
    {
        longest = counter;
        elements = numbers[i];
    }
}

for (int i = 0; i < longest; i++)
{
    Console.Write($"{elements} ");
}